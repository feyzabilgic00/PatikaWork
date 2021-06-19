using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=2;
           int b=3;
           Console.WriteLine(a+b);
           
           var result=Sum(a,b);
           Console.WriteLine(result);

           Nethods methods=new Nethods();
           methods.PrintToScreen(result.ToString());

           var result2=methods.IncreaseAndCollect(ref a,ref b);
           methods.PrintToScreen(result2.ToString());
           methods.PrintToScreen((a+b).ToString());
        }
        static int Sum(int value1,int value2)
        {
            return value1+value2;
        }
    }
    class Nethods
    {
        public void PrintToScreen(string data)
        {
            Console.WriteLine(data);
        }
        public int IncreaseAndCollect(ref int value1,ref int value2)
        {
            value1+=1;
            value2+=1;
            return value1+value2;
        }
    }
}
