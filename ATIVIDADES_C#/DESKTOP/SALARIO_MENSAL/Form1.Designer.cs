
namespace VALOR_HORA
{
    partial class FrmValorHora
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
            this.LblHoraTrabalhoSemana = new System.Windows.Forms.Label();
            this.TxtHorasSemanas = new System.Windows.Forms.TextBox();
            this.LblValorHora = new System.Windows.Forms.Label();
            this.TxtValorHora = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.LblIdade = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtFilhos = new System.Windows.Forms.TextBox();
            this.LblFilhos = new System.Windows.Forms.Label();
            this.LblBous = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnCalcular.Location = new System.Drawing.Point(12, 207);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(153, 37);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblHoraTrabalhoSemana
            // 
            this.LblHoraTrabalhoSemana.AutoSize = true;
            this.LblHoraTrabalhoSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblHoraTrabalhoSemana.Location = new System.Drawing.Point(11, 126);
            this.LblHoraTrabalhoSemana.Name = "LblHoraTrabalhoSemana";
            this.LblHoraTrabalhoSemana.Size = new System.Drawing.Size(320, 25);
            this.LblHoraTrabalhoSemana.TabIndex = 1;
            this.LblHoraTrabalhoSemana.Text = "Horas Trabalhadas por semana:";
            // 
            // TxtHorasSemanas
            // 
            this.TxtHorasSemanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtHorasSemanas.Location = new System.Drawing.Point(356, 123);
            this.TxtHorasSemanas.Name = "TxtHorasSemanas";
            this.TxtHorasSemanas.Size = new System.Drawing.Size(100, 31);
            this.TxtHorasSemanas.TabIndex = 4;
            this.TxtHorasSemanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHorasSemanas_KeyPress);
            // 
            // LblValorHora
            // 
            this.LblValorHora.AutoSize = true;
            this.LblValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblValorHora.Location = new System.Drawing.Point(10, 163);
            this.LblValorHora.Name = "LblValorHora";
            this.LblValorHora.Size = new System.Drawing.Size(240, 25);
            this.LblValorHora.TabIndex = 3;
            this.LblValorHora.Text = "Quanto ganha por hora:";
            // 
            // TxtValorHora
            // 
            this.TxtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtValorHora.Location = new System.Drawing.Point(356, 160);
            this.TxtValorHora.Name = "TxtValorHora";
            this.TxtValorHora.Size = new System.Drawing.Size(100, 31);
            this.TxtValorHora.TabIndex = 5;
            this.TxtValorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorHora_KeyPress);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblResultado.Location = new System.Drawing.Point(7, 299);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(19, 25);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "-";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSair.Location = new System.Drawing.Point(12, 414);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(153, 37);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnLimpar.Location = new System.Drawing.Point(304, 414);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(153, 37);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtIdade
            // 
            this.TxtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtIdade.Location = new System.Drawing.Point(356, 49);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(100, 31);
            this.TxtIdade.TabIndex = 2;
            this.TxtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdade_KeyPress);
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblIdade.Location = new System.Drawing.Point(12, 52);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(71, 25);
            this.LblIdade.TabIndex = 10;
            this.LblIdade.Text = "Idade:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNome.Location = new System.Drawing.Point(356, 12);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 31);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNome.Location = new System.Drawing.Point(12, 15);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(74, 25);
            this.LblNome.TabIndex = 8;
            this.LblNome.Text = "Nome:";
            // 
            // TxtFilhos
            // 
            this.TxtFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtFilhos.Location = new System.Drawing.Point(357, 86);
            this.TxtFilhos.Name = "TxtFilhos";
            this.TxtFilhos.Size = new System.Drawing.Size(100, 31);
            this.TxtFilhos.TabIndex = 3;
            this.TxtFilhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilhos_KeyPress);
            // 
            // LblFilhos
            // 
            this.LblFilhos.AutoSize = true;
            this.LblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblFilhos.Location = new System.Drawing.Point(12, 89);
            this.LblFilhos.Name = "LblFilhos";
            this.LblFilhos.Size = new System.Drawing.Size(216, 25);
            this.LblFilhos.TabIndex = 12;
            this.LblFilhos.Text = "Quantidade de filhos:";
            // 
            // LblBous
            // 
            this.LblBous.AutoSize = true;
            this.LblBous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblBous.Location = new System.Drawing.Point(7, 365);
            this.LblBous.Name = "LblBous";
            this.LblBous.Size = new System.Drawing.Size(19, 25);
            this.LblBous.TabIndex = 14;
            this.LblBous.Text = "-";
            // 
            // FrmValorHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 479);
            this.Controls.Add(this.LblBous);
            this.Controls.Add(this.TxtFilhos);
            this.Controls.Add(this.LblFilhos);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.LblIdade);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtValorHora);
            this.Controls.Add(this.LblValorHora);
            this.Controls.Add(this.TxtHorasSemanas);
            this.Controls.Add(this.LblHoraTrabalhoSemana);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "FrmValorHora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Salario do Pião";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblHoraTrabalhoSemana;
        private System.Windows.Forms.TextBox TxtHorasSemanas;
        private System.Windows.Forms.Label LblValorHora;
        private System.Windows.Forms.TextBox TxtValorHora;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtFilhos;
        private System.Windows.Forms.Label LblFilhos;
        private System.Windows.Forms.Label LblBous;
    }
}

