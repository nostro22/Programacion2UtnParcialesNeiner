using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Supermercado
{
    public partial class FrmVistaSuper : Form
    {
        private List<string> listaSuperMercado;
        private static string rutaArchivo;


        static FrmVistaSuper()
        {
            string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string nombreArchivo = "ListaSupermercado.xml";
            rutaArchivo = Path.Combine(applicationData, nombreArchivo);
        }

        public FrmVistaSuper()
        {
            InitializeComponent();            
        }

        private void GuardarDatos()
        {

            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSuperMercado.GetType());
                xmlSerializer.Serialize(streamWriter, listaSuperMercado);
            }
        }

        private void GuardarDatosComo()
        {

            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSuperMercado.GetType());
                xmlSerializer.Serialize(streamWriter, listaSuperMercado);
            }
        }

        private void RecuperarDatos()
        {

            using (StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSuperMercado.GetType());
                listaSuperMercado = xmlSerializer.Deserialize(streamReader) as List<string>;
            }
        }
        private string ObtenerObjetoSelecionado()
        {
            string objetoSelecionado = lstObjeto.SelectedItem as string;
            if (objetoSelecionado is null)
            {
                MessageBox.Show("Ningun Objeto Selecionado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return objetoSelecionado;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");

            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                string nuevoObjeto = frmAltaModificacion.Objeto;

                if (listaSuperMercado.Contains(nuevoObjeto))
                {
                    MessageBox.Show("El objeto ya existe", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    listaSuperMercado.Add(nuevoObjeto);
                    GuardarDatos();
                    ActualizarListBox();                
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {          
                listaSuperMercado.Remove(ObtenerObjetoSelecionado());
                GuardarDatos();
                ActualizarListBox();         
                
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            string objetoAModificar = ObtenerObjetoSelecionado();
            int indexObjetoAModificar = listaSuperMercado.IndexOf(objetoAModificar);

            if (objetoAModificar is not null)
            {
                FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", objetoAModificar, "Modificar");

                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    string nuevoObjeto = frmAltaModificacion.Objeto;                   

                    if (listaSuperMercado.Contains(nuevoObjeto))
                    {
                        MessageBox.Show("El objeto ya existe", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        listaSuperMercado[indexObjetoAModificar] = nuevoObjeto;                       
                        GuardarDatos();
                        ActualizarListBox();
                    }
                }
            }
        }


        private void ActualizarListBox()
        {
            lstObjeto.DataSource = null;
            lstObjeto.DataSource = listaSuperMercado;
        }

        private void FrmVistaSuper_Load(object sender, EventArgs e)
        {
            listaSuperMercado = new List<string>();
            if (File.Exists(rutaArchivo))
            {
                RecuperarDatos();
                ActualizarListBox();
            }
           
        }
    }
}
