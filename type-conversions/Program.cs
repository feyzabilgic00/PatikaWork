using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm)
            //Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli
            //bir değişkene dönüştürme işlemidir.
            Console.WriteLine("****** İmplicit Conversion *******");
            byte _byte=5;
            sbyte _sbyte=30;
            short _short=10;
            int _int=_byte+_sbyte+_short;
            Console.WriteLine("_int: "+_int);

            long _long=_int;
            Console.WriteLine("_long: "+_long);

            float _float=_long;
            Console.WriteLine("_float: "+_float);

            string _string="Feyza";
            char _char='B';
            object _object=_string+_char+_int;
            Console.WriteLine("_object: "+_object);

            //Explicit Conversion(Bilinçli Dönüşüm)
            Console.WriteLine("****** Explicit Conversion *******");
            int _int2=4;
            byte _byte2=(byte)_int2;
            Console.WriteLine("_byte2: "+_byte2);

            int _int3=100;
            byte _byte3=(byte)_int3;
            Console.WriteLine("_byte3: "+_byte3);

            float _float2=10.3f;
            byte _byte4=(byte)_float2;
            Console.WriteLine("_float: "+_byte4);

            //ToString Metodu
            Console.WriteLine("**** ToString Metodu *********");
            int _int4=6;
            string _string2=_int4.ToString();
            Console.WriteLine("_string2: "+_string2);

            string _string3=12.5f.ToString();
            Console.WriteLine("_string3: "+_string3);

            //System.Convert
            Console.WriteLine("**** System.Convert Sınıfı *****");
            string _string4="10",_string5="20";
            int number1,number2;
            int Sum;

            number1=Convert.ToInt32(_string4);
            number2=Convert.ToInt32(_string5);

            Sum=number1+number2;            
            Console.WriteLine("Sum: "+Sum);

            //Parse
            Console.WriteLine("**** Parse Metodu **********");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string _string="10";
            string _string2="10.25";
            int _number;
            double _double;

            _number=Int32.Parse(_string);
            _double=double.Parse(_string2);

            Console.WriteLine("_number: "+_number);
            Console.WriteLine("_double: "+_double);
        }
    }
}
