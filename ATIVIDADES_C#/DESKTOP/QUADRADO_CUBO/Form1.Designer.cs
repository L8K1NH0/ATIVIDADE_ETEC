
namespace Quadrado_Cubo
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
            this.LblNum = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.BtnQuadrado = new System.Windows.Forms.Button();
            this.BtnCubo = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNum.Location = new System.Drawing.Point(13, 13);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(99, 25);
            this.LblNum.TabIndex = 0;
            this.LblNum.Text = "Número :";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNumero.Location = new System.Drawing.Point(130, 10);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 31);
            this.TxtNumero.TabIndex = 1;
            // 
            // BtnQuadrado
            // 
            this.BtnQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnQuadrado.Location = new System.Drawing.Point(12, 81);
            this.BtnQuadrado.Name = "BtnQuadrado";
            this.BtnQuadrado.Size = new System.Drawing.Size(227, 41);
            this.BtnQuadrado.TabIndex = 2;
            this.BtnQuadrado.Text = "Quadrado";
            this.BtnQuadrado.UseVisualStyleBackColor = true;
            this.BtnQuadrado.Click += new System.EventHandler(this.BtnQuadrado_Click);
            // 
            // BtnCubo
            // 
            this.BtnCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnCubo.Location = new System.Drawing.Point(12, 151);
            this.BtnCubo.Name = "BtnCubo";
            this.BtnCubo.Size = new System.Drawing.Size(227, 41);
            this.BtnCubo.TabIndex = 3;
            this.BtnCubo.Text = "Cubo";
            this.BtnCubo.UseVisualStyleBackColor = true;
            this.BtnCubo.Click += new System.EventHandler(this.BtnCubo_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtResultado.Location = new System.Drawing.Point(130, 233);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 31);
            this.TxtResultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(13, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número :";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(12, 370);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(227, 41);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(12, 300);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(227, 41);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCubo);
            this.Controls.Add(this.BtnQuadrado);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNum);
            this.Name = "Form1";
            this.Text = "Quadrado e Cubo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button BtnQuadrado;
        private System.Windows.Forms.Button BtnCubo;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

