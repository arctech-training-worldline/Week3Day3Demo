using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day3Demo
{
    class Student
    {
        public string RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string rollNo, string name, int age)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
        }

        public Student()
        {
        }
    }

    internal class WriteAndReadSample
    {
        private static string path = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\TrainingFileTest\FileStudents.txt";

        internal static void SaveStudentsToFile()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("101", "Raman", 10));
            students.Add(new Student("102", "Shweta", 10));
            students.Add(new Student("103", "Kongro", 10));

            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.WriteLine($"|{"RollNo",-10}|{"Name",-20}|{"Age",5}|");
            foreach (Student student in students)
            {
                sw.WriteLine($"|{student.RollNo,-10}|{student.Name,-20}|{student.Age,5}|");
            }
            sw.Close();
        }

        internal static void ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(File.OpenRead(path));

            sr.ReadLine();  // Ignore it as it is the header

            do
            {
                string line = sr.ReadLine();
                string[] columns = line.Split('|');

                Student s = new Student();
                s.RollNo = columns[1].Trim();
                s.Name = columns[2].Trim();
                s.Age =  int.Parse(columns[3].Trim());

                students.Add(s);
                Console.WriteLine(columns.Length);

            } while (!sr.EndOfStream);


            sr.Close();
        }
    }
}
