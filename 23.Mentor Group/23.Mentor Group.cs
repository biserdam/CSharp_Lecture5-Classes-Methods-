using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsList = new SortedDictionary<string, Student>();

            string inputString = null;
            while (inputString != "end of dates")
            {
                inputString = Console.ReadLine();
                if (inputString == "end of dates") break;

                var inputStringSplit = inputString.Split(new char[] { ' ', ',' });
                var studentName = inputStringSplit[0];
                var studentDatesList = new List<DateTime>();

                for (int i = 1; i < inputStringSplit.Length; i++) studentDatesList.Add(DateTime.ParseExact(inputStringSplit[i], "dd/MM/yyyy", null));
                Student newStudent = new Student(studentName, studentDatesList);
                if (!studentsList.Keys.Contains(studentName)) studentsList.Add(studentName, newStudent);
                else foreach (var date in studentDatesList)
                    {
                        studentsList[studentName].dates.Add(date);
                    }
            }

            string inputString2 = "";
            while (inputString2 != "end of comments")
            {
                inputString2 = Console.ReadLine();
                if (inputString2 == "end of comments") break;

                var inputStringSplit2 = inputString2.Split('-');
                var studentName2 = inputStringSplit2[0];
                var studentComment = inputStringSplit2[1];

                if (studentsList.Keys.Contains(studentName2))
                {
                    studentsList[studentName2].comments.Add(studentComment);
                }
            }

            foreach (var student in studentsList.Keys)
            {
                Console.WriteLine($"{studentsList[student].name}\nComments:");
                if (studentsList[student].comments.Count > 0) Console.WriteLine($"- {string.Join("\n- ", studentsList[student].comments)}");
                Console.WriteLine($"Dates attended:"); 
                studentsList[student].dates.Sort();
                foreach (var date in studentsList[student].dates)
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }

    public class Student
    {
        public string name;
        public List<string> comments;
        public List<DateTime> dates;

        public Student(string name, List<DateTime> dates)
        {
            this.name = name;
            this.dates = dates;
            comments = new List<string>();
        }

        public override string ToString()
        {
            return $"{name} -> {String.Join("; ", dates)} -> {comments}".ToString();
        }
    }
}
