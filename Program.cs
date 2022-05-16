using System;
using System.Collections.Generic;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer string");
            string a = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo string");
            string b = Console.ReadLine();
            Console.WriteLine("El resultado es:");
            Console.WriteLine(longest(a,b));
        }

        static string longest (string a, string b)
        {
            string ab = a + b;
            List<char> listaDeCaracteres = agregarALista(ab);
            List<char> listaDeCaracteresOrdenados = ordenarListaAlfabeticamente(listaDeCaracteres);

            return convertirDeListAString(listaDeCaracteresOrdenados);
        }
        static List<char> agregarALista(string ab)
        {
            List<char> lista = new List<char>();
            for (int i = 0; i < ab.Length; i++)
            {
                if (!lista.Contains(ab[i]))
                {
                    lista.Add(ab[i]);
                }
            }

            return lista;
        }

        static List<char> ordenarListaAlfabeticamente (List<char> lista)
        {
            lista.Sort();
            return lista;
        }

        static string convertirDeListAString (List<char> lista)
        {
            return String.Join("", lista);
        }
    }
}
