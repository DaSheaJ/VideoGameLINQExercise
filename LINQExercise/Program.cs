using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Injustice 2", "Mortal Kombat", "Spider-Man" };

            var sortedGames = videoGames.OrderBy(x => x.Length).ToList();

            sortedGames.ForEach(Console.WriteLine);
        }
    }
}
