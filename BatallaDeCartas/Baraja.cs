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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Carta carta = new Carta(j, i);
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
