using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
             internal class Group 
    {
        private Student[] students = new Student[0];
        private int _studentlimit;
        
        
        public Group(int studentlimit,string groupno)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
        public string GroupNo { get; set; }
        public int StudentLimit 
        { 
            get=>this._studentlimit;
            set
            {
                if (_studentlimit>5 && _studentlimit<18)
                {
                    _studentlimit = value;
                }
            }
        }
        public bool CheckGroupNo(string groupno)
        {
            bool HisUpper = false;
            bool HisDigit = false;
            for (int i = 0; i < groupno.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(groupno) && char.IsUpper(groupno[0]) && char.IsUpper(groupno[1]) && char.IsDigit(groupno[i]) && groupno.Length<6)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Ilk 2 herfi Boyuk ve 3 reqemden ibaret olmalidir ");
                }              
            }
            return true;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students,students.Length + 1);
            students[students.Length - 1] = student;
        }
        public void GettAllStudents()
        {
            foreach (var item in students)
            {
                item.ShowInfo();
            }
        }

        public Student GetStudent(int? Id)
        {
            Student telebe = null; 
            var test = false;
            if (!(Id == null))
            {
                foreach (var item in students)
                {
                    if (item.Id == Id)
                    {
                       
                        test= true;
                    }
                    else
                    {
                        Console.WriteLine("Bu Id StudentYoxdur!");
                    }
                }
            }
            return telebe;
           
            
        }
            }
            Userrrrr 
                 class User : IAccount
    {
        private int _id;
        private User()
        {
            _id++;
            ID = _id;
        }
        public User(string email,string password):this()
        {
            Email = email;
            Password = password;
          
        }
        public int ID { get;}
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool PasswordChecker(string password)
        {
            bool HisUpper = false;
            bool HisLower = false;
            bool HisDigit = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(password) && char.IsUpper(password[0]) && char.IsLower(password[i]) && char.IsDigit(password[i]))
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{ID}--FullName:{Fullname}---Email:{Email}---Password{Password}");
        }
        }
            Studentttt
                  public class Student
    {
        private static int _id;
        public int Id { get;}
        public string FullName { get; set; }
        public double Point { get; set; }
        private Student()
        {

            _id++;
            Id = _id;

        }
        public Student(string fullname,double point):this()
        {
            Point = point;
            FullName = fullname;
            
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}--FullName:{FullName}---Point:{Point}");
        }
        public void CreateStudent()
        {
            Console.WriteLine("FullName daxil edinn:");
            FullName = Console.ReadLine();
            Console.WriteLine("Point daxil edin:");
            Point = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yeni Group Yarandi");
            Console.WriteLine($"GroupNo:{FullName}---StudentLimit:{Point}");
        }
                      Prograaammmm
                          //User user = new User("huseynli.elmin@mail.ru", "As111");
            //Student student = new Student("Elmin", 99);
            //student.ShowInfo();
            //Group group = new Group(6, "AP203");
            Student student = new Student("Elmin ",100);
            Student student2 = new Student("Elmin ",100);
            //student.ShowInfo();
            //student2.ShowInfo();
            Group group = new Group(7,"ab123");
            
            group.AddStudent(student);
            group.AddStudent(student2);
            group.CheckGroupNo



            
            //     Console.WriteLine("1.Show Info");
            //     Console.Write("2.Create new Group");

            //     int command = Convert.ToInt32(Console.ReadLine());
            //     bool loop = true;
            //      while (true)
            //     {
            //         switch (command)
            //         {
            //             case 1:
            //                 user.ShowInfo();
            //                 break;
            //             case 2:
            //                 //group.CreateNewGroup();
            //                 break;
            //             default:
            //                 Console.WriteLine("Wrong input");
            //                 break;
            //         }
            //         if (loop!=false)
            //         {
            //             break;
            //         }
            //     }
            //     Console.WriteLine("1.Show AllStudents");
            //     Console.WriteLine("2.GetById");
            //     Console.WriteLine("3.AddStudent");
            //     Console.WriteLine("0.Quit");

            //     int command1 = Convert.ToInt32(Console.ReadLine());
            //     bool loop1 = true;
            //     while (true)
            //     {
            //         switch (command1)
            //         {
            //             case 1:
            //                 student.ShowInfo();
            //                 break;
            //             case 2:
            //                 Console.WriteLine(group.GetStudent(2).FullName);
            //                 break;
            //             case 3:
            //                 student.CreateStudent();
            //                 break;
            //             case 0:

            //                 break;
            //             default:
            //                 Console.WriteLine("Wrong input");
            //                 break;
            //         }
            //         if (loop1 != false)
            //         {
            //             break;
            //         }
            //     }
            // }
            // public static void CreateNewGroup()
            //{
            //     AddStudent();
            // }

            // private static void AddStudent()
            // {
            //     throw new NotImplementedException();
            // }
    }
    }
}
