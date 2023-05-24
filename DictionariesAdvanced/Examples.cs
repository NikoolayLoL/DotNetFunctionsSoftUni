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
                .Reverse()
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var (key, value) in studentGrades)
            {
                Console.WriteLine($"{key} = {value}");
            }

        }

    }
}
