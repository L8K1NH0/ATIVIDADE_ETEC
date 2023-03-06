
namespace _100_ANOS
{
    partial class FrmIdade
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
            this.LblIdade = new System.Windows.Forms.Label();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Lblcalcular = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblIdade.Location = new System.Drawing.Point(7, 9);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(81, 25);
            this.LblIdade.TabIndex = 0;
            this.LblIdade.Text = "IDADE:";
            // 
            // TxtIdade
            // 
            this.TxtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtIdade.Location = new System.Drawing.Point(94, 6);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(100, 31);
            this.TxtIdade.TabIndex = 3;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnCalcular.Location = new System.Drawing.Point(25, 56);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(150, 32);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(7, 235);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(81, 32);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(181, 235);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(84, 32);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Lblcalcular
            // 
            this.Lblcalcular.AutoSize = true;
            this.Lblcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Lblcalcular.Location = new System.Drawing.Point(7, 125);
            this.Lblcalcular.Name = "Lblcalcular";
            this.Lblcalcular.Size = new System.Drawing.Size(83, 25);
            this.Lblcalcular.TabIndex = 6;
            this.Lblcalcular.Text = "Faltam:";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(108, 125);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 25);
            this.LblResultado.TabIndex = 7;
            // 
            // FrmIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 279);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.Lblcalcular);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.LblIdade);
            this.Name = "FrmIdade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quanto falta para 100 Anos?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label Lblcalcular;
        private System.Windows.Forms.Label LblResultado;
    }
}

