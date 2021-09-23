
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
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.panelCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgenda
            // 
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAgenda.Location = new System.Drawing.Point(32, 282);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(114, 36);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnServico
            // 
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.ForeColor = System.Drawing.Color.DarkGray;
            this.btnServico.Location = new System.Drawing.Point(32, 223);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(114, 42);
            this.btnServico.TabIndex = 1;
            this.btnServico.Text = "Serviços";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCliente.Location = new System.Drawing.Point(32, 112);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(114, 42);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarros.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCarros.Location = new System.Drawing.Point(32, 170);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(114, 42);
            this.btnCarros.TabIndex = 2;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.DarkGray;
            this.btnInicio.Location = new System.Drawing.Point(32, 18);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(114, 42);
            this.btnInicio.TabIndex = 4;
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
            this.panelCentral.Size = new System.Drawing.Size(915, 436);
            this.panelCentral.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSelecao);
            this.panel1.Controls.Add(this.btnAgenda);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnCarros);
            this.panel1.Controls.Add(this.btnServico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 434);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 434);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(881, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(843, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 34);
            this.button6.TabIndex = 1;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Transparent;
            this.panelTopo.Controls.Add(this.button6);
            this.panelTopo.Controls.Add(this.button5);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(915, 45);
            this.panelTopo.TabIndex = 1;
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.SystemColors.MenuText;
            this.panelSelecao.ForeColor = System.Drawing.Color.DarkRed;
            this.panelSelecao.Location = new System.Drawing.Point(11, 18);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(17, 19);
            this.panelSelecao.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 481);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTopo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCentral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelSelecao;
    }
}

