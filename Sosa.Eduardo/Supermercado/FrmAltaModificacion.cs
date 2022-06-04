using System.Windows.Forms;

namespace Supermercado
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion( string titulo, string textoTextBox, string textoBtnConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjecto.Text = textoTextBox;            
            btnConfirmar.Text = textoBtnConfirmar;
        }

        public string Objeto
        {
            get
            {
                return txtObjecto.Text;
            }        
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            Confirmar();
        }
     

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Cancelar();
        }

        private void txtObjecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 Representa el enter en ascii )
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Cancelar();
            }
        }

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjecto.Text))
            {
                MessageBox.Show("Debe ingresar un texto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
                Close();
            
        }

    }
}
