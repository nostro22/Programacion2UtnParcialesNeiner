using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje__501HolaWindowsForms
{
    public partial class FrmHola : Form
    {
        public FrmHola()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtApellido.Text) && !string.IsNullOrEmpty(TxtNombre.Text))
            {
                Form S = new Saludo.FrmSaludar(TxtApellido.Text, TxtNombre.Text, CmbMaterias.Text);
                S.ShowDialog();
            }
            else
            {
                StringBuilder mensajeError = new StringBuilder("Se deben Completar los siguientes campos:");
                if (String.IsNullOrEmpty(TxtNombre.Text))
                {
                    mensajeError.Append("\nNombre");
                }
                if (String.IsNullOrEmpty(TxtApellido.Text))
                {
                    mensajeError.Append("\nApellido");
                }
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHola_Load(object sender, EventArgs e)
        {
            CmbMaterias.SelectedIndex = 0;
        }
    }
}
