using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Viaje
    {
        private string[] ini_fin;
        private List<Point> tra;

        public Viaje(string[] ini_fin, string[] tra)
        {
            this.ini_fin = ini_fin;
            this.tra = new List<Point>();
            foreach(String x in tra)
            {
                x.Replace("\r","");
                String [] elem = x.Split(",");
                this.tra.Add(new Point(elem[0], elem[1], Int32.Parse(elem[2])));
            }
            obtainTravel();
        }

        public void obtainTravel()
        {
            String actual_state = ini_fin[0];
            String travel = ini_fin[0];
            int total_cost = 0;
            var states = new List<String>();
            while(true)
            {
                if(actual_state != ini_fin[1])
                {
                    var aux = tra.Where(s => s.origen == actual_state).OrderBy(r => r.costo).First();
                    total_cost = total_cost + aux.costo;
                    travel += " -> " + aux.destino;
                    states.Add(actual_state);
                    actual_state = aux.destino;
                    //if()
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ruta Obtenida: " + travel);
            Console.WriteLine("Costo total: " + total_cost);
        }

    }
}
