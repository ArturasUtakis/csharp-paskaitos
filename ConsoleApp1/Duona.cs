using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Duona
    {
        public string Pavadinimas { get; private set; }
        public double Savikaina { get;private set; }
        public double Kaina { get;private set; }
        public int Kiekis { get;private set; }

        public Duona(string pavadinimas, double savikaina,double kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Savikaina = savikaina;
            Kaina = kaina;
            Kiekis = kiekis;
            
        }
        public void Isvedimas()
        {
            Console.WriteLine("Duona : " + Pavadinimas);
            Console.WriteLine("savikaina ir kaina : {0} eur / {1} eur",Savikaina,Kaina);
            Console.WriteLine("Jos yra: " + Kiekis);
        }
        public double Pelnas()
        {
            return (Kaina - Savikaina) * Kiekis;
        }
        public void Parduoti(int kiek)
        {
            if (Kiekis >= kiek)
            {
                Kiekis -= kiek;
            }
            else
            {
                Console.WriteLine("Nera tiek duonos");
            }
        }
        
    }
}
