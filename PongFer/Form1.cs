using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongFer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Botones
        bool arribaJ1 = false; // boton A
        bool abajoJ1 = false; // boton Z
        bool arribaJ2 = false; // boton FlechaArriba
        bool abajoJ2 = false; // boton FlechaAbajo
        Pelota pelota = new Pelota();
        JugadorDOS jugadorDOS = new JugadorDOS();
        JugadorUNO jugadorUNO = new JugadorUNO();
        int totalX =545;
        int totalY =282;
        private void TeclaSoltada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                arribaJ1 = false;
            }
            else if (e.KeyCode == Keys.Z)
            {
                abajoJ1 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                arribaJ2 = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                abajoJ2 = false;
            }
        }

        private void TeclaApretada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                arribaJ1 = true;
            } else if (e.KeyCode == Keys.Z)
            {
                abajoJ1 = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                arribaJ2 = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                abajoJ2 = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.Inicio();
            }
        }

        private void Inicio()
        {
            //Reinicio Botones
            arribaJ1 = false;
            abajoJ1 = false;
            arribaJ2 = false;
            abajoJ2 = false;
            JugadorUNO nuevojugadorUNO = new JugadorUNO(jugadorUNO.Marcador);
            JugadorDOS nuevojugadorDOS = new JugadorDOS(jugadorDOS.Marcador);
            Pelota nuevapelota = new Pelota();
            jugadorUNO = nuevojugadorUNO;
            jugadorDOS = nuevojugadorDOS;
            pelota = nuevapelota;
            //Colocar Jugadores y Pelota en la condicion inicial
            pic_Jugador1.Left = jugadorUNO.PosX;
            pic_Jugador1.Top = jugadorUNO.PosY;
            pic_Jugador2.Left = jugadorDOS.PosX;
            pic_Jugador2.Top = jugadorDOS.PosY;
            pic_Pelota.Left = pelota.PosX;
            pic_Pelota.Top = pelota.PosY;
            // Inicio el Tiempo
            timer_.Start();
        }

        private void timer__Tick(object sender, EventArgs e)
        {
            //Mover Jugador 1
            if (arribaJ1)
            {
                pic_Jugador1.Top -= jugadorUNO.Velocidad;
            } else if (abajoJ1)
            {
                pic_Jugador1.Top += jugadorUNO.Velocidad;
            }
            //Mover Jugador 2
            if (arribaJ2)
            {
                pic_Jugador2.Top -= jugadorDOS.Velocidad;
            } else if (abajoJ2)
            {
                pic_Jugador2.Top += jugadorDOS.Velocidad;
            }
            //Mover Pelota en X
            if (pelota.PosX < 0)
            {
                pelota.CambioX = true;
                jugadorDOS.Marcador++;
                lbl_Anotador2.Text = $"{jugadorDOS.Marcador}";
                this.Inicio();
            }
            if (pelota.PosX > (totalX - pelota.Diametro))
            {
                pelota.CambioX = false;
                jugadorUNO.Marcador++;
                lbl_Anotador1.Text = $"{jugadorUNO.Marcador}";
                this.Inicio();
            }
            if (!pelota.CambioX)
            {
                pic_Pelota.Left -= pelota.Velocidad;
                pelota.PosX = pic_Pelota.Left;
            } else
            {
                pic_Pelota.Left += pelota.Velocidad;
                pelota.PosX = pic_Pelota.Left;
            }
            //Mover Pelota en Y
            if (pelota.PosY < 40)
            {   
                
                pelota.CambioY = true;
            }
            if (pelota.PosY > (totalY + pelota.Diametro))
            {
                pelota.CambioY = false;
            }
            if (!pelota.CambioY)
            {
                
                pic_Pelota.Top -= pelota.Velocidad;
                pelota.PosY = pic_Pelota.Top;
            }
            else
            {
                pic_Pelota.Top += pelota.Velocidad;
                pelota.PosY = pic_Pelota.Top;
            }
            // evento colicion pelota jugador
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    if ((string)item.Tag == jugadorUNO.Nombre)
                    {
                        if (pic_Pelota.Bounds.IntersectsWith(item.Bounds))
                        {
                            pelota.CambioX = true;
                            pelota.Velocidad++;
                        }
                    }
                    if ((string)item.Tag == jugadorDOS.Nombre)
                    {
                        if (pic_Pelota.Bounds.IntersectsWith(item.Bounds))
                        {
                            pelota.CambioX = false;
                            pelota.Velocidad++;

                        }
                    }
                }
            }
            
        }
    }
}
