namespace Aula8_12
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.imput2 = new System.Windows.Forms.TextBox();
            this.imput1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(536, 86);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(135, 50);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Limpar";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // imput2
            // 
            this.imput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imput2.BackColor = System.Drawing.Color.White;
            this.imput2.Location = new System.Drawing.Point(22, 86);
            this.imput2.Multiline = true;
            this.imput2.Name = "imput2";
            this.imput2.ReadOnly = true;
            this.imput2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.imput2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.imput2.Size = new System.Drawing.Size(399, 288);
            this.imput2.TabIndex = 1;
            this.imput2.TabStop = false;
            // 
            // imput1
            // 
            this.imput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imput1.Location = new System.Drawing.Point(12, 21);
            this.imput1.Name = "imput1";
            this.imput1.Size = new System.Drawing.Size(123, 20);
            this.imput1.TabIndex = 2;
            this.imput1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imput1);
            this.Controls.Add(this.imput2);
            this.Controls.Add(this.botao1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.TextBox imput2;
        private System.Windows.Forms.TextBox imput1;
    }
}