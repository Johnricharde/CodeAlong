using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Race
    {
        List<Horse> HorsesInRace {  get; set; }

        public Race(List<Horse> horsesInRace)
        {
            HorsesInRace = horsesInRace;
        }
        public void ContinueRunning()
        {
            foreach (var horse in HorsesInRace)
            {
                while (!horse.HasWon())
                {
                    horse.CurrentDistance += horse.Speed;
                    Console.WriteLine("one round has passed.");
                }
                Console.WriteLine("No one has won yet...");
            }
        }
    }
}
