using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheltered
{
    class Program
    {
        static void Main(string[] args)
        {
            splashScreen spashScreen = new splashScreen();
            spashScreen.spashOutput();
            Console.Read();
        }
    }
}
