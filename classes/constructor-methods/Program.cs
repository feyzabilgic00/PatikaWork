using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Working working=new Working("Feyza","Bilgiç",12389,"Backend Departmanı");
            working.WorkingInformation();
            Console.WriteLine("**************");

            Working working2=new Working();
            working2.Name="Cahide";
            working2.Surname="Sara";
            working2.No=12345;
            working2.Department="Satın Alma Departmanı";
            working2.WorkingInformation();
            Console.WriteLine("**************");

            Working working3=new Working("Feyza","Bilgiç");
            working3.WorkingInformation(); 
        }
    }
    class Working
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public string Department { get; set; }
        public Working()
        {
            
        }
        public Working(string name,string surname,int no,string department)
        {
            Name=name;
            Surname=surname;
            No=no;
            Department=department;
        }
        public Working(string name,string surname)
        {
            Name=name;
            Surname=surname;
        }
        public void WorkingInformation()
        {
            Console.WriteLine("Çalışan Adı: {0}",Name);
            Console.WriteLine("Çalışan Soyadı: {0}",Surname);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Department);
        }
    }
}
