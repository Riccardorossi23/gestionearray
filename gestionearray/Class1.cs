using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionearray1
{
    public class GestioneArray
    {
        public static void Leggiarray(int[] array)
        {
            Console.WriteLine("inserici valori array :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"/t inserisci elemento{i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int n = array[i];
                Console.WriteLine($"array{i}={n}");
            }
        }
        public static int[] CopiaArray(int[] array)
        {
            int[] array1 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }
            return array1;
        }
        public static bool RicercaArray(int[] array, int elemento)
        {
            bool ricerca = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    ricerca = true;
            }
            return ricerca;
        }

        public static bool Uguali(int[] a, int[] b)
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
        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static bool Crescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])

                    risposta = false;

            }
            return risposta;
        }
        public static bool Descrescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i > array.Length; i++)
            {
                if (array[i] > array[i - 1])
                    risposta = false;


            }
            return risposta;
        }
        public static void RiempiArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(); 
            }

        }
        public static int[] UnisciArray(int[] array, int[] array1)
        {
            int[] Merge = new int[array.Length + array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                Merge[i] = array[i];
            }
            for (int i = array.Length + 1; i < Merge.Length; i++)
            {
                Merge[i] = array1[i - array1.Length];
            }
            return Merge;
        }
    }
}
