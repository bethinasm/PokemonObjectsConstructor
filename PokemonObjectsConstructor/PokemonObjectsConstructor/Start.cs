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
                Console.WriteLine("[2] To show other pokemon");
                Console.WriteLine("[3] To exit the program\n\n");
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
                        PrintPokemon();
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

        public void PrintPokemon()
        {
            var pokemon1 = new Pokemon("Bulbasaur", 45, 5, "Grass & Poison");
            var pokemon2 = new Pokemon("Cubone", 30, 3, "Ground");

            Console.Clear();
            Console.WriteLine($"The first pokemon is: {pokemon1.Name}. {pokemon1.Name} is a {pokemon1.Type} type. This one is LVL {pokemon1.Level} and HP {pokemon1.Health}.\n\n");
            Console.WriteLine($"The second pokemon is: {pokemon2.Name}. {pokemon2.Name} is a {pokemon2.Type} type. This one is LVL {pokemon2.Level} and HP {pokemon2.Health}.\n\n");
            Thread.Sleep(1500);
        }
    }
}