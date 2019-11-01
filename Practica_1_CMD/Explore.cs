using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_CMD
{
    public partial class Explore : Form
    {
        // Lista de strings.
        List<string> listFile = new List<string>();
        
        // Constructor.
        public Explore()
        {
            InitializeComponent();
        }

        // Explorador de archivos.
        private void Explore_Load(object sender, EventArgs e)
        {
            string ruta = "C:\\Users\\Alfredo\\Desktop\\Practica_1_CMD\\Practica_1_CMD\\bin\\Debug";
            listFile.Clear();
            lvArchivos.Items.Clear();
            foreach (string item in Directory.GetFiles(ruta))
            {
                ilArchivos.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo nombre = new FileInfo(item);
                listFile.Add(nombre.FullName);
                lvArchivos.Items.Add(nombre.Name,ilArchivos.Images.Count - 1);
            }
        }

        // Abrir archivos.
        private void lvArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvArchivos.FocusedItem != null)
            {
                System.Diagnostics.Process.Start(listFile[lvArchivos.FocusedItem.Index]);
            }  
        }
    }
}