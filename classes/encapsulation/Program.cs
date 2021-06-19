using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student();
            student.Name="Feyza";
            student.SurName="Bilgiç";
            student.StudentNo="230";
            student.Class=3;
            student.BringStudentInformation();
            student.SkipClass();
            student.BringStudentInformation();

            Student student2=new Student();
            student2.Name="Emine";
            student2.SurName="Varol";
            student2.StudentNo="235";
            student2.Class=1;
            student2.BringStudentInformation();
            student2.Downgrade();
            student2.Downgrade();
            student2.BringStudentInformation();
        }
    }
    class Student
    {
        private string name;
        private string surName;
        private string studentNo;
        private int _class;

        public string Name
        {
            get {return name;}
            set {name = value;} 
        }

        public string SurName { get => surName; set => surName = value; }
        public string StudentNo { get => studentNo; set => studentNo = value; }
        public int Class
         { 
             get => _class; 
             set 
             {
                 if(value<1){
                     Console.WriteLine("Sınıf en az 1 olabilir");
                     _class=1;
                 }
                 else
                 _class = value; 
             } 
             }
        public Student()
        {

        }
        public Student(string name,string surName,string studentNo,int _class)
        {
            Name=name;
            SurName=surName;
            StudentNo=studentNo;
            Class=_class;
        }
        public void BringStudentInformation()
        {
            Console.WriteLine("******* Öğrenci Bilgileri ************");
            Console.WriteLine("Öğrenci Adı         :{0}",this.name);
            Console.WriteLine("Öğrenci SoyAdı      :{0}",this.surName);
            Console.WriteLine("Öğrenci Numarası     :{0}",this.studentNo);
            Console.WriteLine("Öğrenci Sınıfı    :{0}",this._class);            
        }
        public void SkipClass()
        {
            this.Class=this._class+1;
        }
        public void Downgrade()
        {
            this.Class=this._class-1;
        }
    }
}
