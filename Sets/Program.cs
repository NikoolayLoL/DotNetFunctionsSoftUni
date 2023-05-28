namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get unique value and print

            int n = int.Parse(Console.ReadLine());

            HashSet <string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }

            Console.WriteLine("-------------");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}