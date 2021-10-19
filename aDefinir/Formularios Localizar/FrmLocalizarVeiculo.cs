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
    public partial class FrmLocalizarVeiculo : Form
    {
        public FrmLocalizarVeiculo()
        {
            InitializeComponent();
        }

        private void FrmLocalizarVeículo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_Carro_Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.view_Carro_ClientesTableAdapter.Fill(this.lvSystemDataSet.View_Carro_Clientes);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        

        private void txtNomeLocalizarVeiculo_TextChanged(object sender, EventArgs e)
        {
            view_Carro_ClientesBindingSource.Filter = "Modelo like '" + txtNomeLocalizarVeiculo.Text + "%'";

        }

        private void view_Carro_ClientesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pega valor selecionado com dois cliques na DataGridView Clientes
                VariaveisGlobais.CodigoLocalizado = int.Parse(view_Carro_ClientesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                VariaveisGlobais.CodigoLocalizado = 0;
            }
            this.Dispose();
        }
    }
}
