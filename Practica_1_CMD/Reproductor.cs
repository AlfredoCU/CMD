using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_CMD
{
    public partial class Reproductor : Form
    {
        int count = 0;
        string countText = "";
        string[] archivosMP3;
        string[] rutasArchivosMP3;

        public Reproductor()
        {
            InitializeComponent();
        }

        // Almacenar archivos de música.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog formBusqueda = new OpenFileDialog(); // Se crea una instancia de la clase OpenFileDialog abre una venta de búqueda de archivos.
            formBusqueda.Multiselect = true; // Se activa que la ventana se seleccione varios archivos.
            if (formBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK) // Si el formulario recibe un OK entonces.
            {
                count = 0; // Limpiamos contador.
                this.lbMusica.Items.Clear(); // Limpiamos la lista.
                archivosMP3 = formBusqueda.SafeFileNames; // Almacena nombre del archivo al atributo "archivoMP3".
                rutasArchivosMP3 = formBusqueda.FileNames; // Almacena el url del archivo al atributo "rutaArchivoMP3".
                foreach (var archivo in archivosMP3)
                {
                    countText = Convert.ToString(count++);
                    this.lbMusica.Items.Add(countText+ " | 🎧 " + archivo); // Itera los archivos y los agrega a la ListBox.
                }
                wmpMusica.URL = rutasArchivosMP3[0]; // Le enviamos al Windows Media Player la música seleccionada.
                this.lbMusica.SelectedIndex = 0; // Primer elemento que se encuentre en la posición 0 de la lista, es el primer elemento que se reproducir.
            }
        }

        // Reproducir el elemento seleccionado.
        private void lbMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmpMusica.URL = rutasArchivosMP3[this.lbMusica.SelectedIndex]; // Le envias la url del archivo que selecciones.
        }

        // Detener Windows Media Player al salir del Form (Reproductor).
        private void Reproductor_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmpMusica.close(); // Detiene el proceso.
        }
    }
}
