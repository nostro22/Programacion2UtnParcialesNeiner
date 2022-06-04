using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIngresante;

namespace Registro
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();        
        }

        private string genero = string.Empty;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrbGenero_Enter(object sender, EventArgs e)
        {

        }

        private void RbMasculino_Click(object sender, EventArgs e)
        {
            RbNoBinario.Checked = false; 
            RbFemenino.Checked = false; 
            RbMasculino.Checked = true;            
        }

        private void RbFemenino_Click(object sender, EventArgs e)
        {
            RbNoBinario.Checked = false;
            RbFemenino.Checked = true;
            RbMasculino.Checked = false;
        }


        private void RbNoBinario_Click(object sender, EventArgs e)
        {
            RbNoBinario.Checked = true;
            RbFemenino.Checked = false;
            RbMasculino.Checked = false;
        }

        private string[] GetCurso()
        {
            String[] cursos= new string[3];
            if (ChBoxCPlus.Checked)
            {
                cursos[0]="C++";
            }
            if (ChBoxCsharp.Checked)
            {
                cursos[1] = "C#";
            }
            if (ChBoxJavaScript.Checked)
            {
                cursos[3] = "JavaString";
            }
            return cursos; 
        }


        private string GetGenero()
        {
            string genero;
            if (RbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (RbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "No Binario";
            }
            return genero;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            
           Ingresante nuevoIngreo = new Ingresante(TxNombre.Text,TxDireccion.Text,GetGenero(),ListBoxPais.Items[ListBoxPais.SelectedIndex].ToString(),GetCurso(),(int)NumericEdad.Value);
            MessageBox.Show(nuevoIngreo.Mostrar());
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            ListBoxPais.SelectedIndex = 0;
        }
    }
}
