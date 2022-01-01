using System;
using System.Collections.Generic;

namespace lab6_csh
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a list of parts.
            List<Persone> persons = new List<Persone>();

            // Add parts to the list.
            persons.Add(new Persone("Иванова", "Марина", "Дмитриевна"));
            persons.Add(new Persone("Баянова", "Людмила", "Анатольевна"));
            persons.Add(new Teacher("Погребников", "Николай", "Михайлович"));
            persons.Add(new Persone("Синицына", "Лариса", "Анатольевна"));
            persons.Add(new Teacher("Герасимов", "Владимир", "Петрович"));

            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (Persone pers in persons)
            {
                pers.DisplayInfo();
            }


            //persons.Sort();

            persons.Sort(delegate (Persone x, Persone y)
            {
                if (x.GetFam() == null && y.GetFam() == null) return 0;
                else if (x.GetFam() == null) return -1;
                else if (y.GetFam() == null) return 1;
                else return x.GetFam().CompareTo(y.GetFam());
            });

            Console.WriteLine();
            foreach (Persone pers in persons)
            {
                pers.DisplayInfo();
            }


            Console.WriteLine("\nПоиск по имени 'Николай':");
            persons.Find(x => x.GetName().Contains("Николай")).DisplayInfo();
            
            //Console.WriteLine("\nFind: Persone where name contains \"Николай\": {0}",
            //persons.Find(x => x.GetName().Contains("Николай")));
        }
	}
}
