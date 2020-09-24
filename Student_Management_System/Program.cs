using System;
using System.Collections;
using System.Collections.Generic;

namespace Student_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            Console.WriteLine("STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert new Student");
            Console.WriteLine("2. View list of Stdent");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Exit");
            do
            {
                Console.WriteLine("\n Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.InsertnewStudent();
                        break;
                    case 2:
                        program.ViewlistofStudent();
                        break;
                    case 3:
                        program.SearchStudent();
                        break;
                    case 4: return;
                }
            }
            while (choice != 4);
        }
        int count = 0;
        Dictionary<int, Student> std = new Dictionary<int, Student>();
        public void InsertnewStudent()
        {
            Student student = new Student();
            student.ID = count;
            Console.WriteLine("Full name of Student: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Date of Birth: ");
            student.DateofBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Native: ");
            student.Native = Console.ReadLine();
            Console.WriteLine("Class: ");
            student.Class = Console.ReadLine();
            Console.WriteLine("Phone number: ");
            student.PhoneNo = Console.ReadLine();
            Console.WriteLine("Mobile: ");
            student.Mobile =int.Parse(Console.ReadLine());
            std.Add(count,student);
            count++;
        }
        public void ViewlistofStudent()
        {
            foreach (var item in std.Values)
            {
                item.Display();
            }

        }
        public void SearchStudent()
        {
            
            Console.WriteLine("Enter name of student want to search: ");
            string name = Console.ReadLine();
            foreach (var item in std.Values)
                if (item.FullName.Equals(name))
                {
                    item.Display();
                    break;
                }
            else
                {
                    Console.WriteLine("Not found!!");
                }    
        }
    }

}
