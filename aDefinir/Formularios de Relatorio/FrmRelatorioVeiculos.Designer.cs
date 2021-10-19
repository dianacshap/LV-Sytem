
namespace aDefinir
{
    partial class FrmRelatorioVeiculos
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioCarros4 = new aDefinir.RelatorioCarros();
            this.view_Rel_Carros_ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Rel_Carros_ClientesTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.View_Rel_Carros_ClientesTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Rel_Carros_ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RelatorioCarros4;
            this.crystalReportViewer1.Size = new System.Drawing.Size(899, 524);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // view_Rel_Carros_ClientesBindingSource
            // 
            this.view_Rel_Carros_ClientesBindingSource.DataMember = "View_Rel_Carros_Clientes";
            this.view_Rel_Carros_ClientesBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // view_Rel_Carros_ClientesTableAdapter
            // 
            this.view_Rel_Carros_ClientesTableAdapter.ClearBeforeFill = true;
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
            // FrmRelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 524);
            this.Controls.Add(this.crystalReportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Veículos";
            this.Load += new System.EventHandler(this.FrmRelatorioVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Rel_Carros_ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LvSystemDataSet lvSystemDataSet;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RelatorioCarros RelatorioCarros4;
        private System.Windows.Forms.BindingSource view_Rel_Carros_ClientesBindingSource;
        private LvSystemDataSetTableAdapters.View_Rel_Carros_ClientesTableAdapter view_Rel_Carros_ClientesTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}