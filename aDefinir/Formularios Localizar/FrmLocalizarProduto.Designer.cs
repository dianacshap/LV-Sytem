
namespace aDefinir
{
    partial class FrmLocalizarProduto
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
            this.txtNome = new System.Windows.Forms.Label();
            this.txtNomeLocalizar = new System.Windows.Forms.TextBox();
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(25, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(65, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.Text = "Produto";
            // 
            // txtNomeLocalizar
            // 
            this.txtNomeLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeLocalizar.Location = new System.Drawing.Point(11, 32);
            this.txtNomeLocalizar.Name = "txtNomeLocalizar";
            this.txtNomeLocalizar.Size = new System.Drawing.Size(438, 26);
            this.txtNomeLocalizar.TabIndex = 5;
            this.txtNomeLocalizar.TextChanged += new System.EventHandler(this.txtNomeLocalizar_TextChanged);
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.AgendamentosServicosTableAdapter = null;
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.ServicoProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AllowUserToAddRows = false;
            this.produtoDataGridView.AllowUserToDeleteRows = false;
            this.produtoDataGridView.AllowUserToOrderColumns = true;
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(12, 64);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.ReadOnly = true;
            this.produtoDataGridView.Size = new System.Drawing.Size(705, 204);
            this.produtoDataGridView.TabIndex = 6;
            this.produtoDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtoDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Funcao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Funcao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Custo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Custo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Volume";
            this.dataGridViewTextBoxColumn5.HeaderText = "Volume";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RendimentoDiluido";
            this.dataGridViewTextBoxColumn6.HeaderText = "RendimentoDiluido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dê dois cliques sobre o registro desejado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(585, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmLocalizarProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(755, 328);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNomeLocalizar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocalizarProduto";
            this.Text = "Localizar Produtos";
            this.Load += new System.EventHandler(this.FrmLocalizarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox txtNomeLocalizar;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private LvSystemDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}