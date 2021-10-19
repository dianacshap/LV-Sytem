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
    public partial class FrmLocalizarProduto : Form
    {
        public FrmLocalizarProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void FrmLocalizarProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lvSystemDataSet.Produto);

        }

        private void txtNomeLocalizar_TextChanged(object sender, EventArgs e)
        {
            produtoBindingSource.Filter = "Nome like '" + txtNomeLocalizar.Text + "%'";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void produtoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pega valor selecionado com dois cliques na DataGridView Clientes
                VariaveisGlobais.CodigoLocalizado = int.Parse(produtoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                VariaveisGlobais.CodigoLocalizado = 0;
            }

            this.Dispose();
        }
    }
}
