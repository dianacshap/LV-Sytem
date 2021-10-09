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
                MessageBox.Show("Registro Salvo");


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

        }

        private void CadAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_ServicoAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.view_ServicoAgendamentoTableAdapter.Fill(this.lvSystemDataSet.View_ServicoAgendamento);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.ServicoAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoAgendamentoTableAdapter.Fill(this.lvSystemDataSet.ServicoAgendamento);
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
    }
}
