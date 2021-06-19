using System;

namespace inheritance
{
    public class Livingthings
    {
        protected void Nutrition()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Respiratory()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Excretion()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
        public virtual void ResponseToStimuli()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}
