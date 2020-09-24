using System;
using System.Collections.Generic;
using System.Text;

namespace Marks_Management_System
{
    interface IStudentMark
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public float AverageMark { get; }
        void Display();
    }
}
