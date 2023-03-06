namespace FAHRENHEIT
{
    partial class FrmTemperatura
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblGraus = new System.Windows.Forms.Label();
            this.TxtGraus = new System.Windows.Forms.TextBox();
            this.ChkGrausC = new System.Windows.Forms.CheckBox();
            this.ChkGrausF = new System.Windows.Forms.CheckBox();
            this.ChkGrausK = new System.Windows.Forms.CheckBox();
            this.LblGrausC = new System.Windows.Forms.Label();
            this.LblGrausF = new System.Windows.Forms.Label();
            this.LblGrausK = new System.Windows.Forms.Label();
            this.LblResultadoK = new System.Windows.Forms.Label();
            this.LblResultadoF = new System.Windows.Forms.Label();
            this.LblResultadoC = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnCalcular.Location = new System.Drawing.Point(39, 145);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(135, 31);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblGraus
            // 
            this.LblGraus.AutoSize = true;
            this.LblGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblGraus.Location = new System.Drawing.Point(12, 9);
            this.LblGraus.Name = "LblGraus";
            this.LblGraus.Size = new System.Drawing.Size(82, 25);
            this.LblGraus.TabIndex = 1;
            this.LblGraus.Text = " Graus:";
            // 
            // TxtGraus
            // 
            this.TxtGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtGraus.Location = new System.Drawing.Point(100, 6);
            this.TxtGraus.Name = "TxtGraus";
            this.TxtGraus.Size = new System.Drawing.Size(105, 31);
            this.TxtGraus.TabIndex = 2;
            // 
            // ChkGrausC
            // 
            this.ChkGrausC.AutoSize = true;
            this.ChkGrausC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ChkGrausC.Location = new System.Drawing.Point(17, 55);
            this.ChkGrausC.Name = "ChkGrausC";
            this.ChkGrausC.Size = new System.Drawing.Size(115, 21);
            this.ChkGrausC.TabIndex = 5;
            this.ChkGrausC.Text = "Graus Celsius";
            this.ChkGrausC.UseVisualStyleBackColor = true;
            this.ChkGrausC.CheckedChanged += new System.EventHandler(this.ChkGrausC_CheckedChanged);
            // 
            // ChkGrausF
            // 
            this.ChkGrausF.AutoSize = true;
            this.ChkGrausF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ChkGrausF.Location = new System.Drawing.Point(17, 82);
            this.ChkGrausF.Name = "ChkGrausF";
            this.ChkGrausF.Size = new System.Drawing.Size(138, 21);
            this.ChkGrausF.TabIndex = 6;
            this.ChkGrausF.Text = "Graus Fahrenheit";
            this.ChkGrausF.UseVisualStyleBackColor = true;
            this.ChkGrausF.CheckedChanged += new System.EventHandler(this.ChkGrausF_CheckedChanged);
            // 
            // ChkGrausK
            // 
            this.ChkGrausK.AutoSize = true;
            this.ChkGrausK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ChkGrausK.Location = new System.Drawing.Point(17, 109);
            this.ChkGrausK.Name = "ChkGrausK";
            this.ChkGrausK.Size = new System.Drawing.Size(108, 21);
            this.ChkGrausK.TabIndex = 7;
            this.ChkGrausK.Text = "Graus Kelvin";
            this.ChkGrausK.UseVisualStyleBackColor = true;
            this.ChkGrausK.CheckedChanged += new System.EventHandler(this.ChkGrausK_CheckedChanged);
            // 
            // LblGrausC
            // 
            this.LblGrausC.AutoSize = true;
            this.LblGrausC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblGrausC.Location = new System.Drawing.Point(15, 202);
            this.LblGrausC.Name = "LblGrausC";
            this.LblGrausC.Size = new System.Drawing.Size(41, 25);
            this.LblGrausC.TabIndex = 8;
            this.LblGrausC.Text = "ºC:";
            // 
            // LblGrausF
            // 
            this.LblGrausF.AutoSize = true;
            this.LblGrausF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblGrausF.Location = new System.Drawing.Point(15, 227);
            this.LblGrausF.Name = "LblGrausF";
            this.LblGrausF.Size = new System.Drawing.Size(39, 25);
            this.LblGrausF.TabIndex = 9;
            this.LblGrausF.Text = "ºF:";
            // 
            // LblGrausK
            // 
            this.LblGrausK.AutoSize = true;
            this.LblGrausK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblGrausK.Location = new System.Drawing.Point(15, 252);
            this.LblGrausK.Name = "LblGrausK";
            this.LblGrausK.Size = new System.Drawing.Size(40, 25);
            this.LblGrausK.TabIndex = 10;
            this.LblGrausK.Text = "ºK:";
            // 
            // LblResultadoK
            // 
            this.LblResultadoK.AutoSize = true;
            this.LblResultadoK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultadoK.Location = new System.Drawing.Point(61, 252);
            this.LblResultadoK.Name = "LblResultadoK";
            this.LblResultadoK.Size = new System.Drawing.Size(33, 25);
            this.LblResultadoK.TabIndex = 13;
            this.LblResultadoK.Text = "---";
            // 
            // LblResultadoF
            // 
            this.LblResultadoF.AutoSize = true;
            this.LblResultadoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultadoF.Location = new System.Drawing.Point(61, 227);
            this.LblResultadoF.Name = "LblResultadoF";
            this.LblResultadoF.Size = new System.Drawing.Size(33, 25);
            this.LblResultadoF.TabIndex = 12;
            this.LblResultadoF.Text = "---";
            // 
            // LblResultadoC
            // 
            this.LblResultadoC.AutoSize = true;
            this.LblResultadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultadoC.Location = new System.Drawing.Point(61, 202);
            this.LblResultadoC.Name = "LblResultadoC";
            this.LblResultadoC.Size = new System.Drawing.Size(33, 25);
            this.LblResultadoC.TabIndex = 11;
            this.LblResultadoC.Text = "---";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(5, 310);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(104, 31);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(122, 310);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(91, 31);
            this.BtnSair.TabIndex = 15;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 353);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblResultadoK);
            this.Controls.Add(this.LblResultadoF);
            this.Controls.Add(this.LblResultadoC);
            this.Controls.Add(this.LblGrausK);
            this.Controls.Add(this.LblGrausF);
            this.Controls.Add(this.LblGrausC);
            this.Controls.Add(this.ChkGrausK);
            this.Controls.Add(this.ChkGrausF);
            this.Controls.Add(this.ChkGrausC);
            this.Controls.Add(this.TxtGraus);
            this.Controls.Add(this.LblGraus);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "FrmTemperatura";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblGraus;
        private System.Windows.Forms.TextBox TxtGraus;
        private System.Windows.Forms.CheckBox ChkGrausC;
        private System.Windows.Forms.CheckBox ChkGrausF;
        private System.Windows.Forms.CheckBox ChkGrausK;
        private System.Windows.Forms.Label LblGrausC;
        private System.Windows.Forms.Label LblGrausF;
        private System.Windows.Forms.Label LblGrausK;
        private System.Windows.Forms.Label LblResultadoK;
        private System.Windows.Forms.Label LblResultadoF;
        private System.Windows.Forms.Label LblResultadoC;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

