using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sheltered
{
    class splashScreen
    {
        private const string fileLocation = "../../Resources/Displays/splashFile.txt";

        public void spashOutput()
        {
            string line;
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation);
            while((line = file.ReadLine()) != null)
            {
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + line.Length / 2) + "}", line);
                counter++;
            }
            
        }
        public void centeredText(string lineToPrint)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + lineToPrint.Length / 2) + "}", lineToPrint);
        }
    }
}
