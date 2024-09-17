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
        public ePalos epalos;

        public Carta() { }

        public Carta(int numero, int palos)
        {
            this.numero = numero;
            this.epalos = asociarPalos(palos);
        }
        
        public ePalos asociarPalos(int palos)
        {
            switch (palos)
            {
                case 1:
                    this.epalos = ePalos.Oros;
                    break;
                case 2:
                    this.epalos = ePalos.Copas;
                    break;
                case 3:
                    this.epalos = ePalos.Espadas;
                    break;
                case 4:
                    this.epalos = ePalos.Bastos;
                    break;
            }

            return epalos;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public ePalos Epalos
        {
            get => epalos;
            set => epalos = value;
        }

        public void MostrarCarta(Carta carta)
        {
            Console.WriteLine(carta.numero+""+carta.epalos);
        }
    }
}
