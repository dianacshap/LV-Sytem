
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCarros));
            this.marcaLabel = new System.Windows.Forms.Label();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.placaLabel = new System.Windows.Forms.Label();
            this.corLabel = new System.Windows.Forms.Label();
            this.observacoesLabel = new System.Windows.Forms.Label();
            this.anoLabel = new System.Windows.Forms.Label();
            this.clienteIdLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.CarrosTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ClientesTableAdapter();
            this.carrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingNavigator)).BeginInit();
            this.carrosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marcaLabel.Location = new System.Drawing.Point(79, 86);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(73, 25);
            this.marcaLabel.TabIndex = 2;
            this.marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeloLabel.Location = new System.Drawing.Point(79, 122);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(83, 25);
            this.modeloLabel.TabIndex = 4;
            this.modeloLabel.Text = "Modelo:";
            // 
            // placaLabel
            // 
            this.placaLabel.AutoSize = true;
            this.placaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.placaLabel.Location = new System.Drawing.Point(79, 158);
            this.placaLabel.Name = "placaLabel";
            this.placaLabel.Size = new System.Drawing.Size(67, 25);
            this.placaLabel.TabIndex = 6;
            this.placaLabel.Text = "Placa:";
            // 
            // corLabel
            // 
            this.corLabel.AutoSize = true;
            this.corLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.corLabel.Location = new System.Drawing.Point(79, 194);
            this.corLabel.Name = "corLabel";
            this.corLabel.Size = new System.Drawing.Size(50, 25);
            this.corLabel.TabIndex = 8;
            this.corLabel.Text = "Cor:";
            // 
            // observacoesLabel
            // 
            this.observacoesLabel.AutoSize = true;
            this.observacoesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.observacoesLabel.Location = new System.Drawing.Point(79, 230);
            this.observacoesLabel.Name = "observacoesLabel";
            this.observacoesLabel.Size = new System.Drawing.Size(135, 25);
            this.observacoesLabel.TabIndex = 10;
            this.observacoesLabel.Text = "Observacoes:";
            // 
            // anoLabel
            // 
            this.anoLabel.AutoSize = true;
            this.anoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anoLabel.Location = new System.Drawing.Point(79, 266);
            this.anoLabel.Name = "anoLabel";
            this.anoLabel.Size = new System.Drawing.Size(54, 25);
            this.anoLabel.TabIndex = 12;
            this.anoLabel.Text = "Ano:";
            // 
            // clienteIdLabel
            // 
            this.clienteIdLabel.AutoSize = true;
            this.clienteIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clienteIdLabel.Location = new System.Drawing.Point(79, 302);
            this.clienteIdLabel.Name = "clienteIdLabel";
            this.clienteIdLabel.Size = new System.Drawing.Size(100, 25);
            this.clienteIdLabel.TabIndex = 14;
            this.clienteIdLabel.Text = "Cliente Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnMoveFirst);
            this.groupBox1.Controls.Add(this.marcaLabel);
            this.groupBox1.Controls.Add(this.marcaTextBox);
            this.groupBox1.Controls.Add(this.modeloLabel);
            this.groupBox1.Controls.Add(this.modeloTextBox);
            this.groupBox1.Controls.Add(this.placaLabel);
            this.groupBox1.Controls.Add(this.placaTextBox);
            this.groupBox1.Controls.Add(this.corLabel);
            this.groupBox1.Controls.Add(this.corTextBox);
            this.groupBox1.Controls.Add(this.observacoesLabel);
            this.groupBox1.Controls.Add(this.observacoesTextBox);
            this.groupBox1.Controls.Add(this.anoLabel);
            this.groupBox1.Controls.Add(this.anoTextBox);
            this.groupBox1.Controls.Add(this.clienteIdLabel);
            this.groupBox1.Controls.Add(this.clienteIdComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Image = global::aDefinir.Properties.Resources.Cancelar;
            this.button5.Location = new System.Drawing.Point(311, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 40);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::aDefinir.Properties.Resources.mais3;
            this.button4.Location = new System.Drawing.Point(269, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 40);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::aDefinir.Properties.Resources.MoveLast1;
            this.button3.Location = new System.Drawing.Point(227, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 40);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::aDefinir.Properties.Resources.MoveNext1;
            this.button2.Location = new System.Drawing.Point(185, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 40);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(125, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 23);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "De {0}";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 40);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Image = global::aDefinir.Properties.Resources.MovePreview2;
            this.button1.Location = new System.Drawing.Point(49, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 40);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Image = global::aDefinir.Properties.Resources.Movefirst5;
            this.btnMoveFirst.Location = new System.Drawing.Point(6, 9);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(43, 40);
            this.btnMoveFirst.TabIndex = 3;
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
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
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carrosBindingSource, "ClienteId", true));
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
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = this.carrosTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ProdutoServicoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // carrosBindingNavigator
            // 
            this.carrosBindingNavigator.AddNewItem = null;
            this.carrosBindingNavigator.BindingSource = this.carrosBindingSource;
            this.carrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carrosBindingNavigator.DeleteItem = null;
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
            this.clientesBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.carrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carrosBindingNavigator.Name = "carrosBindingNavigator";
            this.carrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carrosBindingNavigator.Size = new System.Drawing.Size(741, 39);
            this.carrosBindingNavigator.TabIndex = 2;
            this.carrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.clientesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // button6
            // 
            this.button6.Image = global::aDefinir.Properties.Resources.Cancelar;
            this.button6.Location = new System.Drawing.Point(353, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 40);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // CadCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(741, 412);
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
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingNavigator)).EndInit();
            this.carrosBindingNavigator.ResumeLayout(false);
            this.carrosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private LvSystemDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private LvSystemDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.Label placaLabel;
        private System.Windows.Forms.Label corLabel;
        private System.Windows.Forms.Label observacoesLabel;
        private System.Windows.Forms.Label anoLabel;
        private System.Windows.Forms.Label clienteIdLabel;
        private System.Windows.Forms.BindingNavigator carrosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton clientesBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}