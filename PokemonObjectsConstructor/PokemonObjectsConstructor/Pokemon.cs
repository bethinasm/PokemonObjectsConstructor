using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonObjectsConstructor;

namespace PokemonObjectsConstructor
{
    internal class Pokemon
    {
        //objektet
        public string Name;
        public int Health;
        public int Level;
        public string Type;


        //constructor
        public Pokemon(string name, int health, int level, string type)
        {
            Name = name;
            Health = health;
            Level = level;
            Type = type;
        }
    }
}
