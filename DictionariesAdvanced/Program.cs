using System.Linq;

namespace DictionariesAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Examples.ExamplesMain();
            //Examples.StudentDictionarySorter();

            /*
            Nested Dictionaries

            Product Shop

            -if a Shop aleready exists add the product to it.
            -Revision - means END
            *don't touch the price
            -order by shop name

            "{shop}, {product}, {price}"

            {Input}
            lidl, juice, 2.30
            fantastico, apple, 1.20
            kaufland, banana, 1.10
            fantastico, grape, 2.20
            Revision

            Product: {product}, Price: {price}"

            {Output}
            fantastico->
            Product: apple, Price: 1.2
            Product: grape, Price: 2.2
            kaufland->
            Product: banana, Price: 1.1
            lidl->
            Product: juice, Price: 2.3

            */

            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string,
               Dictionary<string, double>>();


            while (command != "Revision")
            {
                string[] input = command.Split(", ");
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }

                shops[shop][product] = price;

                command = Console.ReadLine();
            }

            shops = shops.OrderBy(x => x.Key)
                .ToDictionary(x=>x.Key, x => x.Value);


            foreach (var (shop,products) in shops)
            {
                Console.WriteLine($"{shop}->");

                foreach(var (product,price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }

        }
    }
}