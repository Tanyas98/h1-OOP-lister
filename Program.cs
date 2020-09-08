using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h1_OOP_lister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listTal = new List<int>() { 4,7,12,17,-3,8,0,-45,101};

            List<int> nyListe = listTal.Where(number => number <= 0).ToList();
            List<int> nyListe1 = listTal.Where(number => number == 7).ToList();
            List<int> nyListe2 = listTal.Where(number => number >  4).ToList();

            UdskrivListe(nyListe);//metoden kaldes
            Console.WriteLine();
            UdskrivListe(nyListe1);//metoden kaldes
            Console.WriteLine();
            UdskrivListe(nyListe2);//metoden kaldes

            Console.ReadKey();
        }
        static void UdskrivListe(List<int> nyListe)
        {
            foreach (var item in nyListe)
            {
                    Console.WriteLine(item);
            }
        }
    }
}
