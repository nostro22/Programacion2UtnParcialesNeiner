using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO;

namespace NotePadProyect
{
    public partial class FrmNotePad : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;       
        private string ultimoArchivo;
        private puntoJson<string> puntoJson;
        private PuntoXml<string> puntoXml;
        private PuntoTxt puntoTxt;

        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }

        public FrmNotePad()
        {
            InitializeComponent();

            puntoJson = new puntoJson<string>();
            puntoXml = new PuntoXml<string>();
            puntoTxt = new PuntoTxt();

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
        }

        private void rtxContenido_TextChanged(object sender, EventArgs e)
        {
            strpStatusLabelCaracteres.Text = $"{rtxContenido.Text.Length} caracteres";
        }
        

      

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                    UltimoArchivo = openFileDialog.FileName;
                try
                {
                    switch (Path.GetExtension(UltimoArchivo))
                    {
                        case ".json":
                          rtxContenido.Text =  puntoJson.Leer(ultimoArchivo);
                            break;
                        case ".xml":
                            rtxContenido.Text = puntoXml.Leer(ultimoArchivo);
                            break;
                        case ".txt":
                            rtxContenido.Text = puntoTxt.Leer(ultimoArchivo);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
        }

        private void FrmNotePad_Load(object sender, EventArgs e)
        {
            strpStatusLabelCaracteres.Text = "0 Caracteres";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(UltimoArchivo))
            {
                GuardarComo();
            }
            else
            {
                Guardar();

            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void GuardarArchivo()
        {
            try
            {
                switch (Path.GetExtension(ultimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(ultimoArchivo, rtxContenido.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(ultimoArchivo, rtxContenido.Text);
                        break;
                    case ".txt":
                        puntoTxt.Guardar(ultimoArchivo, rtxContenido.Text);
                        break;
                }
            }
            
            catch(Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }
        private void GuardarComo()
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();            

            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.GuardarComo(UltimoArchivo, rtxContenido.Text);
                        break;
                    case ".xml":
                        puntoXml.GuardarComo(UltimoArchivo, rtxContenido.Text);
                        break;
                    case ".txt":
                        puntoTxt.GuardarComo(UltimoArchivo, rtxContenido.Text);
                        break;
                }
            }

            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void Guardar()
        {           
            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(UltimoArchivo, rtxContenido.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(UltimoArchivo, rtxContenido.Text);
                        break;
                    case ".txt":
                        puntoTxt.Guardar(UltimoArchivo, rtxContenido.Text);
                        break;
                }
            }

            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }

}
