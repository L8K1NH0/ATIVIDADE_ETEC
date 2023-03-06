
namespace SOMA_10_15
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
            this.BtnSomar = new System.Windows.Forms.Button();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSomar
            // 
            this.BtnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSomar.Location = new System.Drawing.Point(64, 88);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(83, 30);
            this.BtnSomar.TabIndex = 0;
            this.BtnSomar.Text = "Somar";
            this.BtnSomar.UseVisualStyleBackColor = true;
            this.BtnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNumero.Location = new System.Drawing.Point(12, 9);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(183, 25);
            this.LblNumero.TabIndex = 1;
            this.LblNumero.Text = "Digite um Número";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNumero.Location = new System.Drawing.Point(54, 37);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 31);
            this.TxtNumero.TabIndex = 2;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(57, 154);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(103, 25);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.Text = "-------------";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(12, 265);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(99, 30);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(125, 265);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(83, 30);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 307);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.BtnSomar);
            this.Name = "Form1";
            this.Text = "10 OU 15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

