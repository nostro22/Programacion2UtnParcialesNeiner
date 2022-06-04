using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saludo
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string name, string apellido)
        {
            InitializeComponent();
            LblIntroduccion.Text ="¡Hola, Windows Forms!";
            LblSaludo.Text = new string("Soy " + name + " " + apellido);
        }

        public FrmSaludar(string name, string apellido, string materia)
        {
            InitializeComponent();
            LblIntroduccion.Text = "¡Hola, Windows Forms!";
            LblSaludo.Text = new string("Soy " + name + " " + apellido + " y mi materia favorita es "+materia+".");
        }

        private void LblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}
