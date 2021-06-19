using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Working working=new Working();
            working.Name="Feyza";
            working.Surname="Bilgiç";
            working.No=56987;
            working.Department="Backend Departmanı";

            working.WorkingInformation();
            Console.WriteLine("**************");
            Working working2=new Working();
            working2.Name="Cahide";
            working2.Surname="Sara";
            working2.No=12345;
            working2.Department="Satın Alma Departmanı";

            working2.WorkingInformation();
        }
    }
    class Working
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public string Department { get; set; }

        public void WorkingInformation()
        {
            Console.WriteLine("Çalışan Adı: {0}",Name);
            Console.WriteLine("Çalışan Soyadı: {0}",Surname);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Department);
        }
    }
}
