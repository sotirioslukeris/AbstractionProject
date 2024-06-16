using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace ProjectAbstraction
{
    public abstract class Student:IPrint,IComparable<Student>
    {
        protected string name;
        protected double score;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
        }

        public Student()
        {

        }
        
        public string Print(Subject subject, Class grade)
        {
            return $"Name : {name}\nScore : {score}\n Class : {grade.Grade}\n" +
                $"Grade name : {grade.GradeName}\n Mandatory : {string.Join(" ",subject.Mandatory)}\n" +
                $"Optional : {string.Join(" ",subject.Optional)}\n\n";
        }

        public abstract string Count(List<Subject> subjects);

        public List<Student> HighestScore(List<Student> students)
        {
            double topScore = students.Max(x => x.score);

            students = students.Where(x => x.score == topScore).ToList();
            
            return students;
        }

        public int CompareTo(Student other)
        {
            return this.score.CompareTo(other.score);
        }

        public List<Student> Find(string name,List<Student> students)
        {
            students = students.Where(x => x.name == name).ToList();

            return students;

            
        }
    }
}
