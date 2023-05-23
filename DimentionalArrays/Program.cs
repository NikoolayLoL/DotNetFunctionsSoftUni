namespace DimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Usage case:
           *Input Rows and Collumns {1}
           *Input N rows of numbers, Split by the rule ", " {2}

           {1}     3, 6
           {2}     7, 1, 3, 3, 2, 1
                   1, 3, 9, 8, 5, 6
                   4, 6, 7, 9, 1, 0

           *Output Sum of N rows {3}
           {3}     17
                   32
                   27

            */

            string[] userInput = Console.ReadLine().Split(", ");

            int rowMatrix = int.Parse(userInput[0]);
            int colMatrix = int.Parse(userInput[1]);

            int[,] Matrix = new int[rowMatrix, colMatrix];

            for (int i = 0; i < rowMatrix; i++)
            {
                userInput = Console.ReadLine().Split(", ");

                for (int y = 0; y < colMatrix; y++)
                {
                    Matrix[i, y] = int.Parse(userInput[y]);
                }
            }

            for (int i = 0; i < rowMatrix; i++)
            {
                for (int y = 0; y < colMatrix - 1; y++)
                {
                    Matrix[i, 0] += Matrix[i, 1 + y];
                }

                Console.WriteLine(Matrix[i, 0]);
            }
        }
    }
    
}