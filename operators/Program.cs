using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Atama ve İşlemli Atama *******");
            int x=3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            Console.WriteLine("******Mantıksal Operatörler*******");
            //||,&&,!
            bool isSuccess=true;
            bool isCompleted=false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }
            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }

            Console.WriteLine("******İlişkisel Operatörler*******");
            //<,>,<=,>=,==,!=
            int a=3;
            int b=4;
            bool result=a<b;
            Console.WriteLine(result);
            result=a>b;
            Console.WriteLine(result);
            result=a>=b;
            Console.WriteLine(result);
            result=a<=b;
            Console.WriteLine(result);
            result=a==b;
            Console.WriteLine(result);
            result=a!=b;
            Console.WriteLine(result);

            Console.WriteLine("******Aritmetik Operatörler*******");
            //*,+,-,/
            int number=10;
            int number2=5;
            int resultSum=number+number2;
            Console.WriteLine(resultSum);
            int resulEject=number-number2;
            Console.WriteLine(resulEject);
            int resultMultply=number*number2;
            Console.WriteLine(resultMultply);
            int resultDivde=number/number2;
            Console.WriteLine(resultDivde);

            //%:mod alır
            int result2=20%3;
            Console.WriteLine(result2);
        }
    }
}
