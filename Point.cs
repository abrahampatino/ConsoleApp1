using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Point
    {
        public String origen;
        public String destino;
        public int costo;

        public Point(String origen,String destino, int costo)
        {
            this.origen = origen;
            this.destino = destino;
            this.costo = costo;
        }
    }
}
