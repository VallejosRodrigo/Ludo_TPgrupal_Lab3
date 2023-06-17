using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_TPgrupal_Lab3
{
    internal class Dado
    {
       
        public static int lanzarDado()
        {
            Random rand = new Random();
            int numAleatorio = rand.Next(0, 7);

            return numAleatorio;
        }


    }
}
