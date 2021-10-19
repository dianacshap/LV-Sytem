
namespace aDefinir
{
    partial class CadProdutos
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
            System.Windows.Forms.Label funcaoLabel;
            System.Windows.Forms.Label custoLabel;
            System.Windows.Forms.Label volumeLabel;
            System.Windows.Forms.Label rendimentoDiluidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.funcaoTextBox = new System.Windows.Forms.TextBox();
            this.custoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.rendimentoDiluidoTextBox = new System.Windows.Forms.TextBox();
            this.produtoTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnLocalizar = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            funcaoLabel = new System.Windows.Forms.Label();
            custoLabel = new System.Windows.Forms.Label();
            volumeLabel = new System.Windows.Forms.Label();
            rendimentoDiluidoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(73, 46);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(71, 24);
            idLabel.TabIndex = 0;
            idLabel.Text = "Código";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(73, 100);
            nomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 24);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // funcaoLabel
            // 
            funcaoLabel.AutoSize = true;
            funcaoLabel.Location = new System.Drawing.Point(73, 159);
            funcaoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            funcaoLabel.Name = "funcaoLabel";
            funcaoLabel.Size = new System.Drawing.Size(80, 24);
            funcaoLabel.TabIndex = 4;
            funcaoLabel.Text = "Funcao:";
            // 
            // custoLabel
            // 
            custoLabel.AutoSize = true;
            custoLabel.Location = new System.Drawing.Point(73, 218);
            custoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            custoLabel.Name = "custoLabel";
            custoLabel.Size = new System.Drawing.Size(63, 24);
            custoLabel.TabIndex = 6;
            custoLabel.Text = "Custo:";
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Location = new System.Drawing.Point(73, 277);
            volumeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new System.Drawing.Size(81, 24);
            volumeLabel.TabIndex = 8;
            volumeLabel.Text = "Volume:";
            // 
            // rendimentoDiluidoLabel
            // 
            rendimentoDiluidoLabel.AutoSize = true;
            rendimentoDiluidoLabel.Location = new System.Drawing.Point(73, 336);
            rendimentoDiluidoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            rendimentoDiluidoLabel.Name = "rendimentoDiluidoLabel";
            rendimentoDiluidoLabel.Size = new System.Drawing.Size(181, 24);
            rendimentoDiluidoLabel.TabIndex = 10;
            rendimentoDiluidoLabel.Text = "Rendimento Diluido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(funcaoLabel);
            this.groupBox1.Controls.Add(this.funcaoTextBox);
            this.groupBox1.Controls.Add(custoLabel);
            this.groupBox1.Controls.Add(this.custoMaskedTextBox);
            this.groupBox1.Controls.Add(volumeLabel);
            this.groupBox1.Controls.Add(this.volumeTextBox);
            this.groupBox1.Controls.Add(rendimentoDiluidoLabel);
            this.groupBox1.Controls.Add(this.rendimentoDiluidoTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(22, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1360, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // idLabel1
            // 
            this.idLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(363, 46);
            this.idLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(64, 42);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label1";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(363, 94);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(807, 29);
            this.nomeTextBox.TabIndex = 3;
            // 
            // funcaoTextBox
            // 
            this.funcaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Funcao", true));
            this.funcaoTextBox.Location = new System.Drawing.Point(363, 153);
            this.funcaoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.funcaoTextBox.Name = "funcaoTextBox";
            this.funcaoTextBox.Size = new System.Drawing.Size(807, 29);
            this.funcaoTextBox.TabIndex = 5;
            // 
            // custoMaskedTextBox
            // 
            this.custoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Custo", true));
            this.custoMaskedTextBox.Location = new System.Drawing.Point(363, 212);
            this.custoMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.custoMaskedTextBox.Name = "custoMaskedTextBox";
            this.custoMaskedTextBox.Size = new System.Drawing.Size(807, 29);
            this.custoMaskedTextBox.TabIndex = 7;
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Volume", true));
            this.volumeTextBox.Location = new System.Drawing.Point(363, 271);
            this.volumeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(807, 29);
            this.volumeTextBox.TabIndex = 9;
            // 
            // rendimentoDiluidoTextBox
            // 
            this.rendimentoDiluidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "RendimentoDiluido", true));
            this.rendimentoDiluidoTextBox.Location = new System.Drawing.Point(363, 330);
            this.rendimentoDiluidoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.rendimentoDiluidoTextBox.Name = "rendimentoDiluidoTextBox";
            this.rendimentoDiluidoTextBox.Size = new System.Drawing.Size(807, 29);
            this.rendimentoDiluidoTextBox.TabIndex = 11;
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
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = null;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = null;
            this.produtoBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.produtoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnEditar,
            this.btnLocalizar,
            this.btnRelatorio});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(1425, 32);
            this.produtoBindingNavigator.TabIndex = 13;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(60, 29);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(117, 29);
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
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
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(87, 29);
            this.clientesBindingNavigatorSaveItem.Text = "Salvar";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click);
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
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 29);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(111, 29);
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(111, 29);
            this.btnRelatorio.Text = "Relatório";
            // 
            // CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1425, 801);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CadProdutos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private LvSystemDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox funcaoTextBox;
        private System.Windows.Forms.MaskedTextBox custoMaskedTextBox;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox rendimentoDiluidoTextBox;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton btnLocalizar;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
    }
}