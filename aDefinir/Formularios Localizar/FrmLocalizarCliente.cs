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
    public partial class FrmLocalizarCliente : Form
    {
        public FrmLocalizarCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void FrmLocalizar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lvSystemDataSet.Clientes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "Nome like '" + txtNomeLocalizar.Text + "%'";
        }

        private void clientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pega valor selecionado com dois cliques na DataGridView Clientes
                VariaveisGlobais.CodigoLocalizado = int.Parse(clientesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                VariaveisGlobais.CodigoLocalizado = 0;
            }
      
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
