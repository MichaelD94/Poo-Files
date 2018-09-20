namespace Prova_final_POO
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
            this.textBoxfrase = new System.Windows.Forms.TextBox();
            this.buttonVogais = new System.Windows.Forms.Button();
            this.buttonConsoantes = new System.Windows.Forms.Button();
            this.buttonNumeros = new System.Windows.Forms.Button();
            this.buttonSpace = new System.Windows.Forms.Button();
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxfrase
            // 
            this.textBoxfrase.Location = new System.Drawing.Point(44, 12);
            this.textBoxfrase.Multiline = true;
            this.textBoxfrase.Name = "textBoxfrase";
            this.textBoxfrase.Size = new System.Drawing.Size(713, 98);
            this.textBoxfrase.TabIndex = 0;
            this.textBoxfrase.Text = "Digite Aqui Sua Frase";
            this.textBoxfrase.TextChanged += new System.EventHandler(this.textBoxfrase_TextChanged);
            // 
            // buttonVogais
            // 
            this.buttonVogais.Location = new System.Drawing.Point(44, 178);
            this.buttonVogais.Name = "buttonVogais";
            this.buttonVogais.Size = new System.Drawing.Size(123, 23);
            this.buttonVogais.TabIndex = 1;
            this.buttonVogais.Text = "Vogais";
            this.buttonVogais.UseVisualStyleBackColor = true;
            this.buttonVogais.Click += new System.EventHandler(this.buttonVogais_Click);
            // 
            // buttonConsoantes
            // 
            this.buttonConsoantes.Location = new System.Drawing.Point(252, 178);
            this.buttonConsoantes.Name = "buttonConsoantes";
            this.buttonConsoantes.Size = new System.Drawing.Size(114, 23);
            this.buttonConsoantes.TabIndex = 2;
            this.buttonConsoantes.Text = "Consoantes";
            this.buttonConsoantes.UseVisualStyleBackColor = true;
            this.buttonConsoantes.Click += new System.EventHandler(this.buttonConsoantes_Click);
            // 
            // buttonNumeros
            // 
            this.buttonNumeros.Location = new System.Drawing.Point(447, 178);
            this.buttonNumeros.Name = "buttonNumeros";
            this.buttonNumeros.Size = new System.Drawing.Size(125, 23);
            this.buttonNumeros.TabIndex = 3;
            this.buttonNumeros.Text = "Numeros";
            this.buttonNumeros.UseVisualStyleBackColor = true;
            this.buttonNumeros.Click += new System.EventHandler(this.buttonNumeros_Click);
            // 
            // buttonSpace
            // 
            this.buttonSpace.Location = new System.Drawing.Point(641, 178);
            this.buttonSpace.Name = "buttonSpace";
            this.buttonSpace.Size = new System.Drawing.Size(126, 23);
            this.buttonSpace.TabIndex = 4;
            this.buttonSpace.Text = "Espaco";
            this.buttonSpace.UseVisualStyleBackColor = true;
            this.buttonSpace.Click += new System.EventHandler(this.buttonSpace_Click);
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Location = new System.Drawing.Point(333, 308);
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.Size = new System.Drawing.Size(133, 20);
            this.textBoxresultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Michael Douglas Paim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "608275";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(360, 398);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.buttonSpace);
            this.Controls.Add(this.buttonNumeros);
            this.Controls.Add(this.buttonConsoantes);
            this.Controls.Add(this.buttonVogais);
            this.Controls.Add(this.textBoxfrase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxfrase;
        private System.Windows.Forms.Button buttonVogais;
        private System.Windows.Forms.Button buttonConsoantes;
        private System.Windows.Forms.Button buttonNumeros;
        private System.Windows.Forms.Button buttonSpace;
        private System.Windows.Forms.TextBox textBoxresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
    }
}

