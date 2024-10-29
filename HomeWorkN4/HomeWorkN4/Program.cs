using System;
using System.ComponentModel.DataAnnotations;

namespace HomeWorkN4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Write student name - ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("Student names:");
            for (int j = 0; j < students.Length; j++)
            {
                Console.WriteLine(students[j]);
            }

            int[,] grades = new int[3, 2];


            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("student: " + students[i]);
                Console.Write("1st subject grade: ");
                grades[i, 0] = int.Parse(Console.ReadLine());
                Console.Write("2nd subject grade: ");
                grades[i, 1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Students and grades:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i] + " - 1st subject: " + grades[i, 0] + "; 2nd subject: " + grades[i, 1]);
            }
        }
    }
}




