using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise10
{
    class Person
    {
        public void Run()
        {
            string[] names = { "Elin", "Cecilia", "Anna", "David", "Lisa", "Bertil" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            names = AddNameToArray(names);
            names = DeleteNameFromArray(names);
            //SortNamesInArray(names);

            Console.WriteLine("----Ascending Order----");
            Array.Sort(names);

            foreach (var i in names)
            {
                Console.WriteLine(i);
            }

            var sortedValuesDecs = from name in names
                                  orderby name descending
                                  select name;

            Console.WriteLine("----Descending Order----");
            Array.ForEach<string>(sortedValuesDecs.ToArray<string>(), x => Console.WriteLine(x));

        }

        private string[] AddNameToArray(string[] names)
        {
            Console.WriteLine("Vilket namn vill du lägga till?");
            string newName = Console.ReadLine();

            string[] newNameArray = new string[names.Length + 1];
            Array.Copy(names, newNameArray, names.Length);

            newNameArray[newNameArray.Length - 1] = newName;

            for (int i = 0; i < newNameArray.Length; i++)
            {
                Console.WriteLine(newNameArray[i]);
            }

            return newNameArray;
        }

        private string[] DeleteNameFromArray(string[] names)
        {
            Console.WriteLine("Vilket namn vill du ta bort?");
            string nameToDelete = Console.ReadLine();

            int indexToDelete = -1;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower() == nameToDelete.ToLower())
                {
                    indexToDelete = i;
                    break;
                }
            }

            if (indexToDelete > -1)
            {
                string[] anotherArray = new string[names.Length - 1];
                int newNameIndex = -1;

                for (int i = 0; i < names.Length; i++)
                {
                    if (i != indexToDelete)
                    {
                        anotherArray[++newNameIndex] = names[i];
                    }
                }
                for (int i = 0; i < anotherArray.Length; i++)
                {
                    Console.WriteLine(anotherArray[i]);
                }
                return anotherArray;
            }
            else
            {
                return names;
            }

        }

        private void SortNamesInArray(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                int index = IndexOfStringHavingTheSmallestValue(i);

                if (index != i)
                {
                    SwapPlaces(i, index);
                }
            }
            Console.WriteLine("Sorterar från minsta till största: ");
            Console.WriteLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }

            void SwapPlaces(int i, int index)
            {
                string tmp = names[i];
                names[i] = names[index];
                names[index] = tmp;
            }

            int IndexOfStringHavingTheSmallestValue(int startIndex)
            {
                for (int i = startIndex; i < names.Length; i++)
                {
                    if (string.Compare(names[i], names[startIndex], true) < 0)
                    {
                        startIndex = i;
                    }
                }
                return startIndex;
            }
        }


    }
}
