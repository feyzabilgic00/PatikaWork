using System;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Çalışan Sayısı:  {0}",Working.WorkingCount);
            Working working =new Working("Feyza","Bilgiç","Bilgisayar Mühendisi");            
            Console.WriteLine("***** Çalışan Sayısı:  {0}",Working.WorkingCount);
            Working working2 =new Working("Deniz","Kılıç","Bilgisayar Mühendisi");
            Working working3 =new Working("Fahriye","Akkuzu","Bilgisayar Mühendisi");
            Console.WriteLine("***** Çalışan Sayısı:  {0}",Working.WorkingCount);

            Console.WriteLine("Toplama işlemi sonucu:{0}",Transactions.Sum(2,3));
            Console.WriteLine("Çıkarma işlemi sonucu :{0}",Transactions.Eject(2,3));

        }
    }
    class Working
    {
        private static int workingCount;
        public static int WorkingCount { get => workingCount; set => workingCount = value; }
        private string name;
        private string surName;
        private string department;
        static Working()
        {
            workingCount=0;            
        }
        public Working(string name,string surName,string department)
        {
            this.name=name;
            this.surName=surName;
            this.department=department;
            workingCount++;
        }
    }
    
        public class Transactions
        {
            public static long Sum(int number1,int number2)
            {
                return number1+number2;
            }
             public static long Eject(int number1,int number2)
            {
                return number1-number2;
            }
        }
}
