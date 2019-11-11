using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // Para acceder a la web.

namespace Practica_1_CMD
{
    public partial class Descargar : Form
    {
        // Clase para utilizar métodos para acceder a la web.
        WebClient cliente = new WebClient();

        // Constructor.
        public Descargar()
        {
            InitializeComponent();
            this.btnDescargar.Enabled = false;
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
        }

        // Formulario principal.
        private void Descargar_Load(object sender, EventArgs e)
        {
            // Se produce cuando una operación de descarga asincrónica transfiere con éxito algunos o todos los datos.
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Cargando);
            // Se produce cuando se completa una operación de descarga de archivo asíncrono.
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(Descargando);
        }

        // Validar TextBox
        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (this.txtURL.Text != "")
            {
                this.btnDescargar.Enabled = true;
            }
            else
            {
                this.btnDescargar.Enabled = false;
            }
        }

        // Bóton de descarga.
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog archivo = new SaveFileDialog(); // Abrir ventana para elegir donde guardar el archivo.
            archivo.Filter = "Todos los archivos|*.*"; // Cualquier tipo de archivo.
            archivo.FileName = txtURL.Text.Substring(txtURL.Text.LastIndexOf("/") + 1); // El substring comienza desde el carcter que se le asigne.
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                cliente.DownloadFileAsync(new Uri(txtURL.Text), archivo.FileName);
            }
        }

        // Progreso de descarga.
        private void Cargando(object sender, DownloadProgressChangedEventArgs e)
        {
            pbProgreso.Value = e.ProgressPercentage; // Valor del argumento e.
            lblProgreso.Text = pbProgreso.Value.ToString() + "%";
        }

        // Limpiar valores.
        private void Descargando(object sender, AsyncCompletedEventArgs e)
        {
            this.pbProgreso.Value = 0;
            this.lblProgreso.Text = "0%";
            this.txtURL.Clear();
            this.btnDescargar.Enabled = false;
            MessageBox.Show("Archivo descargado con exito", "Descargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}