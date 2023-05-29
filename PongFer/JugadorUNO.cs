using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongFer
{
    internal class JugadorUNO:Jugador
    {
        public JugadorUNO()
        {
            this.Nombre = "Jugador1";
            this.PosX = 22;
            this.PosY = 125;
        }
        public JugadorUNO(int marcador)
        {
            this.Nombre = "Jugador1";
            this.PosX = 22;
            this.PosY = 125;
            this.Marcador = marcador;
        }
    }
}
