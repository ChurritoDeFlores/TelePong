using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongFer
{
    internal class JugadorDOS:Jugador
    {
        public JugadorDOS()
        {
            this.Nombre = "Jugador2";
            this.PosX = 503;
            this.PosY = 125;
        }
        public JugadorDOS(int marcador)
        {
            this.Nombre = "Jugador2";
            this.PosX = 503;
            this.PosY = 125;
            this.Marcador = marcador;
        }
    }
}
