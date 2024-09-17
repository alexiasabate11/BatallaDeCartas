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
    }
}
