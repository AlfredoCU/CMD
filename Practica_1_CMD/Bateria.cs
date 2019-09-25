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
    public partial class Bateria : Form
    {
        public Bateria()
        {
            InitializeComponent();
            InfoBateria();
        }

        public void InfoBateria()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            // Obtiene el estado actual de carga de la batería. Alto, cargando y bajo.
            this.rtbInfo.Text = status.BatteryChargeStatus.ToString();
            // Obtiene el estado actual de energía del sistema.
            switch (status.PowerLineStatus)
            {
                case (PowerLineStatus.Online):
                    this.rtbInfo.Text += "\nComputadora conectada";
                    break;
                case (PowerLineStatus.Offline):
                    this.rtbInfo.Text += "\nComputadora no conectada";
                    break;
                default:
                    this.rtbInfo.Text += "\nNo hay información al respecto";
                    break;
            }
            // Obtiene la cantidad aproximada de carga de batería completa restante.
            this.rtbInfo.Text += "\n" + status.BatteryLifePercent.ToString("P0");
            // Obtiene el número aproximado de segundos de batería restante.
            // this.rtbInfo.Text += "\n" + status.BatteryLifeRemaining.ToString();
        }
    }
}
