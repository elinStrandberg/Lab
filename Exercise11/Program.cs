using System;
using System.Collections.Generic;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Adam", "Eva", "Maria", "Josef", "Bo", "Li", "An" };

            PrintNames(names);
            AddNameToList(names);
            RemoveNameFromList(names);
            SortNames(names);
        }

        private static void PrintNames(List<string> names)
        {
            Console.WriteLine("Skriver ut namn");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        private static void AddNameToList(List<string> names)
        {
            Console.WriteLine("Ange namn du vill lägga till");
            string newName = Console.ReadLine();

            names.Add(newName);

            PrintNames(names);
        }

        private static void RemoveNameFromList(List<string> names)
        {
            bool nameFound = false;
            do
            {
                Console.WriteLine("Ange namn du vill ta bort");
                string nameToDelete = Console.ReadLine();

                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].ToLower().Equals(nameToDelete.ToLower()))
                    {
                        names.RemoveAt(i);
                        nameFound = true;
                        PrintNames(names);
                    }
                }
                if (nameFound == false)
                {
                    Console.WriteLine("Namnet finns inte i listan, försök igen");
                }

            } while (!nameFound);
        }

        private static void SortNames(List<string> names)
        {
            names.Sort();
            PrintNames(names);
        }
    }
}
