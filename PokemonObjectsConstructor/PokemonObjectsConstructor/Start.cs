using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PokemonObjectsConstructor
{
    internal class Start
    {
        private bool isRunning = true;
        public void Menu()
        {
            while (isRunning)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1] To show Pikachu");
                Console.WriteLine("[2] ........");
                Console.WriteLine("[3] ........\n\n");
                var userInput = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        var pikachu = new Pikachu();
                        pikachu.DisplayPikachu();
                        Thread.Sleep(1500);
                        break;
                    case 2:

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("The program will now shut down");
                        Thread.Sleep(1500);
                        
                        isRunning = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Not a valid input. Try again! \n\n");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }
    }
}
