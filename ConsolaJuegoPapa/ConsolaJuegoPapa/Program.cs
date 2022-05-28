using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaJuegoPapa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comienza el juego");
            bool ContinuarJuego = true;


            while (ContinuarJuego)
            {
                int DadosRestantes = 5;
                List<int> listaNumeros = new List<int>();

                while (DadosRestantes > 1)
                {
                    listaNumeros.Add(ObtenerNumero());
                }

            }
        }
        static int ObtenerNumero()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
        
    }
}
