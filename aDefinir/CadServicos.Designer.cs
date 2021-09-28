
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadServicos));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label tempoServicoLabel;
            System.Windows.Forms.Label produtoIdLabel;
            System.Windows.Forms.Label carroIdLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.ServicosTableAdapter();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.servicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.servicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.tempoServicoTextBox = new System.Windows.Forms.TextBox();
            this.produtoIdTextBox = new System.Windows.Forms.TextBox();
            this.carroIdTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            tempoServicoLabel = new System.Windows.Forms.Label();
            produtoIdLabel = new System.Windows.Forms.Label();
            carroIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingNavigator)).BeginInit();
            this.servicosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(tempoServicoLabel);
            this.groupBox1.Controls.Add(this.tempoServicoTextBox);
            this.groupBox1.Controls.Add(produtoIdLabel);
            this.groupBox1.Controls.Add(this.produtoIdTextBox);
            this.groupBox1.Controls.Add(carroIdLabel);
            this.groupBox1.Controls.Add(this.carroIdTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lvSystemDataSet
            // 
            this.lvSystemDataSet.DataSetName = "LvSystemDataSet";
            this.lvSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "Servicos";
            this.servicosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicosTableAdapter = this.servicosTableAdapter;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicosBindingNavigator
            // 
            this.servicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicosBindingNavigator.BindingSource = this.servicosBindingSource;
            this.servicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicosBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.servicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicosBindingNavigatorSaveItem});
            this.servicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicosBindingNavigator.Name = "servicosBindingNavigator";
            this.servicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicosBindingNavigator.Size = new System.Drawing.Size(721, 39);
            this.servicosBindingNavigator.TabIndex = 1;
            this.servicosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // servicosBindingNavigatorSaveItem
            // 
            this.servicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicosBindingNavigatorSaveItem.Image")));
            this.servicosBindingNavigatorSaveItem.Name = "servicosBindingNavigatorSaveItem";
            this.servicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.servicosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.servicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicosBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(117, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(274, 53);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label1";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(117, 84);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 25);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(274, 81);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 30);
            this.nomeTextBox.TabIndex = 3;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(117, 120);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(64, 25);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(274, 117);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 30);
            this.valorTextBox.TabIndex = 5;
            // 
            // tempoServicoLabel
            // 
            tempoServicoLabel.AutoSize = true;
            tempoServicoLabel.Location = new System.Drawing.Point(117, 156);
            tempoServicoLabel.Name = "tempoServicoLabel";
            tempoServicoLabel.Size = new System.Drawing.Size(151, 25);
            tempoServicoLabel.TabIndex = 6;
            tempoServicoLabel.Text = "Tempo Servico:";
            // 
            // tempoServicoTextBox
            // 
            this.tempoServicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "TempoServico", true));
            this.tempoServicoTextBox.Location = new System.Drawing.Point(274, 153);
            this.tempoServicoTextBox.Name = "tempoServicoTextBox";
            this.tempoServicoTextBox.Size = new System.Drawing.Size(100, 30);
            this.tempoServicoTextBox.TabIndex = 7;
            // 
            // produtoIdLabel
            // 
            produtoIdLabel.AutoSize = true;
            produtoIdLabel.Location = new System.Drawing.Point(117, 192);
            produtoIdLabel.Name = "produtoIdLabel";
            produtoIdLabel.Size = new System.Drawing.Size(107, 25);
            produtoIdLabel.TabIndex = 8;
            produtoIdLabel.Text = "Produto Id:";
            // 
            // produtoIdTextBox
            // 
            this.produtoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "ProdutoId", true));
            this.produtoIdTextBox.Location = new System.Drawing.Point(274, 189);
            this.produtoIdTextBox.Name = "produtoIdTextBox";
            this.produtoIdTextBox.Size = new System.Drawing.Size(100, 30);
            this.produtoIdTextBox.TabIndex = 9;
            // 
            // carroIdLabel
            // 
            carroIdLabel.AutoSize = true;
            carroIdLabel.Location = new System.Drawing.Point(117, 228);
            carroIdLabel.Name = "carroIdLabel";
            carroIdLabel.Size = new System.Drawing.Size(88, 25);
            carroIdLabel.TabIndex = 10;
            carroIdLabel.Text = "Carro Id:";
            // 
            // carroIdTextBox
            // 
            this.carroIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "CarroId", true));
            this.carroIdTextBox.Location = new System.Drawing.Point(274, 225);
            this.carroIdTextBox.Name = "carroIdTextBox";
            this.carroIdTextBox.Size = new System.Drawing.Size(100, 30);
            this.carroIdTextBox.TabIndex = 11;
            // 
            // CadServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 401);
            this.Controls.Add(this.servicosBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadServicos";
            this.Text = "CadServicos";
            this.Load += new System.EventHandler(this.CadServicos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingNavigator)).EndInit();
            this.servicosBindingNavigator.ResumeLayout(false);
            this.servicosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private LvSystemDataSetTableAdapters.ServicosTableAdapter servicosTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox tempoServicoTextBox;
        private System.Windows.Forms.TextBox produtoIdTextBox;
        private System.Windows.Forms.TextBox carroIdTextBox;
    }
}