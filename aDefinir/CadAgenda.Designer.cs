
namespace aDefinir
{
    partial class CadAgenda
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
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label carro_IdLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label dataAgLabel;
            System.Windows.Forms.Label horaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAgenda));
            this.servicos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.horaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.dataAgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codigoLabel1 = new System.Windows.Forms.Label();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.carro_IdComboBox = new System.Windows.Forms.ComboBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.carrosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.CarrosTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.agendamentoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.AgendamentoTableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.agendamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agendamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.servicoAgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoAgendamentoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ServicoAgendamentoTableAdapter();
            this.view_ServicoAgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ServicoAgendamentoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.View_ServicoAgendamentoTableAdapter();
            this.view_ServicoAgendamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalLabel = new System.Windows.Forms.Label();
            carro_IdLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            dataAgLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            this.servicos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).BeginInit();
            this.agendamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoAgendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicoAgendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicoAgendamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(657, 37);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(62, 25);
            totalLabel.TabIndex = 10;
            totalLabel.Text = "Total:";
            // 
            // carro_IdLabel
            // 
            carro_IdLabel.AutoSize = true;
            carro_IdLabel.Location = new System.Drawing.Point(18, 106);
            carro_IdLabel.Name = "carro_IdLabel";
            carro_IdLabel.Size = new System.Drawing.Size(88, 25);
            carro_IdLabel.TabIndex = 8;
            carro_IdLabel.Text = "Carro Id:";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(387, 37);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(95, 25);
            situacaoLabel.TabIndex = 6;
            situacaoLabel.Text = "Situacao:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(18, 37);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(81, 25);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo:";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(105, 37);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(89, 25);
            dataAgLabel.TabIndex = 13;
            dataAgLabel.Text = "Data Ag:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(268, 37);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(60, 25);
            horaLabel.TabIndex = 14;
            horaLabel.Text = "Hora:";
            // 
            // servicos
            // 
            this.servicos.Controls.Add(this.view_ServicoAgendamentoDataGridView);
            this.servicos.Location = new System.Drawing.Point(13, 231);
            this.servicos.Name = "servicos";
            this.servicos.Size = new System.Drawing.Size(791, 288);
            this.servicos.TabIndex = 2;
            this.servicos.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Controls.Add(this.horaMaskedTextBox);
            this.groupBox1.Controls.Add(dataAgLabel);
            this.groupBox1.Controls.Add(this.dataAgMaskedTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.codigoLabel1);
            this.groupBox1.Controls.Add(situacaoLabel);
            this.groupBox1.Controls.Add(this.situacaoComboBox);
            this.groupBox1.Controls.Add(carro_IdLabel);
            this.groupBox1.Controls.Add(this.carro_IdComboBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
            // 
            // horaMaskedTextBox
            // 
            this.horaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Hora", true));
            this.horaMaskedTextBox.Location = new System.Drawing.Point(264, 65);
            this.horaMaskedTextBox.Mask = "00:00";
            this.horaMaskedTextBox.Name = "horaMaskedTextBox";
            this.horaMaskedTextBox.Size = new System.Drawing.Size(74, 30);
            this.horaMaskedTextBox.TabIndex = 15;
            this.horaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "Agendamento";
            this.agendamentoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAgMaskedTextBox
            // 
            this.dataAgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgMaskedTextBox.Location = new System.Drawing.Point(110, 65);
            this.dataAgMaskedTextBox.Mask = "00/00/0000";
            this.dataAgMaskedTextBox.Name = "dataAgMaskedTextBox";
            this.dataAgMaskedTextBox.Size = new System.Drawing.Size(110, 30);
            this.dataAgMaskedTextBox.TabIndex = 14;
            this.dataAgMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // codigoLabel1
            // 
            this.codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Codigo", true));
            this.codigoLabel1.Location = new System.Drawing.Point(29, 62);
            this.codigoLabel1.Name = "codigoLabel1";
            this.codigoLabel1.Size = new System.Drawing.Size(52, 23);
            this.codigoLabel1.TabIndex = 1;
            this.codigoLabel1.Text = "label1";
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Situacao", true));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Agendado",
            "Em Andamento",
            "Finalizado"});
            this.situacaoComboBox.Location = new System.Drawing.Point(374, 65);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(229, 33);
            this.situacaoComboBox.TabIndex = 7;
            // 
            // carro_IdComboBox
            // 
            this.carro_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "Carro_Id", true));
            this.carro_IdComboBox.DataSource = this.carrosBindingSource;
            this.carro_IdComboBox.DisplayMember = "Modelo";
            this.carro_IdComboBox.FormattingEnabled = true;
            this.carro_IdComboBox.Location = new System.Drawing.Point(16, 134);
            this.carro_IdComboBox.Name = "carro_IdComboBox";
            this.carro_IdComboBox.Size = new System.Drawing.Size(400, 33);
            this.carro_IdComboBox.TabIndex = 9;
            this.carro_IdComboBox.ValueMember = "Id";
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(634, 64);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(121, 30);
            this.totalTextBox.TabIndex = 11;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ProdutoServicoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoAgendamentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // agendamentoBindingNavigatorSaveItem
            // 
            this.agendamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendamentoBindingNavigatorSaveItem.Image")));
            this.agendamentoBindingNavigatorSaveItem.Name = "agendamentoBindingNavigatorSaveItem";
            this.agendamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agendamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.agendamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendamentoBindingNavigatorSaveItem_Click);
            // 
            // agendamentoBindingNavigator
            // 
            this.agendamentoBindingNavigator.AddNewItem = null;
            this.agendamentoBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.agendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendamentoBindingNavigator.DeleteItem = null;
            this.agendamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.agendamentoBindingNavigatorSaveItem,
            this.btnEditar,
            this.btnCancelar});
            this.agendamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendamentoBindingNavigator.Name = "agendamentoBindingNavigator";
            this.agendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendamentoBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.agendamentoBindingNavigator.TabIndex = 3;
            this.agendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // servicoAgendamentoBindingSource
            // 
            this.servicoAgendamentoBindingSource.DataMember = "ServicoAgendamento";
            this.servicoAgendamentoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // servicoAgendamentoTableAdapter
            // 
            this.servicoAgendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // view_ServicoAgendamentoBindingSource
            // 
            this.view_ServicoAgendamentoBindingSource.DataMember = "View_ServicoAgendamento";
            this.view_ServicoAgendamentoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // view_ServicoAgendamentoTableAdapter
            // 
            this.view_ServicoAgendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // view_ServicoAgendamentoDataGridView
            // 
            this.view_ServicoAgendamentoDataGridView.AllowUserToAddRows = false;
            this.view_ServicoAgendamentoDataGridView.AllowUserToDeleteRows = false;
            this.view_ServicoAgendamentoDataGridView.AutoGenerateColumns = false;
            this.view_ServicoAgendamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ServicoAgendamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.view_ServicoAgendamentoDataGridView.DataSource = this.view_ServicoAgendamentoBindingSource;
            this.view_ServicoAgendamentoDataGridView.Location = new System.Drawing.Point(15, 19);
            this.view_ServicoAgendamentoDataGridView.Name = "view_ServicoAgendamentoDataGridView";
            this.view_ServicoAgendamentoDataGridView.ReadOnly = true;
            this.view_ServicoAgendamentoDataGridView.Size = new System.Drawing.Size(757, 220);
            this.view_ServicoAgendamentoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Servico_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Servico_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Agendamento_Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Agendamento_Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn3.HeaderText = "Servico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TempoServico";
            this.dataGridViewTextBoxColumn5.HeaderText = "TempoServico";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ValorUnitario";
            this.dataGridViewTextBoxColumn7.HeaderText = "ValorUnitario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn8.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // CadAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 865);
            this.Controls.Add(this.agendamentoBindingNavigator);
            this.Controls.Add(this.servicos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadAgenda";
            this.Text = "CadAgenda";
            this.Load += new System.EventHandler(this.CadAgenda_Load);
            this.servicos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).EndInit();
            this.agendamentoBindingNavigator.ResumeLayout(false);
            this.agendamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoAgendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicoAgendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicoAgendamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox servicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.Label codigoLabel1;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.ComboBox carro_IdComboBox;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private System.Windows.Forms.TextBox totalTextBox;
        private LvSystemDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LvSystemDataSetTableAdapters.AgendamentoTableAdapter agendamentoTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton agendamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator agendamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.MaskedTextBox horaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataAgMaskedTextBox;
        private System.Windows.Forms.BindingSource servicoAgendamentoBindingSource;
        private LvSystemDataSetTableAdapters.ServicoAgendamentoTableAdapter servicoAgendamentoTableAdapter;
        private System.Windows.Forms.BindingSource view_ServicoAgendamentoBindingSource;
        private LvSystemDataSetTableAdapters.View_ServicoAgendamentoTableAdapter view_ServicoAgendamentoTableAdapter;
        private System.Windows.Forms.DataGridView view_ServicoAgendamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}