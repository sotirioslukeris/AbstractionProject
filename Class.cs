using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAbstraction
{
    public class Class
    {
        private int grade;
        private string gradeName;

        public Class(int grade, string gradeName)
        {
            this.Grade = grade;
            this.GradeName = gradeName;
        }

        public Class()
        {

        }
        public int Grade
        {
            get { return grade; }
            set
            {

                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("The grades are 1-12");
                }

                grade = value;
            }
        }


        public string GradeName
        {
            get { return gradeName; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please specify the grade name");
                }

                gradeName = value;
            }
        }




    }
}
