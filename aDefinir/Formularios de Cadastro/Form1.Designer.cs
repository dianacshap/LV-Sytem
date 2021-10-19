
namespace aDefinir
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupAgendamentos = new System.Windows.Forms.GroupBox();
            this.lblAgendado = new System.Windows.Forms.Label();
            this.lblEmAndamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.lvSystemDataSet = new aDefinir.LvSystemDataSet();
            this.tableAdapterManager = new aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.view_Detalhes_AgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Detalhes_AgendamentosTableAdapter = new aDefinir.LvSystemDataSetTableAdapters.View_Detalhes_AgendamentosTableAdapter();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Detalhes_AgendamentosBindingSource)).BeginInit();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgenda
            // 
            this.btnAgenda.AutoSize = true;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.Color.Black;
            this.btnAgenda.Location = new System.Drawing.Point(69, 277);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(126, 47);
            this.btnAgenda.TabIndex = 5;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnServico
            // 
            this.btnServico.AutoSize = true;
            this.btnServico.FlatAppearance.BorderSize = 0;
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.ForeColor = System.Drawing.Color.Black;
            this.btnServico.Location = new System.Drawing.Point(69, 225);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(126, 53);
            this.btnServico.TabIndex = 4;
            this.btnServico.Text = "Serviços";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCliente.Location = new System.Drawing.Point(69, 70);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(126, 52);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.AutoSize = true;
            this.btnCarros.FlatAppearance.BorderSize = 0;
            this.btnCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarros.ForeColor = System.Drawing.Color.Black;
            this.btnCarros.Location = new System.Drawing.Point(69, 121);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(126, 53);
            this.btnCarros.TabIndex = 2;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = true;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Location = new System.Drawing.Point(69, 18);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(126, 52);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral.Controls.Add(this.panel2);
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 45);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1604, 836);
            this.panelCentral.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::aDefinir.Properties.Resources.lvsytem;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1404, 834);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.groupAgendamentos);
            this.panel1.Controls.Add(this.panelSelecao);
            this.panel1.Controls.Add(this.btnAgenda);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnCarros);
            this.panel1.Controls.Add(this.btnServico);
            this.panel1.Controls.Add(this.btnProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 834);
            this.panel1.TabIndex = 0;
            // 
            // groupAgendamentos
            // 
            this.groupAgendamentos.Controls.Add(this.lblAgendado);
            this.groupAgendamentos.Controls.Add(this.lblEmAndamento);
            this.groupAgendamentos.Controls.Add(this.label2);
            this.groupAgendamentos.Controls.Add(this.label1);
            this.groupAgendamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAgendamentos.Location = new System.Drawing.Point(24, 375);
            this.groupAgendamentos.Name = "groupAgendamentos";
            this.groupAgendamentos.Size = new System.Drawing.Size(168, 121);
            this.groupAgendamentos.TabIndex = 0;
            this.groupAgendamentos.TabStop = false;
            this.groupAgendamentos.Text = "Agendamentos";
            // 
            // lblAgendado
            // 
            this.lblAgendado.AutoSize = true;
            this.lblAgendado.ForeColor = System.Drawing.Color.White;
            this.lblAgendado.Location = new System.Drawing.Point(136, 75);
            this.lblAgendado.Name = "lblAgendado";
            this.lblAgendado.Size = new System.Drawing.Size(19, 20);
            this.lblAgendado.TabIndex = 8;
            this.lblAgendado.Text = "0";
            // 
            // lblEmAndamento
            // 
            this.lblEmAndamento.AutoSize = true;
            this.lblEmAndamento.ForeColor = System.Drawing.Color.White;
            this.lblEmAndamento.Location = new System.Drawing.Point(136, 43);
            this.lblEmAndamento.Name = "lblEmAndamento";
            this.lblEmAndamento.Size = new System.Drawing.Size(19, 20);
            this.lblEmAndamento.TabIndex = 7;
            this.lblEmAndamento.Text = "0";
            this.lblEmAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agendado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Em Andamento";
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSelecao.ForeColor = System.Drawing.Color.DarkRed;
            this.panelSelecao.Location = new System.Drawing.Point(182, 18);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(40, 52);
            this.panelSelecao.TabIndex = 1;
            // 
            // btnProdutos
            // 
            this.btnProdutos.AutoSize = true;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnProdutos.Location = new System.Drawing.Point(69, 173);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(128, 53);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
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
            this.tableAdapterManager.ServicoProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aDefinir.LvSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // view_Detalhes_AgendamentosBindingSource
            // 
            this.view_Detalhes_AgendamentosBindingSource.DataMember = "View_Detalhes_Agendamentos";
            this.view_Detalhes_AgendamentosBindingSource.DataSource = this.lvSystemDataSet;
            // 
            // view_Detalhes_AgendamentosTableAdapter
            // 
            this.view_Detalhes_AgendamentosTableAdapter.ClearBeforeFill = true;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(1553, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(31, 35);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMinizar.FlatAppearance.BorderSize = 0;
            this.btnMinizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinizar.Location = new System.Drawing.Point(1515, 5);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(32, 34);
            this.btnMinizar.TabIndex = 1;
            this.btnMinizar.Text = "-";
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTopo.Controls.Add(this.btnSair);
            this.panelTopo.Controls.Add(this.btnMinizar);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(1604, 45);
            this.panelTopo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTopo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCentral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupAgendamentos.ResumeLayout(false);
            this.groupAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Detalhes_AgendamentosBindingSource)).EndInit();
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.GroupBox groupAgendamentos;
        private LvSystemDataSet lvSystemDataSet;
        private System.Windows.Forms.BindingSource view_Detalhes_AgendamentosBindingSource;
        private LvSystemDataSetTableAdapters.View_Detalhes_AgendamentosTableAdapter view_Detalhes_AgendamentosTableAdapter;
        private LvSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAgendado;
        private System.Windows.Forms.Label lblEmAndamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMinizar;
        private System.Windows.Forms.Panel panelTopo;
    }
}

