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
    }
}
