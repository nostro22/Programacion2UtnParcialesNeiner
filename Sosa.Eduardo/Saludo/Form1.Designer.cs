
namespace Saludo
{
    partial class FrmSaludar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblIntroduccion = new System.Windows.Forms.Label();
            this.LblSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblIntroduccion
            // 
            this.LblIntroduccion.AutoSize = true;
            this.LblIntroduccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblIntroduccion.Location = new System.Drawing.Point(24, 32);
            this.LblIntroduccion.Name = "LblIntroduccion";
            this.LblIntroduccion.Size = new System.Drawing.Size(219, 25);
            this.LblIntroduccion.TabIndex = 0;
            this.LblIntroduccion.Text = "!Hola, Windows Forms!";
            // 
            // LblSaludo
            // 
            this.LblSaludo.AutoSize = true;
            this.LblSaludo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSaludo.Location = new System.Drawing.Point(24, 79);
            this.LblSaludo.Name = "LblSaludo";
            this.LblSaludo.Size = new System.Drawing.Size(174, 21);
            this.LblSaludo.TabIndex = 1;
            this.LblSaludo.Text = "Soy {nombre} {apellido}";
            this.LblSaludo.Click += new System.EventHandler(this.LblSaludo_Click);
            // 
            // FrmSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 223);
            this.Controls.Add(this.LblSaludo);
            this.Controls.Add(this.LblIntroduccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaludar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIntroduccion;
        private System.Windows.Forms.Label LblSaludo;
    }
}

