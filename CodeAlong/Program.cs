namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyHorse = new Horse(100);
            var TheirHorse = new Horse(90);

            List<Horse> HorsesInRace = new();
            HorsesInRace.Add(MyHorse);
            HorsesInRace.Add(TheirHorse);

            var Race = new Race(HorsesInRace);

            MyHorse.SignUpForRace();
            TheirHorse.SignUpForRace();

            Race.ContinueRunning();
        }
    }
}
