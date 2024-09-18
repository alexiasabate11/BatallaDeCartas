using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace BatallaDeCartas
{
    internal class Program
    {
        static Carta carta = new Carta();
        static Baraja baraja = new Baraja();
        static Random random = new Random();  
        static List<Carta> cartas = baraja.Cartas;
        static Jugador jugador = new Jugador();
        static List<Jugador> jugadoresAll = new List<Jugador>();

        static void Main(string[] args)
        {
            CrearPartida();

        }

        static void CrearPartida()
        {
            
            Barajar(cartas);
            Console.WriteLine("BATALLA DE CARTAS");
            CrearJugadores();
        }

        static string NombreJugador()
        {
            Console.WriteLine("Nombre del jugador: ");
            return Console.ReadLine();
        }

        static int NumeroJugadores()
        {
            Console.WriteLine("Cuantos jugadores sois? ");
            Int32.TryParse(Console.ReadLine(), out int numeroJugadores);

            return numeroJugadores;
        }

        static int CalcularNumeroCartasJugador(int numeroJugadores)
        {
            int numeroCartasJugador;

            if (cartas.Count() % numeroJugadores == 0)
                numeroCartasJugador = cartas.Count() / numeroJugadores;
            else
                numeroCartasJugador = (cartas.Count() - (cartas.Count() % numeroJugadores)) / numeroJugadores;

            return numeroCartasJugador;
        }

        static void CrearJugadores()
        {
            int numeroJugadores = NumeroJugadores();

            int numeroCartasJugador = CalcularNumeroCartasJugador(numeroJugadores);
            Console.WriteLine("NOMBRES DE JUGADORES.");

            for (int i = 0; i < numeroJugadores; i++)
            {
                string nombreJugador = NombreJugador();
                Jugador nuevoJugador = new Jugador(nombreJugador, RepartirCartas(numeroCartasJugador));
                jugadoresAll.Add(nuevoJugador);
            }

            if (numeroJugadores == jugadoresAll.Count())
                cartas.Clear();
        }

        static List<Carta> RepartirCartas(int numeroCartasJugador)
        {
            List<Carta> cartasJugador = null;

            for (int i = 0; i < numeroCartasJugador; i++)
            {
                Carta cartaActual = cartas[i];
                cartasJugador.Add(cartaActual);
                cartas.Remove(cartaActual);
            }

            return cartasJugador;
        }

        static void RobarCarta() 
        {
            carta = cartas.First();
            Console.WriteLine(carta);
            cartas.Remove(carta);
        }

        static List<Carta> Barajar(List<Carta> cartasNoMezcladas)
        {
            cartas.Clear();
            while (cartasNoMezcladas.Count() != 0)
            {
                carta = cartasNoMezcladas[random.Next()];

                cartas.Add(carta);
                cartasNoMezcladas.Remove(carta);
            }

            return cartas;
        }

        static Carta RobarAlAzar()
        {
            carta = cartas[random.Next()];
            Console.WriteLine(carta);

            cartas.Remove(carta);

            return carta;
        }

        static Carta RobarEnPosicionN(int posicionCarta)
        {
            carta = cartas[posicionCarta];
            Console.WriteLine(carta);
            cartas.Remove(carta);

            return carta;
        }
    }
}
