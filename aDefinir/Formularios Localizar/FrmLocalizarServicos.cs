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
    public partial class FrmLocalizarServicos : Form
    {
        public FrmLocalizarServicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void FrmLocalizarServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.lvSystemDataSet.Servico);

        }

        private void txtNomeDoServico_TextChanged(object sender, EventArgs e)
        {
            servicoBindingSource.Filter = "Nome like '" + txtNomeDoServico.Text + "%'";
        }

        private void servicoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pega valor selecionado com dois cliques na DataGridView Clientes
                VariaveisGlobais.CodigoLocalizado = int.Parse(servicoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
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
