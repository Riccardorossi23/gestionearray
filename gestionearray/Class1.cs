using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionearray
{
    public class GestioneArray
    {
        public static void leggiarray(int[]array)
        {
            Console.WriteLine("inserici valori array :");
            for(int i=0;array.Length;i++)
            {
                Console.WriteLine($"/tinserisci elemento{i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void StampaArray(int[]array)
        {
            for(int i=0;i<array.Length;i++)
            {
                int n = array[i];
                Console.WriteLine($"array{i}={n}");
            }
        }
        public static bool uguali(int[]a,int[]b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for(int i=0;i<a.Length;i++)
                if(a[i]!=b[i])
                {
                    return false;
                }
            return true;
        }
        public static bool crescente(int[]array)
        {
            for(int i=1;i<array.Length;i++)
            {
                if(array[i]<array[i-1])
                {
                    return false;
                }
                return true;
            }
        }
        public static bool descrescente(int[]array)
        {
            for(int i=1;i>array.Length;i--)
            {
                if(array[i]>array[i-1])
                {
                    return false;
                }
                return true;
            }
        }
    }
}
