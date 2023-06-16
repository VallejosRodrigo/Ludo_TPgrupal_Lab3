using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_TPgrupal_Lab3
{
    internal class Jugador
    {
        private int puntos;
        

        public Jugador(int puntos)
        {
            Puntos = puntos;
        }

        public int Puntos { get => puntos; set => puntos = value; }
    }
}
