using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Lecture1_Examples;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //一維陣列
            Pokemon[] PokemonList = new Pokemon[3];
            PokemonList[0] = new Pokemon();
            PokemonList[0].Weight = 2.0f;
            PokemonList[1] = new Pokemon();
            PokemonList[2] = new Pokemon();
        }
    }
}