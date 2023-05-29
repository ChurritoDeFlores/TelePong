using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongFer
{
    abstract internal class Jugador
    {
        public string Nombre { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Marcador { get; set; }
        public int Velocidad { get; set; }
        public Jugador()
        {
            this.Marcador = 0; // Arranca con 0 goles
            this.Velocidad = 5; // Velocidad igual para todos los jugadores
        }

    }
}
