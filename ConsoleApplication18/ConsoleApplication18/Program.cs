using System;

namespace ConsoleApplication18
{
    class Program
    {        
        static void Main(string[] args)
        {
            Service jeden = new Service();
            jeden.GenerateListOfPerson();
            jeden.DrukujListe();

            Console.WriteLine();
            
            jeden.SortName();
            jeden.DrukujListe();

            Console.WriteLine();

            jeden.SortAge();
            jeden.DrukujListe();

            Console.WriteLine();

            jeden.SortId();
            jeden.DrukujListe();



            Console.ReadKey();
        }       
    }
}
