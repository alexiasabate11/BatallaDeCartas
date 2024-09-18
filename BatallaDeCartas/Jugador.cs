using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Jugador
    {
        public string nombre;
        public List<Carta> cartasJugador;
        public Jugador() { }
        public Jugador(string nombre, List<Carta> cartasJugador)
        {
            this.nombre = nombre;
            this.cartasJugador = cartasJugador;
        }

        public string Nombre { 
            get 
            { return nombre; } 

            set 
            { nombre = value; }
        }

        public List<Carta> Cartas
        {
            get
            { return cartasJugador; }

            set
            { cartasJugador = value; }
        }
    }
}
