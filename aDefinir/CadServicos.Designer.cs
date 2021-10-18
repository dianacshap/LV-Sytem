
namespace aDefinir
{
    partial class CadServicos
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label tempoServicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadServicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.servicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.tempoServicoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.view_Servico_ProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLocalizaProduto = new System.Windows.Forms.Button();
            this.txtQuantidadeUtilizada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.servicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnLocalizar = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.view_Servico_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ServicoTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.servicoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoProdutoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ServicoProdutoTableAdapter();
            this.view_Servico_ProdutoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.View_Servico_ProdutoTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ProdutoTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            tempoServicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).BeginInit();
            this.servicoBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_ProdutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(93, 12);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(93, 44);
            nomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(93, 77);
            valorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(50, 20);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
            // 
            // tempoServicoLabel
            // 
            tempoServicoLabel.AutoSize = true;
            tempoServicoLabel.Location = new System.Drawing.Point(93, 110);
            tempoServicoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tempoServicoLabel.Name = "tempoServicoLabel";
            tempoServicoLabel.Size = new System.Drawing.Size(140, 20);
            tempoServicoLabel.TabIndex = 15;
            tempoServicoLabel.Text = "Tempo de Serviço:";
            // 
            // servicoBindingNavigator
            // 
            this.servicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicoBindingNavigator.BindingSource = this.servicoBindingSource;
            this.servicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.servicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicoBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar,
            this.btnLocalizar,
            this.btnRelatorio});
            this.servicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicoBindingNavigator.Name = "servicoBindingNavigator";
            this.servicoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.servicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicoBindingNavigator.Size = new System.Drawing.Size(766, 27);
            this.servicoBindingNavigator.TabIndex = 0;
            this.servicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(tempoServicoLabel);
            this.groupBox1.Controls.Add(this.tempoServicoTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(738, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(254, 6);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(180, 26);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(254, 38);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(180, 26);
            this.nomeTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(254, 71);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(180, 26);
            this.valorTextBox.TabIndex = 2;
            // 
            // tempoServicoTextBox
            // 
            this.tempoServicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "TempoServico", true));
            this.tempoServicoTextBox.Location = new System.Drawing.Point(254, 104);
            this.tempoServicoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.tempoServicoTextBox.Name = "tempoServicoTextBox";
            this.tempoServicoTextBox.Size = new System.Drawing.Size(180, 26);
            this.tempoServicoTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.view_Servico_ProdutoDataGridView);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.btnLocalizaProduto);
            this.groupBox2.Controls.Add(this.txtQuantidadeUtilizada);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(15, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 355);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCodigo.Location = new System.Drawing.Point(14, 45);
            this.txtCodigo.Mask = "000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 26);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // view_Servico_ProdutoDataGridView
            // 
            this.view_Servico_ProdutoDataGridView.AllowUserToAddRows = false;
            this.view_Servico_ProdutoDataGridView.AllowUserToDeleteRows = false;
            this.view_Servico_ProdutoDataGridView.AutoGenerateColumns = false;
            this.view_Servico_ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Servico_ProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_Servico_ProdutoDataGridView.DataSource = this.view_Servico_ProdutoBindingSource;
            this.view_Servico_ProdutoDataGridView.Location = new System.Drawing.Point(6, 77);
            this.view_Servico_ProdutoDataGridView.Name = "view_Servico_ProdutoDataGridView";
            this.view_Servico_ProdutoDataGridView.ReadOnly = true;
            this.view_Servico_ProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_Servico_ProdutoDataGridView.Size = new System.Drawing.Size(728, 252);
            this.view_Servico_ProdutoDataGridView.TabIndex = 8;
            this.view_Servico_ProdutoDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_Servico_ProdutoDataGridView_CellContentDoubleClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(631, 45);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(41, 26);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLocalizaProduto
            // 
            this.btnLocalizaProduto.Location = new System.Drawing.Point(82, 45);
            this.btnLocalizaProduto.Name = "btnLocalizaProduto";
            this.btnLocalizaProduto.Size = new System.Drawing.Size(41, 26);
            this.btnLocalizaProduto.TabIndex = 5;
            this.btnLocalizaProduto.Text = "button1";
            this.btnLocalizaProduto.UseVisualStyleBackColor = true;
            this.btnLocalizaProduto.Click += new System.EventHandler(this.btnLocalizaProduto_Click);
            // 
            // txtQuantidadeUtilizada
            // 
            this.txtQuantidadeUtilizada.Location = new System.Drawing.Point(472, 45);
            this.txtQuantidadeUtilizada.Name = "txtQuantidadeUtilizada";
            this.txtQuantidadeUtilizada.Size = new System.Drawing.Size(149, 26);
            this.txtQuantidadeUtilizada.TabIndex = 7;
            this.txtQuantidadeUtilizada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidadeUtilizada_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade (L)";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(129, 45);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(321, 26);
            this.txtProduto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // servicoBindingNavigatorSaveItem
            // 
            this.servicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicoBindingNavigatorSaveItem.Image")));
            this.servicoBindingNavigatorSaveItem.Name = "servicoBindingNavigatorSaveItem";
            this.servicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.servicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.servicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicoBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 24);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 24);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(77, 24);
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(78, 24);
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // view_Servico_ProdutoBindingSource
            // 
            this.view_Servico_ProdutoBindingSource.DataMember = "View_Servico_Produto";
            this.view_Servico_ProdutoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.lvSystemDataSet;
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
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicoProdutoBindingSource
            // 
            this.servicoProdutoBindingSource.DataMember = "ServicoProduto";
            this.servicoProdutoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // servicoProdutoTableAdapter
            // 
            this.servicoProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // view_Servico_ProdutoTableAdapter
            // 
            this.view_Servico_ProdutoTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Funcao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Funcao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Consumo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Consumo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Custo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Custo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 76;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RendimentoDiluido";
            this.dataGridViewTextBoxColumn6.HeaderText = "RendimentoDiluido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 169;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CustoTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "Custo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 76;
            // 
            // CadServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.servicoBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CadServicos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CadServicos";
            this.Load += new System.EventHandler(this.CadServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).EndInit();
            this.servicoBindingNavigator.ResumeLayout(false);
            this.servicoBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_ProdutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Servico_ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private LvSystemDataSetTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox tempoServicoTextBox;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.ToolStripButton btnLocalizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeUtilizada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLocalizaProduto;
        private System.Windows.Forms.BindingSource servicoProdutoBindingSource;
        private LvSystemDataSetTableAdapters.ServicoProdutoTableAdapter servicoProdutoTableAdapter;
        private System.Windows.Forms.BindingSource view_Servico_ProdutoBindingSource;
        private LvSystemDataSetTableAdapters.View_Servico_ProdutoTableAdapter view_Servico_ProdutoTableAdapter;
        private System.Windows.Forms.DataGridView view_Servico_ProdutoDataGridView;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private LvSystemDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}