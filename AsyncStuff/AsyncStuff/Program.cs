using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStuff
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CookEggs();
            CookBacon();
            await MakeBreakfast();
        }
        private static void CookEggs()
        {
            Console.WriteLine("I am cooking eggs");
            Thread.Sleep(4000);
        }
        private static void CookBacon()
        {
            Console.WriteLine("I am cooking bacon");
            Thread.Sleep(4000);
        }
        private static async Task MakeBreakfast()
        {
            Task cookEggs = new Task(CookEggs);
            Task cookBacon = new Task(CookBacon);
            cookEggs.Start();
            Thread.Sleep(1000);
            cookBacon.Start();
            await cookEggs;
            Console.WriteLine("I am done cooking eggs");
            await cookBacon;
            Console.WriteLine("I am done cooking bacon");
        }
    }
}
