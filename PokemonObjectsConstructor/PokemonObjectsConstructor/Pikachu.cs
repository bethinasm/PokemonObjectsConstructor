using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonObjectsConstructor
{
    internal class Pikachu
    {
        public void DisplayPikachu()
        {
            var pikachu = new { Health = 50, Level = 15, Type = "Electric"};
            Console.WriteLine($"Pikachu is LVL {pikachu.Level} and has {pikachu.Health} HP.\nPikachu is an {pikachu.Type} type Pokemon. \n\n");
        }
    }
}