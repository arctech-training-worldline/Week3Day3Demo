using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day3Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }

        static void Test3()
        {
            string path = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\TrainingFileTest\File2.txt";
            string[] lines = { "Hello World", "This is line 2 of the paragraph", "End of para" };


            if (File.Exists(path))
            {
                Console.Write("File already exists. Do you want to (O)verwrite or (A)ppend? ");
                string ch = Console.ReadLine();

                if (ch == "O")
                {
                    StreamWriter sw = new StreamWriter(path);
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();

                    //File.WriteAllLines(path, lines);
                }
                else if (ch == "A")
                {
                    StreamWriter sw = new StreamWriter(path, true);
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                    //File.AppendAllLines(path, lines);
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
                //File.WriteAllLines(path, lines);
            }

            //File.AppendAllLines(@"C:\Users\avina\OneDrive - arctechinfo.com\Documents\TrainingFileTest\File2.txt", lines);

            //FileStream fs = File.OpenWrite(@"C:\Test1.txt");
            //StreamWriter sw = new StreamWriter(fs);

        }

        static void Test1()
        {
            Int64 x;
            try
            {
                StreamWriter sw = new StreamWriter(File.OpenWrite(@"C:\Test1.txt"));

                sw.WriteLine("Hello World");

                sw.Close();


                //Open the File
                //StreamWriter sw = new StreamWriter("C:\\Test1.txt");//, true, Encoding.ASCII);

                ////Write out the numbers 1 to 10 on the same line.
                //for (x = 0; x < 10; x++)
                //{
                //    sw.Write(x);
                //}

                ////close the file
                //sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        static void Test2()
        {
            /*
             * 
             * StreamWriter is used to create a test file
             * 
             * 
             */
            try
            {
                //StreamWriter streamWriter = new StreamWriter(@"C:\File1.txt");
                StreamWriter streamWriter = new StreamWriter(@"C:\Users\avina\OneDrive - arctechinfo.com\Documents\TrainingFileTest\File1.txt");

                streamWriter.WriteLine("N.C Tiwai \n Seema Tiwari \n AkritiTiwari\n Ayushi Tiwari");
                Console.WriteLine("from streamWriter class");
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
        }
    }
}
