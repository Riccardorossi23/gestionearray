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
            int[] array = new int[6];

           //GestioneArray.leggi(array);
            //GestioneArray.stampa(array);
            int[] array1 = GestioneArray.copia(array);
            GestioneArray.stampa(array1);
            Console.ReadLine();
        }
    }
}
