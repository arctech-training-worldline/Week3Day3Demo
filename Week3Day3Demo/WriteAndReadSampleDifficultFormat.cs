using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day3Demo
{
    internal class WriteAndReadSampleDifficultFormat
    {
        private static string path = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\TrainingFileTest\FileStudentsDifficult.txt";

        internal static void SaveStudentsToFile()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("101", "Raman", 10));
            students.Add(new Student("102", "Shweta", 10));
            students.Add(new Student("103", "Kongro", 10));

            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            foreach (Student student in students)
            {
                sw.WriteLine($"Student: RollNo={student.RollNo}, Name={student.Name}, Age={student.Age}");
            }
            sw.Close();
        }

        internal static void ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(File.OpenRead(path));

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
