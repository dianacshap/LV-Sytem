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
    public partial class FrmRelatorioVeiculos : Form
    {
        public FrmRelatorioVeiculos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioVeiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.View_Rel_Carros_Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.view_Rel_Carros_ClientesTableAdapter.Fill(this.lvSystemDataSet.View_Rel_Carros_Clientes);
            RelatorioCarros4.SetDataSource(lvSystemDataSet);
            crystalReportViewer1.ReportSource = RelatorioCarros4;       
        }
    }
}
