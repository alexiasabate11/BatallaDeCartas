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
        public List<Jugador> jugadores;
        public Jugador() { }
        public Jugador(string nombre)
        {
            this.nombre = nombre;
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

        public List<Jugador> CrearJugadores()
        {
            Console.WriteLine("Cuantos jugadores sois? ");
            Int32.TryParse(Console.ReadLine(), out int numeroJugadores);

            int numeroCartasJugador = CalcularNumeroCartasJugador(numeroJugadores);
            Console.WriteLine("NOMBRES DE JUGADORES.");
            Baraja baraja = new Baraja();

            for (int i = 0; i < numeroJugadores; i++)
            {
                Jugador nuevoJugador = new Jugador(NombreJugador());
                jugadores.Add(nuevoJugador);
            }

            if (numeroJugadores == jugadores.Count())
                baraja.cartas.Clear();

            return jugadores;
        }

        public int CalcularNumeroCartasJugador(int numeroJugadores)
        {
            // Instanciamos la baraja
            Baraja baraja = new Baraja();
            List<Carta> cartas = baraja.Cartas; // Obtenemos la lista de cartas

            // Dividimos el número total de cartas por el número de jugadores y descartamos cualquier residuo
            int numeroCartasJugador = cartas.Count() / numeroJugadores;

            return numeroCartasJugador;
        }

        static string NombreJugador()
        {
            Console.WriteLine("Nombre del jugador: ");
            return Console.ReadLine();
        }
    }
}
