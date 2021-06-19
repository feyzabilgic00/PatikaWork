using System;

namespace inheritance
{
    public class Plants : Livingthings
    {
        protected void DoPhotosynthesis()
        {
            Console.WriteLine("Bitkiler fotosentez yaparlar");
        }
        public override void ResponseToStimuli()
        {
            //base.ResponseToStimuli();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }
    public class SeedPlants : Plants
    {
        public SeedPlants()
        {
            base.DoPhotosynthesis();
            base.Nutrition();
            base.Excretion();
            base.Respiratory();
            base.ResponseToStimuli();
        }
        public void ReproductionBySeed()
        {
            Console.WriteLine("Tohumlu bitkiler tohum ile çoğalır");
        }
    }
    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.DoPhotosynthesis();
            base.Nutrition();
            base.Excretion();
            base.Respiratory();
        }
        public void SeedlessReproduction()
        {
            Console.WriteLine("Bitkiler tohumsuz yöntem ile de çoğalabilirler");
        }
    }
}

