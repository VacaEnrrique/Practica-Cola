using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            Console.Write("Digite el numero de personas en la fila: ");
            int n = int.Parse(Console.ReadLine());
            int Fila = n;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nombre: ");
                fila.Enqueue(Console.ReadLine());
            }
            Console.WriteLine("\nEl cajero atendio a:");

            while (Fila > 0)
            {
                Console.WriteLine(fila.Dequeue());
                Fila--;
            }
            Console.ReadKey();
        }
    }
}
