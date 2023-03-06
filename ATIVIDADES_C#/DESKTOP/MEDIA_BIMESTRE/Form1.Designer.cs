
namespace MEDIA_BIMESTRE
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.LblNota1 = new System.Windows.Forms.Label();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.LblNota2 = new System.Windows.Forms.Label();
            this.TxtNota4 = new System.Windows.Forms.TextBox();
            this.LblNota4 = new System.Windows.Forms.Label();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.LblNota3 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblMenssagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnCalcular.Location = new System.Drawing.Point(82, 207);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(132, 42);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNome.Location = new System.Drawing.Point(12, 9);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(68, 25);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNome.Location = new System.Drawing.Point(179, 6);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 31);
            this.TxtNome.TabIndex = 2;
            // 
            // TxtNota1
            // 
            this.TxtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNota1.Location = new System.Drawing.Point(179, 43);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(100, 31);
            this.TxtNota1.TabIndex = 4;
            // 
            // LblNota1
            // 
            this.LblNota1.AutoSize = true;
            this.LblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNota1.Location = new System.Drawing.Point(12, 46);
            this.LblNota1.Name = "LblNota1";
            this.LblNota1.Size = new System.Drawing.Size(161, 25);
            this.LblNota1.TabIndex = 3;
            this.LblNota1.Text = "Nota do 1° Bim:";
            // 
            // TxtNota2
            // 
            this.TxtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNota2.Location = new System.Drawing.Point(179, 80);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(100, 31);
            this.TxtNota2.TabIndex = 6;
            // 
            // LblNota2
            // 
            this.LblNota2.AutoSize = true;
            this.LblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNota2.Location = new System.Drawing.Point(12, 83);
            this.LblNota2.Name = "LblNota2";
            this.LblNota2.Size = new System.Drawing.Size(161, 25);
            this.LblNota2.TabIndex = 5;
            this.LblNota2.Text = "Nota do 2° Bim:";
            // 
            // TxtNota4
            // 
            this.TxtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNota4.Location = new System.Drawing.Point(179, 152);
            this.TxtNota4.Name = "TxtNota4";
            this.TxtNota4.Size = new System.Drawing.Size(100, 31);
            this.TxtNota4.TabIndex = 10;
            // 
            // LblNota4
            // 
            this.LblNota4.AutoSize = true;
            this.LblNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNota4.Location = new System.Drawing.Point(12, 155);
            this.LblNota4.Name = "LblNota4";
            this.LblNota4.Size = new System.Drawing.Size(161, 25);
            this.LblNota4.TabIndex = 9;
            this.LblNota4.Text = "Nota do 4° Bim:";
            // 
            // TxtNota3
            // 
            this.TxtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNota3.Location = new System.Drawing.Point(179, 115);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(100, 31);
            this.TxtNota3.TabIndex = 8;
            // 
            // LblNota3
            // 
            this.LblNota3.AutoSize = true;
            this.LblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNota3.Location = new System.Drawing.Point(12, 118);
            this.LblNota3.Name = "LblNota3";
            this.LblNota3.Size = new System.Drawing.Size(161, 25);
            this.LblNota3.TabIndex = 7;
            this.LblNota3.Text = "Nota do 3° Bim:";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(12, 402);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(101, 36);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(183, 402);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(101, 36);
            this.BtnLimpar.TabIndex = 12;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(12, 262);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(278, 25);
            this.LblResultado.TabIndex = 13;
            this.LblResultado.Text = "--------------------------------------";
            // 
            // LblMenssagem
            // 
            this.LblMenssagem.AutoSize = true;
            this.LblMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblMenssagem.Location = new System.Drawing.Point(12, 312);
            this.LblMenssagem.Name = "LblMenssagem";
            this.LblMenssagem.Size = new System.Drawing.Size(278, 25);
            this.LblMenssagem.TabIndex = 14;
            this.LblMenssagem.Text = "--------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.LblMenssagem);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtNota4);
            this.Controls.Add(this.LblNota4);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.LblNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.LblNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.LblNota1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "Form1";
            this.Text = "Média";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.Label LblNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.Label LblNota2;
        private System.Windows.Forms.TextBox TxtNota4;
        private System.Windows.Forms.Label LblNota4;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.Label LblNota3;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblMenssagem;
    }
}

