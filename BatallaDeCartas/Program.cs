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

        static void Main(string[] args)
        {
            Console.WriteLine("BATALLA DE CARTAS");
            int numeroJugadores = NumeroJugadores();
            int numeroCartasJugador;
            if (cartas.Count() % numeroJugadores == 0)
                numeroCartasJugador = cartas.Count() / numeroJugadores;
            else
                numeroCartasJugador = (cartas.Count() - (cartas.Count() % numeroJugadores)) / numeroJugadores;

            cartas = Barajar(cartas);
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

            carta = cartasNoMezcladas[random.Next()];

            cartas.Add(carta);
            cartasNoMezcladas.Remove(carta);

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

        static int NumeroJugadores()
        {
            Console.WriteLine("Cuantos jugadores sois? ");
            Int32.TryParse(Console.ReadLine(), out int numeroJugadores);
            return numeroJugadores;
        }
    }
}
