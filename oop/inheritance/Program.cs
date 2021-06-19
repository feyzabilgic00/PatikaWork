using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedPlants seedPlants = new SeedPlants();
            seedPlants.ReproductionBySeed();  

            Console.WriteLine("******************");

            Birds seagull = new Birds();
            seagull.Fly();
        }
    }
}
