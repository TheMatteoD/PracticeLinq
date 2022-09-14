using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Skyrim", "Assassin's Creed", "Dark Souls", "Cyberpunk 2077", 
                "Far Cry", "God of War", "Red Dead Redemption", "Grand Theft Auto", "Mafia", "The Division", "Ghost Recon" };
            var sorted = videoGames.OrderBy(x => x.Length);
            

            foreach (var game in sorted)
            {
                Console.WriteLine(game);
            }
        }
    }
}
