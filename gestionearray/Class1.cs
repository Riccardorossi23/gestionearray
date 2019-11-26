using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionearray1
{
    public class GestioneArray
    {
        public static void leggi(int[] array)
        {
            Console.WriteLine("inserici valori array :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"/t inserisci elemento{i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void stampa(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int n = array[i];
                Console.WriteLine($"array{i}={n}");
            }
        }
        public static int[] copia(int[] array)
        {
            int[] array1 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }
            return array1;
        }
        public static bool ricerca(int[] array, int element)
        {
            bool ricerca = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                    ricerca = true;
            }
            return ricerca;
        }

        public static bool uguali(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                {
                    return false;
                }
            return true;
        }
        public static int CercaMassimo(int[] array)
        {
            int massimo = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (massimo>array[i])
                    massimo = array[i];
            }
            return massimo;
        }
        public static int cercaMinimo(int[] array)
        {
            int minimo = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimo)
                    minimo = array[i];
            }
            return minimo;
        }
        public static bool crescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])

                    risposta = false;

            }
            return risposta;
        }
        public static bool descrescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i > array.Length; i++)
            {
                if (array[i] > array[i - 1])
                    risposta = false;


            }
            return risposta;
        }
        public static void riempi(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

        }
    }
}
