using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Partida
    {
        static List<Jugador> jugadores;
        static Baraja baraja = new Baraja();
        public Partida() 
        {
            CrearPartida();
            Console.ReadKey();
        }

        private void CrearPartida()
        {
            baraja.CrearBaraja(); // Llenar la baraja con cartas al instanciar la clase
            Console.WriteLine("BATALLA DE CARTAS");
            Jugador jugador = new Jugador();
            jugadores = jugador.CrearJugadores(); // Creamos los jugadores

            foreach (Jugador j in jugadores)
                Console.WriteLine(j.nombre+", "+j.cartasJugador.Count());
        }

        public void Ronda()
        {
            do
            {
                Carta cartaMax = new Carta();
                Jugador cartaMaxJugador = new Jugador();
                List<Carta> cartasRonda = new List<Carta>();

                foreach (Jugador jugador in jugadores)
                {
                    Carta cartaJugador = baraja.RobarCarta(jugador.cartasJugador);
                    Console.WriteLine("Jugador: "+jugador.nombre+" => Carta: "+cartaJugador);

                    if (cartaJugador.numero > cartaMax.numero)
                    {
                        cartaMax = jugador.cartasJugador.First();
                        cartaMaxJugador = jugador;
                    }
                    cartasRonda.Add(cartaJugador);
                    jugador.cartasJugador.Remove(cartaJugador);

                    Console.Write("Jugador: " + cartaMaxJugador.nombre + " gana la ronda con la carta '" + cartaMax);

                    foreach (Carta carta in cartasRonda)
                        cartaMaxJugador.cartasJugador.Add(carta);
                }
            } 
            while (HayGanador());
        }

        private Boolean HayGanador()
        {
            foreach(Jugador jugador in jugadores)
            {
                if (jugador.cartasJugador.Count() == 0)
                {
                    Console.WriteLine("Jugador "+jugador.nombre+" eliminado.");
                    jugadores.Remove(jugador);
                }

                if (jugadores.Count() == 1)
                {
                    Console.WriteLine("Jugador " + jugador.nombre + " has ganado.");
                    return true;
                }
            }
            return false;
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
