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
    public partial class FrmRelatorioServicos : Form
    {
        public FrmRelatorioServicos()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void FrmRelatorioServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.lvSystemDataSet.Servico);
            RelatorioServicos1.SetDataSource(lvSystemDataSet);
            crystalReportViewer1.ReportSource = RelatorioServicos1;

        }
    }
}
