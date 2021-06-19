using System;

namespace methods_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string number="999";
            int outNumber;
            bool result=int.TryParse(number,out outNumber);
            if (result)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }
            Methods methods=new Methods();
            methods.Sum(2,3,out int sumResult);
            Console.WriteLine(sumResult);

            //Metod Aşırı Yükleme - Overloading
            int expression=999; 
            methods.PrintToScreen(expression);
            methods.PrintToScreen("Feyza","Bilgiç");
            //Metod imzası
            //MetodAdi + parametre sayısı + parametre            
        }
    }
    class Methods
    {
        public void Sum(int a,int b,out int sum)
        {
            sum=a+b;
        }
        public void PrintToScreen(string data)
        {
            Console.WriteLine(data);
        }
        public void PrintToScreen(int data)
        {
            Console.WriteLine(data);
        }
        public void PrintToScreen(string data,string data2)
        {
            Console.WriteLine("{0} {1}",data,data2);
        }
    }
}
