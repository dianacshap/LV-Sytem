
namespace aDefinir
{
    partial class CadCarros
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label placaLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCarros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.CarrosTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ClientesTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            placaLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingNavigator)).BeginInit();
            this.carrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            idLabel.Location = new System.Drawing.Point(79, 55);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            marcaLabel.Location = new System.Drawing.Point(79, 86);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(73, 25);
            marcaLabel.TabIndex = 2;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            modeloLabel.Location = new System.Drawing.Point(79, 122);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(83, 25);
            modeloLabel.TabIndex = 4;
            modeloLabel.Text = "Modelo:";
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            placaLabel.Location = new System.Drawing.Point(79, 158);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(67, 25);
            placaLabel.TabIndex = 6;
            placaLabel.Text = "Placa:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            corLabel.Location = new System.Drawing.Point(79, 194);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(50, 25);
            corLabel.TabIndex = 8;
            corLabel.Text = "Cor:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            observacoesLabel.Location = new System.Drawing.Point(79, 230);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(135, 25);
            observacoesLabel.TabIndex = 10;
            observacoesLabel.Text = "Observacoes:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            anoLabel.Location = new System.Drawing.Point(79, 266);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(54, 25);
            anoLabel.TabIndex = 12;
            anoLabel.Text = "Ano:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            clienteIdLabel.Location = new System.Drawing.Point(79, 302);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(100, 25);
            clienteIdLabel.TabIndex = 14;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(marcaLabel);
            this.groupBox1.Controls.Add(this.marcaTextBox);
            this.groupBox1.Controls.Add(modeloLabel);
            this.groupBox1.Controls.Add(this.modeloTextBox);
            this.groupBox1.Controls.Add(placaLabel);
            this.groupBox1.Controls.Add(this.placaTextBox);
            this.groupBox1.Controls.Add(corLabel);
            this.groupBox1.Controls.Add(this.corTextBox);
            this.groupBox1.Controls.Add(observacoesLabel);
            this.groupBox1.Controls.Add(this.observacoesTextBox);
            this.groupBox1.Controls.Add(anoLabel);
            this.groupBox1.Controls.Add(this.anoTextBox);
            this.groupBox1.Controls.Add(clienteIdLabel);
            this.groupBox1.Controls.Add(this.clienteIdComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Veículo";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Id", true));
            this.idLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idLabel1.Location = new System.Drawing.Point(220, 55);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(121, 23);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label1";
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Marca", true));
            this.marcaTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marcaTextBox.Location = new System.Drawing.Point(220, 83);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(121, 30);
            this.marcaTextBox.TabIndex = 3;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Modelo", true));
            this.modeloTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeloTextBox.Location = new System.Drawing.Point(220, 119);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(121, 30);
            this.modeloTextBox.TabIndex = 5;
            // 
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Placa", true));
            this.placaTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.placaTextBox.Location = new System.Drawing.Point(220, 155);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(121, 30);
            this.placaTextBox.TabIndex = 7;
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Cor", true));
            this.corTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.corTextBox.Location = new System.Drawing.Point(220, 191);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(121, 30);
            this.corTextBox.TabIndex = 9;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Observacoes", true));
            this.observacoesTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.observacoesTextBox.Location = new System.Drawing.Point(220, 227);
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(121, 30);
            this.observacoesTextBox.TabIndex = 11;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Ano", true));
            this.anoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anoTextBox.Location = new System.Drawing.Point(220, 263);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(121, 30);
            this.anoTextBox.TabIndex = 13;
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "ClienteId", true));
            this.clienteIdComboBox.DataSource = this.clientesBindingSource1;
            this.clienteIdComboBox.DisplayMember = "Nome";
            this.clienteIdComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(220, 299);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(121, 33);
            this.clienteIdComboBox.TabIndex = 15;
            this.clienteIdComboBox.ValueMember = "Id";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.lvSystemDataSet;
            // 
            // carrosBindingNavigator
            // 
            this.carrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carrosBindingNavigator.BindingSource = this.carrosBindingSource;
            this.carrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carrosBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.carrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carrosBindingNavigatorSaveItem,
            this.btnEditar,
            this.btnCancelar});
            this.carrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carrosBindingNavigator.Name = "carrosBindingNavigator";
            this.carrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carrosBindingNavigator.Size = new System.Drawing.Size(777, 39);
            this.carrosBindingNavigator.TabIndex = 1;
            this.carrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // carrosBindingNavigatorSaveItem
            // 
            this.carrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carrosBindingNavigatorSaveItem.Image")));
            this.carrosBindingNavigatorSaveItem.Name = "carrosBindingNavigatorSaveItem";
            this.carrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.carrosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.carrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.carrosBindingNavigatorSaveItem_Click_3);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = this.carrosTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // CadCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(777, 434);
            this.Controls.Add(this.carrosBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadCarros";
            this.Text = "CadCarros";
            this.Load += new System.EventHandler(this.CadCarros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingNavigator)).EndInit();
            this.carrosBindingNavigator.ResumeLayout(false);
            this.carrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private LvSystemDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carrosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carrosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private LvSystemDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
    }
}