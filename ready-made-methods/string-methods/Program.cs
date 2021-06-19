using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable="Dersimiz CSharp, Hoşgeldiniz!";
            string variable2="CSharp";

            //Length
            Console.WriteLine(variable.Length);

            //ToUpper, ToLower
            Console.WriteLine(variable.ToUpper());
            Console.WriteLine(variable.ToLower());

            //Concat
            Console.WriteLine(String.Concat(variable," Merhaba"));

            //Compare,CompareTo
            Console.WriteLine(variable.CompareTo(variable2));
            Console.WriteLine(String.Compare(variable,variable2,true));
            Console.WriteLine(String.Compare(variable,variable2,false));

            //Contains
            Console.WriteLine(variable.Contains(variable2));            
            Console.WriteLine(variable.EndsWith("Hoşgeldiniz!")); 
            Console.WriteLine(variable.StartsWith("Merhaba!"));            

            //IndexOf
            Console.WriteLine(variable.IndexOf("CS"));          
            Console.WriteLine(variable.IndexOf("Feyza"));
            Console.WriteLine(variable.LastIndexOf("i"));

            //Insert
            Console.WriteLine(variable.Insert(0,"Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(variable+variable2.PadLeft(30));
            Console.WriteLine(variable+variable2.PadLeft(30,'*'));
            Console.WriteLine(variable.PadRight(50)+variable2);
            Console.WriteLine(variable.PadRight(50,'-')+variable2);
            
            //Remove
            Console.WriteLine(variable.Remove(10));
            Console.WriteLine(variable.Remove(5,3));
            Console.WriteLine(variable.Remove(0,1));

            //Replace
            Console.WriteLine(variable.Replace("CSharp","C#"));
            Console.WriteLine(variable.Replace(" ","*"));

            //Split
            Console.WriteLine(variable.Split(' ')[1]);

            //Substring
            Console.WriteLine(variable.Substring(4));
            Console.WriteLine(variable.Substring(4,6));
        }
    }
}
