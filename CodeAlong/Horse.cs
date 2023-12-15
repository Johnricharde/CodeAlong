using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Horse
    {
        public int Speed {  get; set; }
        public int CurrentDistance {  get; set; }

        public Horse(int speed)
        {
            Speed = speed;
            CurrentDistance = 0;
        }



        public void Feed()
        {
            Console.WriteLine("You feed the horse.");
        }
        public void Groom()
        {
            Console.WriteLine("You groomed the horse.");
        }
        public void SignUpForRace()
        {
            Console.WriteLine("You signed the horse up for a race. ");
        }
        public bool HasWon()
        {
            if (CurrentDistance >= 3000)
            {
                Console.WriteLine("You've won!");
                return true;
            }
            else
                return false;
        }
    }
}
