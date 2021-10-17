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
    public partial class Frm_RelatorioAgendamentos : Form
    {
        public Frm_RelatorioAgendamentos()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioAgendamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Relatorio_Agendamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.relatorio_AgendamentosTableAdapter.Fill(this.lvSystemDataSet.Relatorio_Agendamentos);
            RelatorioAgendamentos1.SetDataSource(lvSystemDataSet);
            crystalReportViewer1.ReportSource = RelatorioAgendamentos1;

        }
    }
}
