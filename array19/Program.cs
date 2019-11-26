using Gestionearray1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            GestioneArray.Leggiarray(array);
            GestioneArray.StampaArray(array);
            int[] array1 = GestioneArray.CopiaArray(array);
            GestioneArray.StampaArray(array2);
            Console.ReadLine();
        }
    }
}
