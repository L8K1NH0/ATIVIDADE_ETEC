
namespace Delta
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
            this.LblFormula = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.LblC = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFormula
            // 
            this.LblFormula.AutoSize = true;
            this.LblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblFormula.Location = new System.Drawing.Point(13, 13);
            this.LblFormula.Name = "LblFormula";
            this.LblFormula.Size = new System.Drawing.Size(234, 25);
            this.LblFormula.TabIndex = 0;
            this.LblFormula.Text = "Delta = B ^ 2 - 4 * A * C";
            // 
            // TxtA
            // 
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtA.Location = new System.Drawing.Point(109, 59);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(72, 31);
            this.TxtA.TabIndex = 1;
            this.TxtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblA.Location = new System.Drawing.Point(65, 62);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(38, 25);
            this.LblA.TabIndex = 2;
            this.LblA.Text = "A :";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblB.Location = new System.Drawing.Point(65, 99);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(38, 25);
            this.LblB.TabIndex = 4;
            this.LblB.Text = "B :";
            // 
            // TxtB
            // 
            this.TxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtB.Location = new System.Drawing.Point(109, 96);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(72, 31);
            this.TxtB.TabIndex = 3;
            this.TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblC.Location = new System.Drawing.Point(65, 136);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(39, 25);
            this.LblC.TabIndex = 6;
            this.LblC.Text = "C :";
            // 
            // TxtC
            // 
            this.TxtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtC.Location = new System.Drawing.Point(109, 133);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(72, 31);
            this.TxtC.TabIndex = 5;
            this.TxtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnCalcular.Location = new System.Drawing.Point(18, 191);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(229, 41);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(18, 315);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(103, 41);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtResultado.Location = new System.Drawing.Point(18, 238);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(229, 31);
            this.TxtResultado.TabIndex = 9;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(144, 315);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(103, 41);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 382);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.LblFormula);
            this.Name = "Form1";
            this.Text = "Calculo de Delta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormula;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnSair;
    }
}

