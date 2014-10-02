using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheltered
{
    class Program
    {
        static void Main(string[] args) //testing!!
        {
            string userInput;
            splashScreen spashScreen = new splashScreen();
            spashScreen.spashOutput();
            getUserChoice getUserChoice = new getUserChoice();
            userInput = getUserChoice.getUserInput();
            Console.WriteLine(userInput);
            Console.Read();
        }
    }
}
