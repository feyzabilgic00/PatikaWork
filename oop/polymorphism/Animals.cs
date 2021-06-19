using System;

namespace inheritance
{
    public class Animals : Livingthings
    {
        protected void Adaptation()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapabilir");
        }
        public override void ResponseToStimuli()
        {
            base.ResponseToStimuli();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }
    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Nutrition();
            base.Excretion();
            base.Respiratory();
        }
        public void Crawling()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    public class Birds : Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Nutrition();
            base.Excretion();
            base.Respiratory();
            base.ResponseToStimuli();
        }
        public void Fly()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}
