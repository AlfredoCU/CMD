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
using tetris_cs;

namespace Practica_1_CMD
{
    public partial class Inicio : Form
    {
        // Clase para la batería.
        PowerStatus status = SystemInformation.PowerStatus;

        // Constructor.
        public Inicio()
        {
            InitializeComponent();
        }

        // Inicio.
        private void cmd_Load(object sender, EventArgs e)
        {
            BateriaTxt();
            this.tDate.Enabled = true;
        }

        // Ver Explorador de archivos.
        private void TsmiDocumentos_Click(object sender, EventArgs e)
        {
            Doc abrir = new Doc();
            abrir.MdiParent = this;
            abrir.Show();
        }

        // Juegos.
        private void TsmiTetris_Click(object sender, EventArgs e)
        {
            tetris_cs.Form1 abrir = new tetris_cs.Form1();
            abrir.MdiParent = this;
            abrir.Show();
        }

        // Ver Descarga de archivos.
        private void TsmiDescargar_Click(object sender, EventArgs e)
        {
            Descargar abrir = new Descargar();
            abrir.MdiParent = this;
            abrir.Show();
        }

        // Ver CMD.
        private void TsmiCMD_Click(object sender, EventArgs e)
        {
            Cmd abrir = new Cmd();
            abrir.MdiParent = this;
            abrir.Show();
        }

        // Ver Reproductor de Música.
        private void TsmiMPMusica_Click(object sender, EventArgs e)
        {
            Reproductor abrir = new Reproductor();
            abrir.MdiParent = this;
            abrir.Show();
        }

        // Acerca del sistema.
        private void TsmiSistema_Click(object sender, EventArgs e)
        {
            string mensaje = "Windows 10 Home Single Languaje. Intel(R) Core(TM) i5-4210U CPU @ 1.70GHz 2.40GHz";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Ver información de la batería.
        private void tsmiBat_Click(object sender, EventArgs e)
        {
            Bateria abrir = new Bateria();
            abrir.MdiParent = this;
            abrir.Show();
        }

        // Salir del sistema.
        private void TsmiSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        // Hora actual del sistema. 
        public void Date()
        {
            this.lblDate.Text = DateTime.Now.ToString();
        }

        // Batería actual del sistema. 
        public void Bateria()
        {
            this.pbBateria.Value = Convert.ToInt32(status.BatteryLifePercent * 100);
        }

        public void BateriaTxt()
        {
            this.lblBateria.Text = status.BatteryLifePercent.ToString("P0");
        }

        // Batería y fecha en tiempo real.
        private void tDate_Tick(object sender, EventArgs e)
        {
            Date();
            Bateria();
            BateriaTxt();
        }

        // Salir de la aplicación y detener proceso.
        private void cmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}