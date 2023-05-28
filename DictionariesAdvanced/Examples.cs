using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAdvanced
{
    internal class Examples
    {
        static public void ExamplesMain()
        {
            // Abstract Data Type - They keep the assignment of entries. *special to C#

            Dictionary<string, double> averageGrades = new Dictionary<string, double>();

            averageGrades.Add("Gosho", 6);

            Console.WriteLine(averageGrades["Gosho"]);

            // Check if the Key is in
            Console.WriteLine("------------");

            if (averageGrades.ContainsKey("Goshoo"))
            {
                Console.WriteLine("Yes it is");
            }
            else
            {
                Console.WriteLine("Nope");
            }

            // Sorted Dictionary - Updates the key location
            Console.WriteLine("------------");

            SortedDictionary<int, string> nameUsers = new SortedDictionary<int, string>();

            nameUsers.Add(206182, "Nikolay R");
            nameUsers.Add(206180, "Doroteya D");
            nameUsers.Add(206183, "Georgi T");


            // var item in nameUsers /->/ item.key item.value 
            foreach (var (key, value) in nameUsers)
            {
                Console.WriteLine($"{key} : {value}");
            }

        }

        static public void GradeCounter()
        {
            Dictionary<double, int> averageGrades = new Dictionary<double, int>();

            //-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3 
            // Counts how many times each element is present

            string[] input = Console.ReadLine().Trim().Split(" ");

            double[] inputNumbers = input.Select(double.Parse).ToArray();

            foreach (int number in inputNumbers)
            {
                if (!averageGrades.ContainsKey(number))
                {
                    averageGrades[number] = 1;
                }
                else
                {
                    averageGrades[number]++;
                }

            }

            foreach (var (key, value) in averageGrades)
            {
                Console.WriteLine($"{key} - {value} times");
            }

        }


        static public void StudentDictionarySorter()
        {
            

            /*
            Sorts them:

            Pesho Andomov  = 2
            Pesho Angelov  = 3
            Andel          = 4
            Nikolay        = 5
            Pesho Dimitrov = 5
            Pesho Dimov    = 6
             */

            Dictionary<string, double> studentGrades = new Dictionary<string, double>();

            studentGrades.Add("Pesho Dimov", 6);
            studentGrades.Add("Pesho Andomov", 2);
            studentGrades.Add("Pesho Dimitrov", 5);
            studentGrades.Add("Pesho Angelov", 3);
            studentGrades.Add("Nikolay", 5);
            studentGrades.Add("Andel", 4);

            studentGrades = studentGrades.OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                //.Reverse()
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var (key, value) in studentGrades)
            {
                Console.WriteLine($"{key} = {value}");
            }

        }

        static public void MultiDictioanryExample()
        {
            /*
             Multi-Dictionary
            Dictionary containing for ex a List

            {Input}
            7
            John 5.20
            Maria 5.50
            John 3.20
            Maria 2.50
            Sam 2.00
            Maria 3.46
            Sam 3.00

            {Output}

            John -> 5.20 3.20 (avg: 4.20)
            Maria -> 5.50 2.50 3.46 (avg: 3.82)
            Sam -> 2.00 3.00 (avg: 2.50)

             */

            Dictionary<string, List<decimal>> studentAvgGrades = new Dictionary<string, List<decimal>> { };

            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                string[] currentInput = Console.ReadLine().Split(" ");

                if (!studentAvgGrades.ContainsKey(currentInput[0]))
                {
                    studentAvgGrades.Add(currentInput[0], new List<decimal>());
                }

                studentAvgGrades[currentInput[0]].Add(decimal.Parse(currentInput[1]));
            }

            foreach (var (key, value) in studentAvgGrades)
            {
                //Console.WriteLine($"{key} -> {string.Join(" ",value)} (avg: {value.Average():F2})");

                Console.Write($"{key} -> ");

                foreach (var item in value)
                {
                    Console.Write($"{item:F2} ");
                }

                Console.WriteLine($"(avg: {value.Average():F2})");
            }
        }

    }
}
