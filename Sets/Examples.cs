using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    internal class Examples
    { 
        static public void ExampleOfSet()
        {
            //Sets

            /*
            Unique elements
            Fast Contains functionality
            No Value
             */

            HashSet<string> set = new HashSet<string>();
            set.Add("Peter");


            //won't be added second time
            set.Add("Peter");

            set.Add("Steve");

            set.Remove("Peter");

            Console.WriteLine(set.Contains("Steve"));

            //List removes slowly items and Searches slowly, but has duplicates
            //HashSet fast add and fast search, no duplicates, no order
        }

    }
}
