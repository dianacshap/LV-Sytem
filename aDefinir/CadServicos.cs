﻿using System;
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
    public partial class CadServicos : Form
    {
        public CadServicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void CadServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lvSystemDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_Servico_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.view_Servico_ProdutoTableAdapter.Fill(this.lvSystemDataSet.View_Servico_Produto);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.ServicoProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoProdutoTableAdapter.Fill(this.lvSystemDataSet.ServicoProduto);
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.lvSystemDataSet.Servico);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorioServicos frmRelatorioServicos = new FrmRelatorioServicos();
            frmRelatorioServicos.ShowDialog();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            FrmLocalizarServicos frmLocalizarServico = new FrmLocalizarServicos();
            frmLocalizarServico.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado > 0)
            {
                //Posicionar Código Localizado
                servicoBindingSource.Position = servicoBindingSource.Find("Id", VariaveisGlobais.CodigoLocalizado);
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodigo.Text != "")
            {
                produtoBindingSource.MoveFirst();
                produtoBindingSource.Filter = "Id =" + txtCodigo.Text;
                if (produtoBindingSource.Count == 1)
                {
                    DataRowView ProdutoEncontrado = (DataRowView)produtoBindingSource.Current;
                    txtProduto.Text = ProdutoEncontrado["Nome"].ToString();//pega coluna e preenche TextBox
                    txtQuantidadeUtilizada.Text = "1";
                    txtQuantidadeUtilizada.Focus();
                }
                else
                {
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                servicoProdutoTableAdapter.InserirProdutoServico(txtQuantidadeUtilizada.Text,
                   int.Parse(txtCodigo.Text),
                   int.Parse(idTextBox.Text));

                //Atualiza Grid
                Atualizar_Produto();
                //Limpar todas as textboxes
                txtQuantidadeUtilizada.Clear();
                txtCodigo.Focus();
                txtCodigo.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Tente Novamente");
            }
            //Total();
        }
        private void Atualizar_Produto()
        {
            if (idTextBox.Text != "") //pesquisar
            {
                //Recarrega os dados
                view_Servico_ProdutoTableAdapter.Fill(lvSystemDataSet.View_Servico_Produto);
                //Filtra pelo código do agendamento
                view_Servico_ProdutoBindingSource.Filter = "Servico_Id =" + idTextBox.Text;
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_Produto();
        }

        private void txtQuantidadeUtilizada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQuantidadeUtilizada.Text != "")
            {
                btnAdicionar_Click(sender, e);

            }
        }

        private void view_Servico_ProdutoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo = 0;
                codigo =int.Parse(view_Servico_ProdutoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                servicoProdutoTableAdapter.Remover_Produto(codigo);       
            }
            catch (Exception)
            {

            }
            Atualizar_Produto();
        }
    }
}
