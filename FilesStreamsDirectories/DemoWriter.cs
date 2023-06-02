using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesStreamsDirectories
{
    internal class DemoWriter
    {
        public static void WriterHow()
        {

            //streams

            /*
                Transfer Data
            -Between Two End points

            StreamReader
             */

            StreamReader reader = new StreamReader(@"../../../test.txt");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
            //Must be manualy closed
            reader.Close();

            using (StreamReader reader1 = new StreamReader(@"../../../test.txt"))
            {
                while (!reader1.EndOfStream)
                {
                    var line = reader1.ReadLine();
                    Console.WriteLine(line);
                }
            }
            //Auto closes the Stream
        }

    }
}
