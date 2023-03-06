
namespace Antecessor_e_Sucessor
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
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.LblNum = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnAntecessor = new System.Windows.Forms.Button();
            this.BtnSucessor = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum
            // 
            this.TxtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNum.Location = new System.Drawing.Point(124, 9);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(100, 31);
            this.TxtNum.TabIndex = 0;
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNum.Location = new System.Drawing.Point(9, 12);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(93, 25);
            this.LblNum.TabIndex = 1;
            this.LblNum.Text = "Numero:";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtResultado.Location = new System.Drawing.Point(124, 231);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 31);
            this.TxtResultado.TabIndex = 2;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(9, 234);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(115, 25);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.Text = "Resultado:";
            // 
            // BtnAntecessor
            // 
            this.BtnAntecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnAntecessor.Location = new System.Drawing.Point(14, 77);
            this.BtnAntecessor.Name = "BtnAntecessor";
            this.BtnAntecessor.Size = new System.Drawing.Size(210, 34);
            this.BtnAntecessor.TabIndex = 4;
            this.BtnAntecessor.Text = "Antecessor";
            this.BtnAntecessor.UseVisualStyleBackColor = true;
            this.BtnAntecessor.Click += new System.EventHandler(this.BtnAntecessor_Click);
            // 
            // BtnSucessor
            // 
            this.BtnSucessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSucessor.Location = new System.Drawing.Point(14, 146);
            this.BtnSucessor.Name = "BtnSucessor";
            this.BtnSucessor.Size = new System.Drawing.Size(210, 34);
            this.BtnSucessor.TabIndex = 5;
            this.BtnSucessor.Text = "Sucessor";
            this.BtnSucessor.UseVisualStyleBackColor = true;
            this.BtnSucessor.Click += new System.EventHandler(this.BtnSucessor_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(14, 360);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(210, 34);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(14, 291);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(210, 34);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 412);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSucessor);
            this.Controls.Add(this.BtnAntecessor);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.TxtNum);
            this.Name = "Form1";
            this.Text = "Antecessor e Sucessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnAntecessor;
        private System.Windows.Forms.Button BtnSucessor;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

