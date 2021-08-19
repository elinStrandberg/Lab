using System;
using System.Collections.Generic;

namespace Exercise12
{
    class Program
    {
        static Person[] people = new Person[3];
        static void Main(string[] args)
        {

            bool runProgram = true;
            int personToList = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Vad vill du göra? Mata in en av följande bokstäver: \n [S] - Skapa lista \n [U] - Uppdatera \n [R] - Radera \n [O] - Ordna \n [V] - Visa lista \n [A] - Avsluta \n ");
                Console.WriteLine("--------------------------------------------");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                switch (input.Key)
                {
                    case ConsoleKey.S:
                        for (int i = 0; i < people.Length; i++)
                        {
                            personToList = AddPerson(people, personToList);
                        }
                        break;
                    case ConsoleKey.U: ChangeInformationInList(people); break;
                    case ConsoleKey.R: RemovePersonFromList(people); break;
                    case ConsoleKey.O: SortNamesInAlfabeticalOrder(people, personToList); break;
                    case ConsoleKey.V: PrintName(people); break;
                    case ConsoleKey.A: runProgram = EndList(); break;
                    default:
                        Console.WriteLine("Inget sånt alternativ finns, försök igen.");
                        break;
                }
            } while (runProgram);
        }

        private static int AddPerson(Person[] people, int personToList)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Console.Clear();
                if (personToList < people.Length)
                {
                    Console.WriteLine("Lägg till namn:");
                    people[personToList].FirstName = Console.ReadLine();
                    Console.WriteLine("Lägg till ett telefonnummer:");
                    people[personToList].PhoneNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lägg till ett e-postadress:");
                    people[personToList].Email = Console.ReadLine();

                    personToList++;
                }
            }
            return personToList;
        }

        private static void ChangeInformationInList(Person[] people)
        {
            Console.WriteLine("Vilket namn vill du uppdatera?");
            string nameToUpdate = Console.ReadLine();

            for (int i = 0; i < people.Length; i++)
            {
                if (nameToUpdate.ToLower() == people[i].FirstName.ToLower())
                {
                    Console.WriteLine("Uppdatera namn:");
                    people[i].FirstName = Console.ReadLine();
                    Console.WriteLine("Lägg till ett telefonnummer:");
                    people[i].PhoneNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lägg till ett e-postadress:");
                    people[i].Email = Console.ReadLine();
                }
            }
        }

        private static void RemovePersonFromList(Person[] people)
        {
            Console.WriteLine("Vilket namn vill du ta bort?");
            string nameToRemove = Console.ReadLine();

            for (int i = 0; i < people.Length; i++)
            {
                if (nameToRemove.ToLower() == people[i].FirstName.ToLower())
                {
                    people[i].FirstName = null;
                    people[i].Email = null;
                    people[i].PhoneNumber = 0;
                }
            }
        }

        private static void SortNamesInAlfabeticalOrder(Person[] people, int peopleInList)
        {

            for (int i = 0; i < people.Length; i++)
            {
                peopleInList = i;
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (string.Compare(people[j].FirstName,people[peopleInList].FirstName,true) > 0)
                    {
                        peopleInList = j;
                    }
                }
                if (peopleInList != i)
                {
                    string temp = people[i].FirstName;
                    people[i] = people[peopleInList];
                    people[peopleInList].FirstName = temp;
                }
            }

        }

        private static void PrintName(Person[] people)
        {
            Console.WriteLine("Namnlista:");

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Namn: {people[i].FirstName}, ");
                Console.WriteLine($"E-post: {people[i].Email} ");
                Console.WriteLine($"Telefonnummer: {people[i].PhoneNumber}, ");
            }
            Console.ReadKey();
        }

        private static bool EndList()
        {
            Console.WriteLine("Tack för besöket. Välkommen åter.");
            Console.ReadKey();
            return false;
        }
    }
}
