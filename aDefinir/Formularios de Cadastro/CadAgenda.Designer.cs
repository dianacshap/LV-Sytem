
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.servicos = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodServ = new System.Windows.Forms.MaskedTextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Serviço = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnAddServ = new System.Windows.Forms.Button();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.view_Servico_AgendamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_Servico_AgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataAgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.carro_IdComboBox = new System.Windows.Forms.ComboBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.carrosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.CarrosTableAdapter();
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
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.agendamentosServicosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.AgendamentosServicosTableAdapter();
            this.servicoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ServicoTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.agendamentosServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Total_ServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Servico_AgendamentoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.View_Servico_AgendamentoTableAdapter();
            this.view_Total_ServicosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.View_Total_ServicosTableAdapter();
            totalLabel = new System.Windows.Forms.Label();
            carro_IdLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            dataAgLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            this.servicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_AgendamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_AgendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).BeginInit();
            this.agendamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentosServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Total_ServicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(1073, 68);
            totalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(56, 24);
            totalLabel.TabIndex = 10;
            totalLabel.Text = "Total:";
            // 
            // carro_IdLabel
            // 
            carro_IdLabel.AutoSize = true;
            carro_IdLabel.Location = new System.Drawing.Point(33, 198);
            carro_IdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            carro_IdLabel.Name = "carro_IdLabel";
            carro_IdLabel.Size = new System.Drawing.Size(74, 24);
            carro_IdLabel.TabIndex = 8;
            carro_IdLabel.Text = "Veículo";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(612, 68);
            situacaoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(87, 24);
            situacaoLabel.TabIndex = 6;
            situacaoLabel.Text = "Situação:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(33, 68);
            codigoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(76, 24);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Código:";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(193, 68);
            dataAgLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(47, 24);
            dataAgLabel.TabIndex = 13;
            dataAgLabel.Text = "Data";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(438, 68);
            horaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(56, 24);
            horaLabel.TabIndex = 14;
            horaLabel.Text = "Hora:";
            // 
            // servicos
            // 
            this.servicos.Controls.Add(this.btnPesquisar);
            this.servicos.Controls.Add(this.txtCodServ);
            this.servicos.Controls.Add(this.txtServico);
            this.servicos.Controls.Add(this.label4);
            this.servicos.Controls.Add(this.label3);
            this.servicos.Controls.Add(this.Serviço);
            this.servicos.Controls.Add(this.label1);
            this.servicos.Controls.Add(this.txtQtd);
            this.servicos.Controls.Add(this.btnAddServ);
            this.servicos.Controls.Add(this.txtValorUnit);
            this.servicos.Controls.Add(this.view_Servico_AgendamentoDataGridView);
            this.servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.servicos.Location = new System.Drawing.Point(24, 393);
            this.servicos.Margin = new System.Windows.Forms.Padding(6);
            this.servicos.Name = "servicos";
            this.servicos.Padding = new System.Windows.Forms.Padding(6);
            this.servicos.Size = new System.Drawing.Size(1293, 565);
            this.servicos.TabIndex = 2;
            this.servicos.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(134, 39);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(42, 42);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodServ
            // 
            this.txtCodServ.Location = new System.Drawing.Point(28, 46);
            this.txtCodServ.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodServ.Mask = "000";
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(99, 29);
            this.txtCodServ.TabIndex = 7;
            this.txtCodServ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCodServ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodServ_KeyDown);
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(242, 46);
            this.txtServico.Margin = new System.Windows.Forms.Padding(6);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(516, 29);
            this.txtServico.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(992, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade";
            // 
            // Serviço
            // 
            this.Serviço.AutoSize = true;
            this.Serviço.Location = new System.Drawing.Point(237, 17);
            this.Serviço.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Serviço.Name = "Serviço";
            this.Serviço.Size = new System.Drawing.Size(73, 24);
            this.Serviço.TabIndex = 7;
            this.Serviço.Text = "Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(794, 42);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(6);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(173, 29);
            this.txtQtd.TabIndex = 10;
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            // 
            // btnAddServ
            // 
            this.btnAddServ.Location = new System.Drawing.Point(1175, 39);
            this.btnAddServ.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddServ.Name = "btnAddServ";
            this.btnAddServ.Size = new System.Drawing.Size(42, 42);
            this.btnAddServ.TabIndex = 12;
            this.btnAddServ.Text = "+";
            this.btnAddServ.UseVisualStyleBackColor = true;
            this.btnAddServ.Click += new System.EventHandler(this.btnAddServ_Click);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Location = new System.Drawing.Point(981, 42);
            this.txtValorUnit.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(180, 29);
            this.txtValorUnit.TabIndex = 11;
            this.txtValorUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorUnit_KeyDown);
            // 
            // view_Servico_AgendamentoDataGridView
            // 
            this.view_Servico_AgendamentoDataGridView.AllowUserToAddRows = false;
            this.view_Servico_AgendamentoDataGridView.AllowUserToDeleteRows = false;
            this.view_Servico_AgendamentoDataGridView.AutoGenerateColumns = false;
            this.view_Servico_AgendamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Servico_AgendamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn4});
            this.view_Servico_AgendamentoDataGridView.DataSource = this.view_Servico_AgendamentoBindingSource;
            this.view_Servico_AgendamentoDataGridView.Location = new System.Drawing.Point(28, 114);
            this.view_Servico_AgendamentoDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.view_Servico_AgendamentoDataGridView.Name = "view_Servico_AgendamentoDataGridView";
            this.view_Servico_AgendamentoDataGridView.ReadOnly = true;
            this.view_Servico_AgendamentoDataGridView.Size = new System.Drawing.Size(1223, 367);
            this.view_Servico_AgendamentoDataGridView.TabIndex = 13;
            this.view_Servico_AgendamentoDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_Servico_AgendamentoDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Agendamentos_Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Agendamentos_Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Servicos_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Servicos_Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TempoServico";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 133;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 134;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // view_Servico_AgendamentoBindingSource
            // 
            this.view_Servico_AgendamentoBindingSource.DataMember = "View_Servico_Agendamento";
            this.view_Servico_AgendamentoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocalizar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Controls.Add(this.horaMaskedTextBox);
            this.groupBox1.Controls.Add(dataAgLabel);
            this.groupBox1.Controls.Add(this.dataAgMaskedTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(situacaoLabel);
            this.groupBox1.Controls.Add(this.situacaoComboBox);
            this.groupBox1.Controls.Add(carro_IdLabel);
            this.groupBox1.Controls.Add(this.carro_IdComboBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(22, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1294, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(774, 249);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(141, 32);
            this.btnLocalizar.TabIndex = 6;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Codigo", true));
            this.txtCodigo.Location = new System.Drawing.Point(42, 118);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(136, 29);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "Agendamento";
            this.agendamentoBindingSource.DataSource = this.lvSystemDataSet;
            this.agendamentoBindingSource.PositionChanged += new System.EventHandler(this.agendamentoBindingSource_PositionChanged);
            // 
            // horaMaskedTextBox
            // 
            this.horaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Hora", true));
            this.horaMaskedTextBox.Location = new System.Drawing.Point(431, 118);
            this.horaMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.horaMaskedTextBox.Mask = "00:00";
            this.horaMaskedTextBox.Name = "horaMaskedTextBox";
            this.horaMaskedTextBox.Size = new System.Drawing.Size(132, 29);
            this.horaMaskedTextBox.TabIndex = 2;
            this.horaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dataAgMaskedTextBox
            // 
            this.dataAgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgMaskedTextBox.Location = new System.Drawing.Point(202, 118);
            this.dataAgMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.dataAgMaskedTextBox.Mask = "00/00/0000";
            this.dataAgMaskedTextBox.Name = "dataAgMaskedTextBox";
            this.dataAgMaskedTextBox.Size = new System.Drawing.Size(198, 29);
            this.dataAgMaskedTextBox.TabIndex = 1;
            this.dataAgMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Situacao", true));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Agendado",
            "Em Andamento",
            "Finalizado"});
            this.situacaoComboBox.Location = new System.Drawing.Point(589, 113);
            this.situacaoComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(417, 32);
            this.situacaoComboBox.TabIndex = 3;
            // 
            // carro_IdComboBox
            // 
            this.carro_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "Carro_Id", true));
            this.carro_IdComboBox.DataSource = this.carrosBindingSource;
            this.carro_IdComboBox.DisplayMember = "Modelo";
            this.carro_IdComboBox.FormattingEnabled = true;
            this.carro_IdComboBox.Location = new System.Drawing.Point(29, 249);
            this.carro_IdComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.carro_IdComboBox.Name = "carro_IdComboBox";
            this.carro_IdComboBox.Size = new System.Drawing.Size(730, 32);
            this.carro_IdComboBox.TabIndex = 5;
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
            this.totalTextBox.Location = new System.Drawing.Point(1030, 118);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(219, 29);
            this.totalTextBox.TabIndex = 4;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(60, 29);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(72, 29);
            this.bindingNavigatorAddNewItem.Text = "Novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(92, 29);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // agendamentoBindingNavigatorSaveItem
            // 
            this.agendamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendamentoBindingNavigatorSaveItem.Image")));
            this.agendamentoBindingNavigatorSaveItem.Name = "agendamentoBindingNavigatorSaveItem";
            this.agendamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(87, 29);
            this.agendamentoBindingNavigatorSaveItem.Text = "Salvar";
            this.agendamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendamentoBindingNavigatorSaveItem_Click);
            // 
            // agendamentoBindingNavigator
            // 
            this.agendamentoBindingNavigator.AddNewItem = null;
            this.agendamentoBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.agendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendamentoBindingNavigator.DeleteItem = null;
            this.agendamentoBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.agendamentoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.btnCancelar,
            this.btnRelatorio,
            this.btnFinalizar});
            this.agendamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendamentoBindingNavigator.Name = "agendamentoBindingNavigator";
            this.agendamentoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.agendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendamentoBindingNavigator.Size = new System.Drawing.Size(1380, 32);
            this.agendamentoBindingNavigator.TabIndex = 3;
            this.agendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 29);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 29);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(111, 29);
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(87, 29);
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // agendamentosServicosTableAdapter
            // 
            this.agendamentosServicosTableAdapter.ClearBeforeFill = true;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ServicoProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendamentosServicosBindingSource
            // 
            this.agendamentosServicosBindingSource.DataMember = "AgendamentosServicos";
            this.agendamentosServicosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // view_Total_ServicosBindingSource
            // 
            this.view_Total_ServicosBindingSource.DataMember = "View_Total_Servicos";
            this.view_Total_ServicosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // view_Servico_AgendamentoTableAdapter
            // 
            this.view_Servico_AgendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // view_Total_ServicosTableAdapter
            // 
            this.view_Total_ServicosTableAdapter.ClearBeforeFill = true;
            // 
            // CadAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1397, 881);
            this.Controls.Add(this.agendamentoBindingNavigator);
            this.Controls.Add(this.servicos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CadAgenda";
            this.Text = "CadAgenda";
            this.Load += new System.EventHandler(this.CadAgenda_Load);
            this.servicos.ResumeLayout(false);
            this.servicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_AgendamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_AgendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).EndInit();
            this.agendamentoBindingNavigator.ResumeLayout(false);
            this.agendamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentosServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Total_ServicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox servicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private LvSystemDataSet lvSystemDataSet;
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
        private System.Windows.Forms.BindingSource agendamentosServicosBindingSource;
        private LvSystemDataSetTableAdapters.AgendamentosServicosTableAdapter agendamentosServicosTableAdapter;
        private System.Windows.Forms.BindingSource view_Servico_AgendamentoBindingSource;
        private LvSystemDataSetTableAdapters.View_Servico_AgendamentoTableAdapter view_Servico_AgendamentoTableAdapter;
        private System.Windows.Forms.DataGridView view_Servico_AgendamentoDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Serviço;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnAddServ;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private LvSystemDataSetTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.MaskedTextBox txtCodServ;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ToolStripButton btnFinalizar;
        private System.Windows.Forms.BindingSource view_Total_ServicosBindingSource;
        private LvSystemDataSetTableAdapters.View_Total_ServicosTableAdapter view_Total_ServicosTableAdapter;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
    }
}