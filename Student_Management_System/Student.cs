using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class Student
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        public void Display()
        {
            Console.WriteLine("Fullname: " + FullName);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Date of Birth: " + DateofBirth);
            Console.WriteLine("Native: " + Native);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Phone number: " + PhoneNo);
            Console.WriteLine("Mobile: " + Mobile);
        }
    }
}
