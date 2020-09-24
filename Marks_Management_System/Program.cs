using System;
using System.Collections.Generic;

namespace Marks_Management_System
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
            Console.WriteLine("3. Average Mark");
            Console.WriteLine("4. Exit");
            do
            {
                Console.WriteLine("\n Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.InsertStudent();
                        break;
                    case 2:
                        program.ViewlistStudent();
                        break;
                    case 3:
                        program.AverageMarks();
                        break;
                    case 4: return;
                }
            }
            while (choice != 4);
        }
        int count = 0;
        Dictionary<int, StudentMark> stdmark = new Dictionary<int, StudentMark>();
        public void InsertStudent()
        {
            StudentMark studentMark = new StudentMark();
            studentMark.ID = count;
            Console.WriteLine("Fullname: ");
            studentMark.FullName = Console.ReadLine();
            Console.WriteLine("Class: ");
            studentMark.Class = Console.ReadLine();
            Console.WriteLine("Semester: ");
            studentMark.Semester = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter 5 marks of subject " + (i + 1) + ":");
                studentMark[i] = int.Parse(Console.ReadLine());

            }
            stdmark.Add(count, studentMark);
            count++;
        }
        public void ViewlistStudent()
        {
            foreach (StudentMark item in stdmark.Values)
            {
                item.Display();
            }
        }
        public void AverageMarks()
        {
            foreach (StudentMark item in stdmark.Values)
            {
                item.Display();
                item.AveCal();
            }
        }
    }
}
