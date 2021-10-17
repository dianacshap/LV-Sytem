using aDefinir.LvSystemDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDefinir
{
    public partial class CadAgenda : Form
    {
        public CadAgenda()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(lvSystemDataSet.Agendamento);
                groupBox1.Enabled = false; //Bloqueia Groupbox após salvar
                MessageBox.Show("Agendamento Salvo, Informe os Serviços","LvSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodServ.Focus();


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
            Finalizado();
        }

        private void CadAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_Total_Servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_Total_ServicosTableAdapter.Fill(this.lvSystemDataSet.View_Total_Servicos);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.lvSystemDataSet.Servico);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_Servico_Agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.view_Servico_AgendamentoTableAdapter.Fill(this.lvSystemDataSet.View_Servico_Agendamento);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_ServicoAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.lvSystemDataSet.Carros);
            this.agendamentoTableAdapter.Fill(this.lvSystemDataSet.Agendamento);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.AddNew();
            situacaoComboBox.Text = "Agendado";
            dataAgMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            horaMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            totalTextBox.Text = "0.00";
            groupBox1.Enabled = true;


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try //Tratamento de erro
            {
                if (MessageBox.Show("Confirma a exclusão do registro", "LVSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agendamentoBindingSource.RemoveCurrent();//remove
                    agendamentoTableAdapter.Update(lvSystemDataSet.Agendamento);//salva

                }

            }
            catch (Exception)//se "ele" não conseguir aqui captura o erro 
            {
                agendamentoTableAdapter.Fill(lvSystemDataSet.Agendamento); //se não tiver esse metodo, o registro é excluido mas ainda fica no bd
                MessageBox.Show("Registro não pode ser excluido");
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }


        private void txtCodServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodServ.Text != "")
            {
                servicoBindingSource.Filter = "Id =" + txtCodServ.Text;
                if (servicoBindingSource.Count == 1)//encotrou registro
                {
                    //Cria variável com todos os dados do registro encontrado
                    DataRowView ServicoEncontrado = (DataRowView)servicoBindingSource.Current;
                    txtServico.Text = ServicoEncontrado["Nome"].ToString();//pega coluna e preenche TextBox
                    txtValorUnit.Text = ServicoEncontrado["Valor"].ToString();
                    txtQtd.Text = "1";
                    txtQtd.SelectAll();
                    txtQtd.Focus();


                }
                else // abrir cadastro para localizar
                {
                    CadServicos serv = new CadServicos();
                    serv.Show();

                }
            }
        }

        private void btnAddServ_Click(object sender, EventArgs e)
        {
            try
            {
                
                agendamentosServicosTableAdapter.InserirServico(int.Parse(txtQtd.Text),
                   decimal.Parse(txtValorUnit.Text),
                   int.Parse(txtCodigo.Text),
                   int.Parse(txtCodServ.Text));
                //Limpar todas as textboxes
                txtCodServ.Clear();
                txtServico.Clear();
                txtValorUnit.Clear();
                txtQtd.Clear();
                txtCodServ.Focus();

                //Atualiza Grid
                Atualizar_Servico();
            }
            catch (Exception)
            {

                MessageBox.Show("Tente Novamente");
            }
            Total();
        }
        private void Atualizar_Servico()
        {
            if (txtCodigo.Text != "") //pesquisar
            {
                //Recarrega os dados
                view_Servico_AgendamentoTableAdapter.Fill(lvSystemDataSet.View_Servico_Agendamento);
                //Filtra pelo código do agendamento
                view_Servico_AgendamentoBindingSource.Filter = "Agendamentos_Codigo =" + txtCodigo.Text;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Atualizar_Servico();
            
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQtd.Text != "")
            {
                txtValorUnit.SelectAll();
                txtValorUnit.Focus();

            }
        }

        private void txtValorUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtValorUnit.Text != "")
            {
                btnAddServ_Click(sender, e);
            }
        }

        private void view_Servico_AgendamentoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo = int.Parse(view_Servico_AgendamentoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            try
            {
                agendamentosServicosTableAdapter.Remover_Servico(codigo);
            }
            catch (Exception)
            {


            }
            Atualizar_Servico();
            Total();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Após finalizado o agendamento não poderá ser mais alterado", "LvSystem", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                situacaoComboBox.Text = "Finalizado";
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(lvSystemDataSet.Agendamento);
                MessageBox.Show("Agendamento Finalizado com Sucesso","LvSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Bloquear quando finalizado
                Finalizado();
            }
        }

        private void Finalizado()
        {
            if (situacaoComboBox.Text == "Finalizado" )
            {
                agendamentoBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnFinalizar.Enabled = false;
                carro_IdComboBox.Enabled = false;
                txtCodServ.Enabled = false;
                btnPesquisar.Enabled = false;
                txtServico.Enabled = false;
                txtQtd.Enabled = false;
                txtValorUnit.Enabled = false;
                view_Servico_AgendamentoDataGridView.Enabled = false;


            }
            else
            {
                agendamentoBindingNavigatorSaveItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnFinalizar.Enabled = true;
                carro_IdComboBox.Enabled = true;
                servicos.Enabled = true;
                txtCodServ.Enabled = true;
                btnPesquisar.Enabled = true;
                txtServico.Enabled = true;
                txtQtd.Enabled = true;
                txtValorUnit.Enabled = true;
                view_Servico_AgendamentoDataGridView.Enabled = true;
            }
        }

        private void agendamentoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Finalizado();
        }
        private void Total()
        {
            if (txtCodigo.Text != "")
            {
                view_Total_ServicosTableAdapter.Fill(lvSystemDataSet.View_Total_Servicos); //Carregar Dados
                view_Total_ServicosBindingSource.Filter = "Agendamentos_Codigo =" + txtCodigo.Text;
                if (view_Total_ServicosBindingSource.Count == 1)
                {
                    //Pegar o total e jogar na textBox
                    DataRowView Resultado = (DataRowView)view_Total_ServicosBindingSource.Current;
                    totalTextBox.Text = Resultado["Total"].ToString();
                    agendamentoTableAdapter.Update(lvSystemDataSet.Agendamento);
                }
                else //Se não tiver itens no serviço o total é zero
                {
                    totalTextBox.Text = "0.00";
                    agendamentoTableAdapter.Update(lvSystemDataSet.Agendamento);
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            FrmLocalizarVeiculo frmLocalizarVeiculo = new FrmLocalizarVeiculo();
            frmLocalizarVeiculo.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado > 0)
            {
                //Posicionar Código Localizado
                carrosBindingSource.Position = carrosBindingSource.Find("Id", VariaveisGlobais.CodigoLocalizado);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            FrmLocalizarServicos frmLocalizarServico = new FrmLocalizarServicos();
            frmLocalizarServico.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado > 0)
            {
                //Posicionar Código Localizado
                txtCodServ.Text = VariaveisGlobais.CodigoLocalizado.ToString();
                txtCodServ.Focus();
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Frm_RelatorioAgendamentos frmRelatorioAgendamento = new Frm_RelatorioAgendamentos();
            frmRelatorioAgendamento.ShowDialog();
        }
    }
}
