
namespace TROCA_DE_VALORES
{
    partial class FrmTrocaDeValores
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
            this.button1 = new System.Windows.Forms.Button();
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.TxtNumeroA = new System.Windows.Forms.TextBox();
            this.TxtNumeroB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(187, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "TROCA TROCA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNumero1.Location = new System.Drawing.Point(12, 9);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(113, 25);
            this.LblNumero1.TabIndex = 1;
            this.LblNumero1.Text = "Numero A:";
            // 
            // TxtNumeroA
            // 
            this.TxtNumeroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNumeroA.Location = new System.Drawing.Point(12, 37);
            this.TxtNumeroA.Name = "TxtNumeroA";
            this.TxtNumeroA.Size = new System.Drawing.Size(100, 31);
            this.TxtNumeroA.TabIndex = 2;
            // 
            // TxtNumeroB
            // 
            this.TxtNumeroB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNumeroB.Location = new System.Drawing.Point(12, 142);
            this.TxtNumeroB.Name = "TxtNumeroB";
            this.TxtNumeroB.Size = new System.Drawing.Size(100, 31);
            this.TxtNumeroB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero B:";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(12, 273);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(87, 33);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(221, 273);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(87, 33);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // FrmTrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 318);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtNumeroB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumeroA);
            this.Controls.Add(this.LblNumero1);
            this.Controls.Add(this.button1);
            this.Name = "FrmTrocaDeValores";
            this.Text = "Ttoca Troca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.TextBox TxtNumeroA;
        private System.Windows.Forms.TextBox TxtNumeroB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

