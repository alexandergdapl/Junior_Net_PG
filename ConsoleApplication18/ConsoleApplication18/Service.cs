using System;
using System.Collections.Generic;

namespace ConsoleApplication18
{
    public class Service
    {
        readonly List<Person> klienci = new List<Person>();

        
        public void GenerateListOfPerson()
        {
            klienci.Add(new Person(1, "Mariusz", 18, "555888555"));
            klienci.Add(new Person(2, "Dariusz", 28, "111000999"));
            klienci.Add(new Person(6, "Zbigniew", 27, "888555888"));
            klienci.Add(new Person(3, "Adam", 20, "333666999"));
            klienci.Add(new Person(4, "Olek", 19, "222555888"));
            klienci.Add(new Person(5, "Ewa", 25, "888555888"));
        }

        public void SortName()
        {
            klienci.Sort(delegate (Person x, Person y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });
        }


        public void SortId()
        {
            klienci.Sort((x, y) => x.Id.CompareTo(y.Id));
        }


        public void SortAge()
        {
            klienci.Sort((x, y) => x.Age.CompareTo(y.Age));
        }

    /*
        public void SortAge()
        {
            klienci.Sort(delegate (Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            });
        }

    */



        public void DrukujListe()
        {
            foreach (var q in klienci)
            {
                Console.WriteLine($"{q.Id}    {q.Name}    {q.Age}    {q.AcNumber}");
                //Console.WriteLine("{0}  {1}   {2,2}   {3}", q.Id, q.Name, q.Age, q.AcNumber);
            }
        }
    }
}
