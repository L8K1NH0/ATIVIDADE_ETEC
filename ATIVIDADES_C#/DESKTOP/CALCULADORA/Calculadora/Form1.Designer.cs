
namespace Calculadora
{
    partial class FrmCalculadora
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
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.LblN1 = new System.Windows.Forms.Label();
            this.LblN2 = new System.Windows.Forms.Label();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnSomar = new System.Windows.Forms.Button();
            this.BtnSubtrair = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtN1
            // 
            this.TxtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtN1.Location = new System.Drawing.Point(12, 63);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(205, 31);
            this.TxtN1.TabIndex = 0;
            // 
            // LblN1
            // 
            this.LblN1.AutoSize = true;
            this.LblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblN1.Location = new System.Drawing.Point(12, 35);
            this.LblN1.Name = "LblN1";
            this.LblN1.Size = new System.Drawing.Size(201, 25);
            this.LblN1.TabIndex = 1;
            this.LblN1.Text = "Digite o 1º numero: ";
            // 
            // LblN2
            // 
            this.LblN2.AutoSize = true;
            this.LblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblN2.Location = new System.Drawing.Point(12, 166);
            this.LblN2.Name = "LblN2";
            this.LblN2.Size = new System.Drawing.Size(201, 25);
            this.LblN2.TabIndex = 3;
            this.LblN2.Text = "Digite o 2º numero: ";
            // 
            // TxtN2
            // 
            this.TxtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtN2.Location = new System.Drawing.Point(12, 194);
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(205, 31);
            this.TxtN2.TabIndex = 2;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(12, 281);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(115, 25);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "Resultado:";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtResultado.Location = new System.Drawing.Point(12, 309);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(205, 31);
            this.TxtResultado.TabIndex = 4;
            // 
            // BtnSomar
            // 
            this.BtnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSomar.Location = new System.Drawing.Point(264, 103);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(102, 33);
            this.BtnSomar.TabIndex = 6;
            this.BtnSomar.Text = "&Somar";
            this.BtnSomar.UseVisualStyleBackColor = true;
            this.BtnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // BtnSubtrair
            // 
            this.BtnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSubtrair.Location = new System.Drawing.Point(264, 158);
            this.BtnSubtrair.Name = "BtnSubtrair";
            this.BtnSubtrair.Size = new System.Drawing.Size(102, 33);
            this.BtnSubtrair.TabIndex = 7;
            this.BtnSubtrair.Text = "S&ubritair";
            this.BtnSubtrair.UseVisualStyleBackColor = true;
            this.BtnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnDividir.Location = new System.Drawing.Point(264, 275);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(102, 33);
            this.BtnDividir.TabIndex = 9;
            this.BtnDividir.Text = "&Dividir";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnMultiplicar.Location = new System.Drawing.Point(264, 221);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(102, 33);
            this.BtnMultiplicar.TabIndex = 8;
            this.BtnMultiplicar.Text = "&Multiplicar";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(120, 379);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(102, 33);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(12, 379);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(102, 33);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculadora.Properties.Resources._3500_4_08;
            this.pictureBox2.Location = new System.Drawing.Point(-38, -106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(463, 676);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 458);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnSubtrair);
            this.Controls.Add(this.BtnSomar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblN2);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.LblN1);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Label LblN1;
        private System.Windows.Forms.Label LblN2;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Button BtnSubtrair;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

