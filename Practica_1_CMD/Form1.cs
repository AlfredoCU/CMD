using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace tetris_cs
{
    public partial class Form1 : Form
    {
        // Puntuación.
        private int score = 0;

        // Música.
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        // Configura manejadores.
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
            this.Button1.Click += Button1_Click;
            this.game.IncrementScore += game_IncrementScore;
            this.game.ShapeChanged += game_ShapeChanged;
            // Música a reproducir.
            player.URL = "Tetris.mp3";
            player.controls.stop();
            // Detener música.
            this.cbPausar.Enabled = false;
            this.cbPausar.Checked = false;
        }

        // Configura DGV.
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1; x <= 20; x++)
            {
                game.Columns.Add(new DataGridViewTextBoxColumn());
                game.Columns[x - 1].Width = 15;
                if (x < 7)
                {
                    shapePreview1.Columns.Add(new DataGridViewTextBoxColumn());
                    shapePreview1.Columns[x - 1].Width = 15;
                }
            }
            shapePreview1.Rows.Add(6);
            game.Rows.Add(30);
            for (int x = 1; x <= 30; x++)
            {
                game.Rows[x - 1].Height = 15;
                if (x < 7)
                {
                    shapePreview1.Rows[x - 1].Height = 15;
                }
            }
        }

        // Elimina el foco de los DGV.
        private void Form1_Shown(object sender, EventArgs e)
        {
            shapePreview1.CurrentCell = null;
            shapePreview1.ShowCellToolTips = false;
            game.CurrentCell = null;
            game.ShowCellToolTips = false;
        }

        // Inicia un nuevo juego.
        private void Button1_Click(object sender, EventArgs e)
        {
            score = 0;
            player.controls.play();
            this.cbPausar.Enabled = true;
            this.cbPausar.Checked = true;
            lblScore.Text = score.ToString("000000");
            game.newGame();
        }

        // Aumenta la puntuación y actualiza la visualización de la puntuación.
        private void game_IncrementScore(int newPoints)
        {
            score += newPoints;
            lblScore.Text = score.ToString("000000");
        }

        // Actualiza la vista previa de la pieza.
        private void game_ShapeChanged(Point[] shapePoints, string shapeColor)
        {
            Point[] pts = (Point[])shapePoints.Clone();
            for (int y = 0; y <= 5; y++)
            {
                for (int x = 0; x <= 5; x++)
                {
                    shapePreview1.Rows[y].Cells[x].Style.BackColor = Color.White;
                }
            }
            int minX = pts.Min((p) => p.X);
            int minY = pts.Min((p) => p.Y);
            for (int x = 0; x <= pts.GetUpperBound(0); x++)
            {
                pts[x].Offset(-minX, -minY);
            }
            int w = pts.Max((p) => p.X) - pts.Min((p) => p.X);
            int h = pts.Max((p) => p.Y) - pts.Min((p) => p.Y);
            int offSetX = Convert.ToInt32(Math.Floor((6 - w) / 2.0));
            int offSetY = Convert.ToInt32(Math.Floor((6 - h) / 2.0));
            Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                {"R", Color.Red},
                {"G", Color.Green},
                {"B", Color.Blue},
                {"Y", Color.Yellow}
            };
            for (int x = 0; x <= pts.GetUpperBound(0); x++)
            {
                pts[x].Offset(offSetX, offSetY);
                shapePreview1.Rows[pts[x].Y].Cells[pts[x].X].Style.BackColor = colors[shapeColor];
            }
            game.Focus();
            game.CurrentCell = null;
        }

        // Detener música.
        private void cbPausar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPausar.Checked == true)
            {
                player.controls.play();
            }
            else
            {
                player.controls.stop();
            }
        }

        // Validar la salida.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Validar un cierre.
            player.controls.stop();
        }
    }
}