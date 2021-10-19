
namespace aDefinir
{
    partial class Frm_RelatorioAgendamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioAgendamentos1 = new aDefinir.RelatorioAgendamentos();
            this.relatorio_AgendamentosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.Relatorio_AgendamentosTableAdapter();
            this.relatorio_AgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio_AgendamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.AgendamentosServicosTableAdapter = null;
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RelatorioAgendamentos1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // relatorio_AgendamentosTableAdapter
            // 
            this.relatorio_AgendamentosTableAdapter.ClearBeforeFill = true;
            // 
            // relatorio_AgendamentosBindingSource
            // 
            this.relatorio_AgendamentosBindingSource.DataMember = "Relatorio_Agendamentos";
            this.relatorio_AgendamentosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // Frm_RelatorioAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_RelatorioAgendamentos";
            this.Text = "Frm_RelatorioAgendamentos";
            this.Load += new System.EventHandler(this.Frm_RelatorioAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio_AgendamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LvSystemDataSet lvSystemDataSet;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RelatorioAgendamentos RelatorioAgendamentos1;
        private LvSystemDataSetTableAdapters.Relatorio_AgendamentosTableAdapter relatorio_AgendamentosTableAdapter;
        private System.Windows.Forms.BindingSource relatorio_AgendamentosBindingSource;
    }
}