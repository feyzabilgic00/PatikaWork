using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int value=2;
            Console.WriteLine(value);
            string variable=null;
            string Variable=null;
            string variable_data="C# programlama";
            Console.WriteLine(variable_data);
            String variable2=" ";
            //if(variable2==" ")
            byte _byte=1;
            Console.WriteLine("Byte: "+_byte+" byte'lık yer kaplar.");
            sbyte _sbyte=1;
            Console.WriteLine("Sbyte: "+_sbyte+" byte'lık yer kaplar.");
            short _short=2;
            Console.WriteLine("Short: "+_short+" byte'lık yer kaplar.");
            ushort _ushort=2;
            Console.WriteLine("UShort: "+_ushort+" byte'lık yer kaplar.");

            Int16 i16=2;
            int _int=4;
            Console.WriteLine("Int: "+_int+" byte'lık yer kaplar.");
            Int32 i32=2;
            Int64 i64=8;

            uint _uint=4;
            Console.WriteLine("UInt: "+_uint+" byte'lık yer kaplar.");
            long _long=8;
            Console.WriteLine("Long: "+_long+" byte'lık yer kaplar.");
            ulong _ulong=8;
            Console.WriteLine("ULong: "+_ulong+" byte'lık yer kaplar.");
            float _float=4;
            Console.WriteLine("Float: "+_float+" byte'lık yer kaplar.");
            double _double=8;
            Console.WriteLine("Double: "+_double+" byte'lık yer kaplar.");
            decimal _decimal=16;        
            Console.WriteLine("Decimal: "+_decimal+" byte'lık yer kaplar.");
            char _char='2';  
            Console.WriteLine("Char: "+_char+" byte'lık yer kaplar."); 
            string _string="Sınırsız değer alır.";
            Console.WriteLine("String: "+_string);
            bool bt=true;
            bool bf=false;

            DateTime dateTime=DateTime.Now;
            Console.WriteLine(dateTime);

            object _object="x";
            object _object2="y";
            object _object3=4;
            object _object4=4.3;

            //string ifadeler
            string str1=string.Empty;
            str1="Feyza Bilgiç";
            string name="Feyza";
            string surname="Bilgiç";
            string nameSurname=name+" "+surname;
            Console.WriteLine(nameSurname);

            //integer tanımlama şekilleri
            int _integer=5;
            int _integer2=3;
            int _integerSum=_integer+_integer2;
            Console.WriteLine(_integerSum);

            //bool ifadeler
            bool _bool2=10<2;
            Console.WriteLine(_bool2);

            //Değişken Dönüşümleri
            string str2="20";
            int _integer3=20;
            string newValue=str2+_integer3.ToString();
            Console.WriteLine(newValue);
            int _integer4=_integer3+Convert.ToInt32(str2);
            Console.WriteLine(_integer4);
            int _integer5=_integer4+int.Parse(str2);
            Console.WriteLine(_integer5);

            //datetime
            string dateTime2=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime2);
            string dateTime3=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime3);
            string hour=DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
