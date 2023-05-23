using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
