using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPPLibreria;

namespace FrmTest
{
    public partial class TesterAPP_SosaEduardo2A : Form
    {

        private Vendedor vendedor;
        public TesterAPP_SosaEduardo2A()
        {
            InitializeComponent();
            vendedor = new Vendedor("Don Carpincho");
        }

        private void TesterAPP_SosaEduardo2A_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lisStock.Items.Add(p1.toString());
            lisStock.Items.Add(p2.toString());
            lisStock.Items.Add(p3.toString());
            lisStock.Items.Add(p4.toString());
            lisStock.Items.Add(p5.toString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TesterAPP_SosaEduardo2A_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Closing Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = lisStock.SelectedItem as Publicacion;

            if (publicacion is not null)
            {
                if (vendedor + publicacion)
                {
                    MessageBox.Show("Venta exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La venta no pudo realizarse por falta de stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
        }
    }
}
