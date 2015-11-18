using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_test
{

    class Program
    {
        static void Main(string[] args)
        {
            string dbAccessReturn;
            string path = "C:/Users/marcin/Documents/sample_text.txt";
            Supporting.FileIO databseaccess = new Supporting.FileIO();

            dbAccessReturn = databseaccess.writeToDatabase(path, "sample_text.txt", "message");

            Console.WriteLine(dbAccessReturn + '\n');
        }
    }
}
