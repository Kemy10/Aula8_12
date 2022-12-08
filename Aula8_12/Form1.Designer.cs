namespace Aula8_12
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
            this.msg1 = new System.Windows.Forms.Label();
            this.botao1 = new System.Windows.Forms.Button();
            this.msg2 = new System.Windows.Forms.Label();
            this.imput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msg1
            // 
            this.msg1.AutoSize = true;
            this.msg1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg1.Location = new System.Drawing.Point(12, 24);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(184, 25);
            this.msg1.TabIndex = 1;
            this.msg1.Text = "Digite um Nome:";
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(17, 101);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(107, 37);
            this.botao1.TabIndex = 2;
            this.botao1.Text = "Enviar";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // msg2
            // 
            this.msg2.AutoSize = true;
            this.msg2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg2.Location = new System.Drawing.Point(20, 155);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(222, 25);
            this.msg2.TabIndex = 3;
            this.msg2.Text = "O nome digitado foi: ";
            // 
            // imput
            // 
            this.imput.Location = new System.Drawing.Point(17, 66);
            this.imput.Name = "imput";
            this.imput.Size = new System.Drawing.Size(166, 20);
            this.imput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imput);
            this.Controls.Add(this.msg2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.msg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label msg1;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label msg2;
        private System.Windows.Forms.TextBox imput;
    }
}

