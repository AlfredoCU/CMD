using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Practica_1_CMD
{
    class Hilos
    {
        // Data.
        /* Un delegate es un tipo que representa referencias a métodos con una lista de parámetros determinada y un tipo de valor devuelto.
         * Los delegados pueden usarse para definir métodos callback.
         * Un delegado me permite enviar un método como parámetro a otro método.
         */
        delegate void dele(int vel);
        // ListViewItem.
        ListViewItem pos = new ListViewItem();

        // Piezas;
        //tetris_cs.Shape pb = new tetris_cs.Shape(int num);

        // Iniciar el juego.
        private void newGame()
        {
            Thread[] hilos = new Thread[6];
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i] = new Thread(Metodo);
                hilos[i].Name = "Shape" + i;
                hilos[i].Start();
            }
        }

        // Método a enviar al Hilo.
        public void Metodo()
        {
            int num = 10;
            dele elDelegado = new dele(Mover);

            if (Thread.CurrentThread.Name.Equals("Shape0"))
            {
                elDelegado.Invoke(num);
            }
            else if (Thread.CurrentThread.Name.Equals("Shape1"))
            {
                elDelegado.Invoke(num);
            }
            else if (Thread.CurrentThread.Name.Equals("Shape2"))
            {
                elDelegado.Invoke(num);
            }
            else if (Thread.CurrentThread.Name.Equals("Shape3"))
            {
                elDelegado.Invoke(num);
            }
            else if (Thread.CurrentThread.Name.Equals("Shape4"))
            {
                elDelegado.Invoke(num);
            }
            else if (Thread.CurrentThread.Name.Equals("Shape5"))
            {
                elDelegado.Invoke(num);
            }
            else
            {
                // No hay más hilos.
            }
        }

        // Mover Piezas.
        public void Mover(int velocidad)
        {
            Random rd = new Random();
            int num1, num2, num3, num4, num5, num6;
            int meta = 30; // game.Rows.Add(30);

            for (int i = 0; i < meta; i++)
            {
                num1 = rd.Next(20);
                num2 = rd.Next(20);
                num3 = rd.Next(20);
                num4 = rd.Next(20);
                num5 = rd.Next(20);
                num6 = rd.Next(20);

                // 0-TShape, 1-LShape, 2-JShape, 3-ZShape, 4-SShape, 5-Line, 6-Square
                if (Thread.CurrentThread.Name.Equals("Shape0"))
                {
                    Thread.Sleep(num1);
                }
                else if (Thread.CurrentThread.Name.Equals("Shape1"))
                {
                    Thread.Sleep(num2);
                }
                else if (Thread.CurrentThread.Name.Equals("Shape2"))
                {
                    Thread.Sleep(num3);
                }
                else if (Thread.CurrentThread.Name.Equals("Shape3"))
                {
                    Thread.Sleep(num4);
                }
                else if (Thread.CurrentThread.Name.Equals("Shape4"))
                {
                    Thread.Sleep(num5);
                }
                else if (Thread.CurrentThread.Name.Equals("Shape5"))
                {
                    Thread.Sleep(num6);
                }
                else
                {
                    // No hay más hilos.
                }
            }
        }
    }
}