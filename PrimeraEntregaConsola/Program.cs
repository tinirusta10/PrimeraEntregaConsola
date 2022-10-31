using System;

using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEntregaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 73

            //string cadena;

            //Queue<string> ColaStr = new Queue<string>();

            //Console.WriteLine("ingrese una cadena en la cola");
            //cadena = Console.ReadLine();

            //while (cadena != "")
            //{
            //    ColaStr.Enqueue(cadena);
            //    Console.WriteLine("Ingrese una proxima cadena en la cola");
            //    cadena = Console.ReadLine();
            //}

            //while (ColaStr.Count > 0)
            //{
            //    Console.WriteLine(ColaStr.Dequeue());
            //}

            //Console.ReadKey();

            #endregion

            #region 74

            //string cadena;

            //Stack pila = new Stack();

            //Console.WriteLine("ingrese una cadena en la pila");
            //cadena = Console.ReadLine();

            //while (cadena != "")
            //{
            //    pila.Push(cadena);
            //    Console.WriteLine("Ingrese una proxima cadena en la pila");
            //    cadena = Console.ReadLine();
            //}

            //while (pila.Count > 0)
            //{
            //    string dato = (string) pila.Pop();
            //    Console.WriteLine(dato);

            //}

            //{
            //    Console.ReadKey();
            //}

            #endregion

            #region 75
            Console.WriteLine("Ingrese una palabra");
            string palabra;
            int numero;
            ArrayList lista = new ArrayList();
            palabra = Console.ReadLine();

            
            while (palabra != "")
            {
                lista.Add(palabra);
                Console.WriteLine("Ingrese la proxima palabra");
                palabra = Console.ReadLine();
            }
            Console.WriteLine("Ingrese la posición de la palabra que desea");

            numero = Convert.ToInt32(Console.ReadLine());
            while (numero != 0)
            {
                if (numero > lista.Count)
                {
                    Console.WriteLine("Posicion sin datos, ingrese un nuevo dato");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    numero--;
                    Console.WriteLine(lista[numero]);
                    numero = Convert.ToInt32(Console.ReadLine());
                }

            }

            #endregion

        }
    }
}
