
namespace eje__501HolaWindowsForms
{
    partial class FrmHola
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LbelNombre = new System.Windows.Forms.Label();
            this.LbelApellido = new System.Windows.Forms.Label();
            this.BtnSaludar = new System.Windows.Forms.Button();
            this.lblMateriafavorita = new System.Windows.Forms.Label();
            this.CmbMaterias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(328, 77);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(174, 29);
            this.TxtApellido.TabIndex = 0;
            this.TxtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(58, 77);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(174, 29);
            this.TxtNombre.TabIndex = 1;
            // 
            // LbelNombre
            // 
            this.LbelNombre.AutoSize = true;
            this.LbelNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbelNombre.Location = new System.Drawing.Point(58, 36);
            this.LbelNombre.Name = "LbelNombre";
            this.LbelNombre.Size = new System.Drawing.Size(86, 25);
            this.LbelNombre.TabIndex = 2;
            this.LbelNombre.Text = "Nombre";
            // 
            // LbelApellido
            // 
            this.LbelApellido.AutoSize = true;
            this.LbelApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbelApellido.Location = new System.Drawing.Point(328, 36);
            this.LbelApellido.Name = "LbelApellido";
            this.LbelApellido.Size = new System.Drawing.Size(86, 25);
            this.LbelApellido.TabIndex = 3;
            this.LbelApellido.Text = "Apellido";
            this.LbelApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnSaludar
            // 
            this.BtnSaludar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnSaludar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaludar.Location = new System.Drawing.Point(328, 225);
            this.BtnSaludar.Name = "BtnSaludar";
            this.BtnSaludar.Size = new System.Drawing.Size(174, 36);
            this.BtnSaludar.TabIndex = 4;
            this.BtnSaludar.Text = "Saludar";
            this.BtnSaludar.UseVisualStyleBackColor = false;
            this.BtnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMateriafavorita
            // 
            this.lblMateriafavorita.AutoSize = true;
            this.lblMateriafavorita.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateriafavorita.Location = new System.Drawing.Point(58, 134);
            this.lblMateriafavorita.Name = "lblMateriafavorita";
            this.lblMateriafavorita.Size = new System.Drawing.Size(154, 25);
            this.lblMateriafavorita.TabIndex = 5;
            this.lblMateriafavorita.Text = "Materia favorita";
            // 
            // CmbMaterias
            // 
            this.CmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMaterias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbMaterias.FormattingEnabled = true;
            this.CmbMaterias.Items.AddRange(new object[] {
            "Programacion I",
            "Programacion II"});
            this.CmbMaterias.Location = new System.Drawing.Point(58, 172);
            this.CmbMaterias.Name = "CmbMaterias";
            this.CmbMaterias.Size = new System.Drawing.Size(444, 29);
            this.CmbMaterias.TabIndex = 6;
            // 
            // FrmHola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 273);
            this.Controls.Add(this.CmbMaterias);
            this.Controls.Add(this.lblMateriafavorita);
            this.Controls.Add(this.BtnSaludar);
            this.Controls.Add(this.LbelApellido);
            this.Controls.Add(this.LbelNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LbelNombre;
        private System.Windows.Forms.Label LbelApellido;
        private System.Windows.Forms.Button BtnSaludar;
        private System.Windows.Forms.Label lblMateriafavorita;
        private System.Windows.Forms.ComboBox CmbMaterias;
    }
}

