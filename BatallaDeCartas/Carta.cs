using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BatallaDeCartas.Carta;

namespace BatallaDeCartas
{
    internal class Carta
    {
        public enum ePalos
        {
            Oros,
            Copas,
            Espadas,
            Bastos
        }
        
        public int numero;
        public ePalos palo;

        public Carta() { }

        public Carta(int numero, ePalos palo)
        {
            this.numero = numero;
            this.palo = palo;
        }
                
        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public ePalos Palo
        {
            get => palo;
            set => palo = value;
        }

        public void MostrarCarta(Carta carta)
        {
            Console.WriteLine(carta.numero+""+carta.palo);
        }
    }
}
