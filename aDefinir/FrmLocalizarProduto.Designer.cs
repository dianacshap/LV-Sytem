
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
            this.txtNome = new System.Windows.Forms.Label();
            this.txtNomeLocalizar = new System.Windows.Forms.TextBox();
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
            // 
            // FrmLocalizarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 314);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNomeLocalizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocalizarProduto";
            this.Text = "Localizar Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox txtNomeLocalizar;
    }
}