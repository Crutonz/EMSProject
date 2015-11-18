using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Supporting
{
    class Logging
    {
        public string logFileLocation;
        public string logFileName;

        public string logEvent(string logFileLocation, string logFileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(logFileLocation);

                return ("Log added OK");
            }
            catch (Exception e)
            {
                return ("Exception; " + e.Message);
            }

        }
    }
}
