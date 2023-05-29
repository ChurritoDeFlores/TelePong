using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongFer
{
    internal class Pelota
    {
        public int Velocidad { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool CambioX { get; set; }
        public bool CambioY { get; set; }
        public int Diametro { get; set; }

        public Pelota()
        {
            this.Velocidad = 2;
            this.PosX = 257;
            this.PosY = 163;
            this.CambioX = false;
            this.CambioY = true;
            this.Diametro = 22;
        }
    }
}
