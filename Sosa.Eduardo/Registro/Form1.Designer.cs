
namespace Registro
{
    partial class FrmRegistro
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
            this.GrbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.LbEdad = new System.Windows.Forms.Label();
            this.NumericEdad = new System.Windows.Forms.NumericUpDown();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.LbDirección = new System.Windows.Forms.Label();
            this.TxDireccion = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.GrbGenero = new System.Windows.Forms.GroupBox();
            this.RbNoBinario = new System.Windows.Forms.RadioButton();
            this.RbFemenino = new System.Windows.Forms.RadioButton();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.GrbCursos = new System.Windows.Forms.GroupBox();
            this.ChBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.ChBoxCPlus = new System.Windows.Forms.CheckBox();
            this.ChBoxCsharp = new System.Windows.Forms.CheckBox();
            this.ListBoxPais = new System.Windows.Forms.ListBox();
            this.LbPais = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.GrbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEdad)).BeginInit();
            this.GrbGenero.SuspendLayout();
            this.GrbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDetallesUsuario
            // 
            this.GrbDetallesUsuario.Controls.Add(this.LbEdad);
            this.GrbDetallesUsuario.Controls.Add(this.NumericEdad);
            this.GrbDetallesUsuario.Controls.Add(this.TxNombre);
            this.GrbDetallesUsuario.Controls.Add(this.LbDirección);
            this.GrbDetallesUsuario.Controls.Add(this.TxDireccion);
            this.GrbDetallesUsuario.Controls.Add(this.LbNombre);
            this.GrbDetallesUsuario.Location = new System.Drawing.Point(12, 30);
            this.GrbDetallesUsuario.Name = "GrbDetallesUsuario";
            this.GrbDetallesUsuario.Size = new System.Drawing.Size(217, 177);
            this.GrbDetallesUsuario.TabIndex = 0;
            this.GrbDetallesUsuario.TabStop = false;
            this.GrbDetallesUsuario.Text = "Detalles del usuario";
            // 
            // LbEdad
            // 
            this.LbEdad.AutoSize = true;
            this.LbEdad.Location = new System.Drawing.Point(6, 123);
            this.LbEdad.Name = "LbEdad";
            this.LbEdad.Size = new System.Drawing.Size(33, 15);
            this.LbEdad.TabIndex = 4;
            this.LbEdad.Text = "Edad";
            // 
            // NumericEdad
            // 
            this.NumericEdad.Location = new System.Drawing.Point(69, 121);
            this.NumericEdad.Name = "NumericEdad";
            this.NumericEdad.Size = new System.Drawing.Size(126, 23);
            this.NumericEdad.TabIndex = 1;
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(69, 26);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(126, 23);
            this.TxNombre.TabIndex = 0;
            this.TxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LbDirección
            // 
            this.LbDirección.AutoSize = true;
            this.LbDirección.Location = new System.Drawing.Point(6, 74);
            this.LbDirección.Name = "LbDirección";
            this.LbDirección.Size = new System.Drawing.Size(57, 15);
            this.LbDirección.TabIndex = 3;
            this.LbDirección.Text = "Dirección";
            // 
            // TxDireccion
            // 
            this.TxDireccion.Location = new System.Drawing.Point(69, 71);
            this.TxDireccion.Name = "TxDireccion";
            this.TxDireccion.Size = new System.Drawing.Size(126, 23);
            this.TxDireccion.TabIndex = 5;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(6, 34);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(51, 15);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "Nombre";
            // 
            // GrbGenero
            // 
            this.GrbGenero.Controls.Add(this.RbNoBinario);
            this.GrbGenero.Controls.Add(this.RbFemenino);
            this.GrbGenero.Controls.Add(this.RbMasculino);
            this.GrbGenero.Location = new System.Drawing.Point(275, 30);
            this.GrbGenero.Name = "GrbGenero";
            this.GrbGenero.Size = new System.Drawing.Size(148, 106);
            this.GrbGenero.TabIndex = 1;
            this.GrbGenero.TabStop = false;
            this.GrbGenero.Text = "Género";
            this.GrbGenero.Enter += new System.EventHandler(this.GrbGenero_Enter);
            // 
            // RbNoBinario
            // 
            this.RbNoBinario.AutoSize = true;
            this.RbNoBinario.Location = new System.Drawing.Point(21, 76);
            this.RbNoBinario.Name = "RbNoBinario";
            this.RbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.RbNoBinario.TabIndex = 4;
            this.RbNoBinario.TabStop = true;
            this.RbNoBinario.Text = "No binario";
            this.RbNoBinario.UseVisualStyleBackColor = true;
            this.RbNoBinario.Click += new System.EventHandler(this.RbNoBinario_Click);
            // 
            // RbFemenino
            // 
            this.RbFemenino.AutoSize = true;
            this.RbFemenino.Location = new System.Drawing.Point(21, 51);
            this.RbFemenino.Name = "RbFemenino";
            this.RbFemenino.Size = new System.Drawing.Size(78, 19);
            this.RbFemenino.TabIndex = 3;
            this.RbFemenino.TabStop = true;
            this.RbFemenino.Text = "Femenino";
            this.RbFemenino.UseVisualStyleBackColor = true;
            this.RbFemenino.Click += new System.EventHandler(this.RbFemenino_Click);
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Location = new System.Drawing.Point(21, 26);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(80, 19);
            this.RbMasculino.TabIndex = 2;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            this.RbMasculino.Click += new System.EventHandler(this.RbMasculino_Click);
            // 
            // GrbCursos
            // 
            this.GrbCursos.Controls.Add(this.ChBoxJavaScript);
            this.GrbCursos.Controls.Add(this.ChBoxCPlus);
            this.GrbCursos.Controls.Add(this.ChBoxCsharp);
            this.GrbCursos.Location = new System.Drawing.Point(275, 153);
            this.GrbCursos.Name = "GrbCursos";
            this.GrbCursos.Size = new System.Drawing.Size(148, 136);
            this.GrbCursos.TabIndex = 0;
            this.GrbCursos.TabStop = false;
            this.GrbCursos.Text = "Cursos";
            // 
            // ChBoxJavaScript
            // 
            this.ChBoxJavaScript.AutoSize = true;
            this.ChBoxJavaScript.Location = new System.Drawing.Point(21, 89);
            this.ChBoxJavaScript.Name = "ChBoxJavaScript";
            this.ChBoxJavaScript.Size = new System.Drawing.Size(78, 19);
            this.ChBoxJavaScript.TabIndex = 2;
            this.ChBoxJavaScript.Text = "JavaScript";
            this.ChBoxJavaScript.UseVisualStyleBackColor = true;
            this.ChBoxJavaScript.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ChBoxCPlus
            // 
            this.ChBoxCPlus.AutoSize = true;
            this.ChBoxCPlus.Location = new System.Drawing.Point(21, 54);
            this.ChBoxCPlus.Name = "ChBoxCPlus";
            this.ChBoxCPlus.Size = new System.Drawing.Size(50, 19);
            this.ChBoxCPlus.TabIndex = 1;
            this.ChBoxCPlus.Text = "C++";
            this.ChBoxCPlus.UseVisualStyleBackColor = true;
            this.ChBoxCPlus.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ChBoxCsharp
            // 
            this.ChBoxCsharp.AutoSize = true;
            this.ChBoxCsharp.Location = new System.Drawing.Point(21, 22);
            this.ChBoxCsharp.Name = "ChBoxCsharp";
            this.ChBoxCsharp.Size = new System.Drawing.Size(41, 19);
            this.ChBoxCsharp.TabIndex = 0;
            this.ChBoxCsharp.Text = "C#";
            this.ChBoxCsharp.UseVisualStyleBackColor = true;
            // 
            // ListBoxPais
            // 
            this.ListBoxPais.FormattingEnabled = true;
            this.ListBoxPais.ItemHeight = 15;
            this.ListBoxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.ListBoxPais.Location = new System.Drawing.Point(12, 252);
            this.ListBoxPais.Name = "ListBoxPais";
            this.ListBoxPais.Size = new System.Drawing.Size(217, 109);
            this.ListBoxPais.TabIndex = 2;
            // 
            // LbPais
            // 
            this.LbPais.AutoSize = true;
            this.LbPais.Location = new System.Drawing.Point(12, 226);
            this.LbPais.Name = "LbPais";
            this.LbPais.Size = new System.Drawing.Size(28, 15);
            this.LbPais.TabIndex = 6;
            this.LbPais.Text = "País";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(287, 309);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(136, 35);
            this.BtnIngresar.TabIndex = 7;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 377);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LbPais);
            this.Controls.Add(this.ListBoxPais);
            this.Controls.Add(this.GrbCursos);
            this.Controls.Add(this.GrbGenero);
            this.Controls.Add(this.GrbDetallesUsuario);
            this.Name = "FrmRegistro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.GrbDetallesUsuario.ResumeLayout(false);
            this.GrbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEdad)).EndInit();
            this.GrbGenero.ResumeLayout(false);
            this.GrbGenero.PerformLayout();
            this.GrbCursos.ResumeLayout(false);
            this.GrbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetallesUsuario;
        private System.Windows.Forms.Label LbEdad;
        private System.Windows.Forms.NumericUpDown NumericEdad;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label LbDirección;
        private System.Windows.Forms.TextBox TxDireccion;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.GroupBox GrbGenero;
        private System.Windows.Forms.RadioButton RbNoBinario;
        private System.Windows.Forms.RadioButton RbFemenino;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.GroupBox GrbCursos;
        private System.Windows.Forms.CheckBox ChBoxJavaScript;
        private System.Windows.Forms.CheckBox ChBoxCPlus;
        private System.Windows.Forms.CheckBox ChBoxCsharp;
        private System.Windows.Forms.ListBox ListBoxPais;
        private System.Windows.Forms.Label LbPais;
        private System.Windows.Forms.Button BtnIngresar;
    }
}

