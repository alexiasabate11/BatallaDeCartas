using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Baraja
    {
        List<Carta> cartas;

        public Baraja()
        {
            cartas = new List<Carta>();
            CrearBaraja(); // Llenar la baraja con cartas al instanciar la clase
        }

        public List<Carta> CrearBaraja()
        {
            for (int i = 1; i <= 4; i++) 
            {
                for (int j = 1; j <= 12; j++)
                {
                    Carta carta = new Carta(j, i);
                    cartas.Add(carta);
                }
            }
            return cartas;
        }

        public List<Carta> Cartas
        {
            get { return cartas; }
            set { this.cartas = value; }
        }
    }

}
