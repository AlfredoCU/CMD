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
    public partial class cmd : Form
    {
        // Contructor.
        public cmd()
        {
            InitializeComponent();
        }

        // Vista CMD.
        private void cmd_Load(object sender, EventArgs e)
        {
            dataStatic();
        }

        // Ménu Principal.
        private void TsmiInfo_Click(object sender, EventArgs e)
        {
            Info abrir = new Info();
            abrir.ShowDialog();
        }

        // Color de fuente (Consola).
        private void TsmiColorF_Click(object sender, EventArgs e)
        {
            var cFont = cdColorFC.ShowDialog();
            if (cFont == DialogResult.OK)
            {
                rtbConsola.ForeColor = cdColorFC.Color;
            }
        }

        // Color de fondo (Consola).
        private void TsmiColorC_Click(object sender, EventArgs e)
        {
            var cConsole = cdColorFC.ShowDialog();
            if(cConsole == DialogResult.OK)
            {
                rtbConsola.BackColor = cdColorFC.Color;
            }
        }

        // Formato de letra.
        private void TsmiFor_Click(object sender, EventArgs e)
        {
            var vFont = fdFormato.ShowDialog();
            if( vFont == DialogResult.OK)
            {
                rtbConsola.Font = fdFormato.Font;
            }
        }

        // Acerca del CMD.
        private void TsmiCMD_Click(object sender, EventArgs e)
        {
            string mensaje = "Símbolo del sistema (CMD). \n\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Salir del sistema.
        private void TsmiSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar Símbolo del sistema (CMD)?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        // Salir de la aplicación y detener proceso.
        private void cmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Iniciar proceso (cmd.exe).
        public string Command (string command)
        {
            // Indicamos que deseamos inicializar el proceso cmd.exe junto al comando de arranque.
            // /C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el procesos.

            // Para más información consulte la ayuda de la consola con cmd.exe
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + command);

            // Indicamos que la salida del proceso de redireccione en un Stream.
            start.RedirectStandardOutput = true;
            start.UseShellExecute = false;

            // Indica el proceso no despliegue una pantalla negra.
            start.CreateNoWindow = false;

            // Inicializa el proceso.
            System.Diagnostics.Process pro = new System.Diagnostics.Process();
            pro.StartInfo = start;
            pro.Start();

            // Consigue la salida de la consola y devuelve una cadena de texto.
            string result = pro.StandardOutput.ReadToEnd();

            // Muestra en pantalla la salida del comando.
            return result;
        }

        // Se imprime un encabezado de inicio.
        public void dataStatic()
        {
            string data1 = "Símbolo del sistema (CMD). Versión 1.0\n";
            string data2 = "Sistema de comandos de windows.\n\n";
            string data3 = "******************************************\n> ";
            this.rtbConsola.Text = (data1 + data2 + data3);
            this.rtbConsola.SelectionStart = this.rtbConsola.Text.Length;
        }

        // Se escribre los comandos.
        private void rtbConsola_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                string tode = this.rtbConsola.Text;
                string[] comandite = tode.Split('>');
                int last = comandite.Length;
                string result = Command(comandite[last - 1]);
                this.rtbConsola.Text = result + "\n> ";
                this.rtbConsola.SelectionStart = this.rtbConsola.Text.Length - 1;
            }
        }
    }
}
