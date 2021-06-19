using System;

namespace recursiver_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive - Öz Yinelemeli
            //3*4 = 3*3*3*3
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
                Console.WriteLine(result);                
            }
            Transactions transactions=new Transactions();
            Console.WriteLine(transactions.Expo(3,4));

            //Extension Metodlar
            string expression="Feyza Bilgiç";
            bool result2=expression.CheckSpaces();
            Console.WriteLine(result2);
            if (result2)
            {
                Console.WriteLine(expression.RemoveWhiteSpaces());
            }
            Console.WriteLine(expression.MakeUpperCase());
            Console.WriteLine(expression.MakeLowerCase());

            int[] array={9,3,6,2,1,5,0};
            array.SortArray();
            array.PrintToScreen();
            
            int number=5;
            number.IsEventNumber();
            Console.WriteLine(number.IsEventNumber());
            Console.WriteLine(expression.GetFirstCharacter());

        }
    }
    public class Transactions
    {
        public int Expo(int number,int exponent)
        {
            if (exponent<2)
            {
                return number;
            }
            return Expo(number,exponent-1)*number;
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] array=param.Split(" ");
            return string.Join("",array);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void PrintToScreen(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEventNumber(this int param)
        {
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
