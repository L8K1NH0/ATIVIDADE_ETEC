
namespace IMC
{
    partial class FrmIMC
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
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblIndice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPeso
            // 
            this.TxtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtPeso.Location = new System.Drawing.Point(159, 12);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 31);
            this.TxtPeso.TabIndex = 0;
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblPeso.Location = new System.Drawing.Point(47, 15);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(111, 25);
            this.LblPeso.TabIndex = 1;
            this.LblPeso.Text = "Peso(KG):";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblAltura.Location = new System.Drawing.Point(47, 52);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(106, 25);
            this.LblAltura.TabIndex = 3;
            this.LblAltura.Text = "Altura(M):";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtAltura.Location = new System.Drawing.Point(159, 49);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 31);
            this.TxtAltura.TabIndex = 2;
            // 
            // CALCULAR
            // 
            this.CALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CALCULAR.Location = new System.Drawing.Point(75, 92);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(168, 40);
            this.CALCULAR.TabIndex = 4;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(12, 260);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(125, 40);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(159, 260);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(125, 40);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(77, 188);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 25);
            this.LblResultado.TabIndex = 7;
            // 
            // LblIndice
            // 
            this.LblIndice.AutoSize = true;
            this.LblIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblIndice.Location = new System.Drawing.Point(129, 135);
            this.LblIndice.Name = "LblIndice";
            this.LblIndice.Size = new System.Drawing.Size(0, 25);
            this.LblIndice.TabIndex = 8;
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 312);
            this.Controls.Add(this.LblIndice);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.TxtPeso);
            this.Name = "FrmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.FrmIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblIndice;
    }
}

