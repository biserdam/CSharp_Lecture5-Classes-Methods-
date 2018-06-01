using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                var inputString = Console.ReadLine().Split(' ');
                var gradesArray = new double[inputString.Length - 1];
                for (int j = 0; j < inputString.Length - 1; j++)
                {
                    gradesArray[j] = double.Parse(inputString[j + 1]);
                }
                studentsList.Add(new Student(inputString[0], gradesArray));
            }
            //Console.WriteLine(string.Join(",", studentsList)); - how to print such a list from class Student?
            var resultList = from s in studentsList where s.averageGrade >= 5.00 select s;
            List<Student> resultListOrdered = resultList.OrderBy(s => s.name).ThenByDescending(s => s.averageGrade).ToList();
            foreach (var person in resultListOrdered)
            {
                Console.WriteLine($"{person.name} -> {person.averageGrade:f2}");
            }
        }
    }

    public class Student
    {
        public string name;
        public double[] grades;
        public double averageGrade;

        public Student(string name, double[] grades)
        {
            this.name = name;
            this.grades = grades;
            averageGrade = grades.Average();
        }

        //public override string ToString()
        //{
        //
        //    return $"hiuuojo"
        //}

    }
}
