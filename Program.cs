
using System;

namespace Phase1Section5._4
{
    class Program
    {


        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {

            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter name of student");
                students[i].name =Console.ReadLine();
                Console.WriteLine("Enter Adress of student");
                students[i].address = Console.ReadLine(); ;
                students[i].rollNumber = i;
                Console.WriteLine("Enter Class Name");
                students[i].className = Console.ReadLine();
                students[i].dateOfBirth = Convert.ToDateTime("1992-09-10 10:10:10");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].name + ",");
                Console.Write(students[i].address + ",");
                Console.Write(students[i].rollNumber + ",");
                Console.Write(students[i].className + ",");
                Console.Write(students[i].dateOfBirth+ "\n");
                
            }
        }
    }

    struct Student
    {
        public string name;
        public string address;
        public int rollNumber;
        public string className;
        public DateTime dateOfBirth;
    }
}
