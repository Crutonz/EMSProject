using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Supporting
{
    public class FileIO
    {
        public string dbFileLocation;
        public string dbFileName;
        public string dbField;
        public string parserFileName;
        public string parserFileLocation;
        static string dbReadStatus;
        static string line;

        public string writeToDatabase(string dbFileLocation, string dbFileName, string dbField)
        {
            try
            {
                StreamWriter sw = new StreamWriter(dbFileLocation+dbFileName);

                sw.WriteLine(dbField);

                sw.Close();

                return ("Record added OK");
            }
            catch (Exception e)
            {
                return ("Exception; " + e.Message);
            }

        }

        public string readFromDatabase(string dbFileLocation, string dbFileName)
        {
            try
            {
                StreamReader sr = new StreamReader(dbFileLocation+dbFileName);

                return ("Record added OK");
            }
            catch (Exception e)
            {
                return ("Exception; " + e.Message);
            }

        }

    }
}
