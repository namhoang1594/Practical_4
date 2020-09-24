using System;
using System.Collections.Generic;
using System.Text;

namespace Marks_Management_System
{
    class StudentMark : IStudentMark
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public float AverageMark;
        public float GetAverageMark()
        {
            return AverageMark;
        }
        public void Display()
        {
            Console.WriteLine("Full name :" + FullName);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Class :" + Class);
            Console.WriteLine("Semeter :" + Semester);
            Console.WriteLine("AverageMark :" + AverageMark);
        }
        int[] SubjectMarkList = new int[5];
        public int this[int index]
        {
            get
            {
                return SubjectMarkList[index];
            }
            set
            {
                SubjectMarkList[index] = value;
            }
        }
        public void AveCal()
        {
            AverageMark = (float)(SubjectMarkList[0] + SubjectMarkList[1] + SubjectMarkList[2] + SubjectMarkList[3] + SubjectMarkList[4]) / 5;
        }
    }
}
