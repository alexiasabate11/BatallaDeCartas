using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Baraja
    {
        List<Carta> cartas = new List<Carta>();

        public Baraja() 
        {
            CrearBaraja();
        }

        public void CrearBaraja() 
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    Carta carta = new Carta(j , i);
                    cartas.Add(carta);
                }
            }
        }

        public List<Carta> Cartas
        {
            get { return cartas; }
            set { this.cartas = value; }
        }
    }
}
