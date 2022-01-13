using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day3Demo
{
    internal class WriteAndReadSampleSimpleFormat
    {
        private static string path = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\TrainingFileTest\FileStudentsSimple.txt";

        internal static void SaveStudentsToFile()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("101", "Raman", 10));
            students.Add(new Student("102", "Shweta", 10));
            students.Add(new Student("103", "Kongro", 10));

            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.WriteLine("RollNo,Name,Age");
            foreach (Student student in students)
            {
                sw.WriteLine($"{student.RollNo},{student.Name},{student.Age}");
            }
            sw.Close();
        }

        internal static void ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(File.OpenRead(path));

            sr.ReadLine(); //Ignore header line

            do
            {
                string line = sr.ReadLine();
                string[] columns = line.Split(',');

                Student s = new Student();
                s.RollNo = columns[0];
                s.Name = columns[1];
                s.Age =  int.Parse(columns[2]);

                students.Add(s);

            } while (!sr.EndOfStream);

            sr.Close();
        }
    }
}
