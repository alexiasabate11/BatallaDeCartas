using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Baraja
    {
        public List<Carta> cartas = new List<Carta>();

        static Random random = new Random();
        public Baraja() { }

        public List<Carta> Cartas
        {
            get { return cartas; }
            set { this.cartas = value; }
        }

        public List<Carta> CrearBaraja()
        {
            for (int i = 1; i <= 4; i++) 
            {
                for (int j = 1; j <= 12; j++)
                {
                    Carta carta = new Carta(j, (Carta.ePalos)i);
                    cartas.Add(carta);
                }
            }
            return cartas;
        }

        public List<Jugador> RepartirCartas(int numeroJugadores)
        {
            Jugador jugador = new Jugador();
            // Calcular cuántas cartas le tocan a cada jugador
            int numeroCartasJugador = cartas.Count() / numeroJugadores;

            for (int i = 0; i < numeroCartasJugador * numeroJugadores; i++)
            {
                // Asignamos una carta al jugador correspondiente (en forma circular)
                jugador.jugadores[i % numeroJugadores].cartasJugador.Add(cartas[i]);
            }

            // Si hay cartas sobrantes, las eliminamos (opcional)
            if (cartas.Count > numeroCartasJugador * numeroJugadores)
            {
                cartas.RemoveRange(0, numeroCartasJugador * numeroJugadores);
            }
            return jugador.jugadores;
        }

        public Carta RobarCarta(List<Carta> cartasJugador)
        {
            Carta carta = cartasJugador.First();
            Console.WriteLine(carta.numero+" "+carta.palo.ToString());
            cartas.Remove(carta);
            return carta;
        }

        public List<Carta> Barajar(List<Carta> cartasNoMezcladas)
        {
            cartas.Clear();
            while (cartasNoMezcladas.Count() != 0)
            {
                Carta carta = cartasNoMezcladas[random.Next()];

                cartas.Add(carta);
                cartasNoMezcladas.Remove(carta);
            }

            return cartas;
        }

        public Carta RobarAlAzar()
        {
            Carta carta = cartas[random.Next()];
            Console.WriteLine(carta);

            cartas.Remove(carta);

            return carta;
        }

        public Carta RobarEnPosicionN(int posicionCarta)
        {
            Carta carta = cartas[posicionCarta];
            Console.WriteLine(carta);
            cartas.Remove(carta);

            return carta;
        }
    }
}
