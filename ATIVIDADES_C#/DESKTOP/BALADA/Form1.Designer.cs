
namespace BALADA
{
    partial class FrmBalada
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
            this.BtnProximo = new System.Windows.Forms.Button();
            this.LblIdade = new System.Windows.Forms.Label();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnProximo.Location = new System.Drawing.Point(12, 55);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(100, 34);
            this.BtnProximo.TabIndex = 0;
            this.BtnProximo.Text = "Proximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblIdade.Location = new System.Drawing.Point(12, 9);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(71, 25);
            this.LblIdade.TabIndex = 1;
            this.LblIdade.Text = "Idade:";
            // 
            // TxtIdade
            // 
            this.TxtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtIdade.Location = new System.Drawing.Point(89, 6);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(100, 31);
            this.TxtIdade.TabIndex = 2;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(12, 117);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 25);
            this.LblResultado.TabIndex = 3;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(12, 251);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(92, 34);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(201, 251);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(92, 34);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // FrmBalada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 311);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.LblIdade);
            this.Controls.Add(this.BtnProximo);
            this.Name = "FrmBalada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BALADA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

