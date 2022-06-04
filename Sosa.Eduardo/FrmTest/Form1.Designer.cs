
namespace FrmTest
{
    partial class TesterAPP_SosaEduardo2A
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
            this.BtnVender = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lisStock = new System.Windows.Forms.ListBox();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(24, 360);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(230, 23);
            this.BtnVender.TabIndex = 0;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver Informe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(24, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lisStock
            // 
            this.lisStock.FormattingEnabled = true;
            this.lisStock.ItemHeight = 15;
            this.lisStock.Location = new System.Drawing.Point(24, 12);
            this.lisStock.Name = "lisStock";
            this.lisStock.Size = new System.Drawing.Size(230, 334);
            this.lisStock.TabIndex = 0;
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(278, 12);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(390, 429);
            this.rtbInforme.TabIndex = 1;
            this.rtbInforme.Text = "";
            // 
            // TesterAPP_SosaEduardo2A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.lisStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnVender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TesterAPP_SosaEduardo2A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester APP de Sosa Eduardo 2A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TesterAPP_SosaEduardo2A_FormClosing);
            this.Load += new System.EventHandler(this.TesterAPP_SosaEduardo2A_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lisStock;
        private System.Windows.Forms.RichTextBox rtbInforme;
    }
}

