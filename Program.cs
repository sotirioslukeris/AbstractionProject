using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAbstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Class grade = new Class();

            Student student = new Subject();

            try
            {

                char subsection;

                Console.WriteLine("Program menu :");

                Console.WriteLine("a - Insert data of students");

                Console.WriteLine("b - Print the information of the students");

                Console.WriteLine("c - Print the information of all namesake students");

                Console.WriteLine("d - The number of students that study optional and mandatory subjects");

                Console.WriteLine("e - Information of the student with the highest score");

                Console.WriteLine("f - The ascending order of students by score");

                Console.WriteLine("0 - Exit");

                Console.WriteLine();

                List<Student> studentList = new List<Student>();

                List<Subject> subjectList = new List<Subject>();

                List<Class> gradeList = new List<Class>();



                do
                {
                    Console.Write("Enter the character of the desired subsection : ");
                    subsection = char.Parse(Console.ReadLine());



                    switch (subsection)
                    {
                        case 'A':
                        case 'a':

                            Console.Write("Enter the number of students : ");
                            int n = int.Parse(Console.ReadLine());

                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("Enter the student's name : ");
                                string name = Console.ReadLine();

                                Console.Write("Enter the student's score : ");
                                double score = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the mandatory subjects with a space in between");
                                var mandatory = Console.ReadLine().Split(' ').ToList();

                                Console.WriteLine("Enter the optional subjects with a space in between");
                                var optional = Console.ReadLine().Split(' ').ToList();

                                Console.Write("Enter the grade : ");

                                int gradeNum = int.Parse(Console.ReadLine());

                                Console.Write("Enter the grade name : ");

                                string gradeName = Console.ReadLine();

                                 student = new Subject(name, score, mandatory, optional);


                                subject = new Subject(name, score, mandatory, optional);

                                grade = new Class(gradeNum, gradeName);

                                studentList.Add(student);

                                subjectList.Add(subject);

                                gradeList.Add(grade);

                                Console.WriteLine();


                            }

                            break;

                        case 'B':
                        case 'b':
                           
                               studentList.ForEach(x => Console.WriteLine(x.Print(subject,grade)));
                                
                            
                            break;

                        case 'C':
                        case 'c':

                            Console.WriteLine("Student to be found : ");
                            string findStudent = Console.ReadLine();


                          

                            var find  = student.Find(findStudent, studentList).ToList();




                            


                            foreach (var item in find)
                            {

                                Console.WriteLine(item.Print(subject, grade));

                            }



                            break;

                        case 'D':
                        case 'd':

                            string count = subject.Count(subjectList);

                            Console.WriteLine(count);


                            break;

                        case 'E':
                        case 'e':

                            var highestScore = subject.HighestScore(studentList).ToList();

                            
                            foreach (var item in highestScore)
                            {

                                Console.WriteLine(item.Print(subject, grade));

                            }

                            break;




                        case 'F':
                        case 'f':

                            studentList.Sort();

                            

                            foreach (var item in studentList)
                            {

                                Console.WriteLine(item.Print(subject, grade));

                            }

                            break;

                        case '0':

                            Console.WriteLine("The program has exited");
                            return;
                    }


                }
                while (subsection != '0');


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
        }


    }
}
