using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectAbstraction
{
    public class Subject:Student
    {
        private List<string> mandatory;
        private List<string> optional;


        public Subject(string name, double score, List<string> mandatory, List<string> optional):base(name,score)
        {
            this.Mandatory = mandatory;
            this.optional = optional;
        }

        public Subject()
        {

        }

        public List<string> Mandatory
        {
            get { return mandatory; }
            set
            {
                foreach (var subject in value)
                {
                    if (string.IsNullOrEmpty(subject))
                    {
                        throw new ArgumentNullException("Please enter mandatory subject");
                    }
                }

                this.mandatory = value;
            }
        }

        public List<string> Optional
        {
            get { return optional; }
            set
            {
                
                foreach (var subject in value)
                {


                    if (string.IsNullOrEmpty(subject) && subject != "None")
                    {
                        throw new ArgumentNullException("Please specify your optional subjects if there aren't any - type 'None'");
                    }
                }

                this.optional = value;
            }
        }

        public override string Count(List<Subject> subject)
        {
            int mandatoryStudents = 0;

            int optionalStudents = 0;

            mandatoryStudents = subject.Count();

            foreach (var item in subject)
            {
                if (item.Optional.Contains("None") == false)
                {
                    optionalStudents++;
                }
            }

            return $"Students studying mandatory subjects : {mandatoryStudents}\n" +
                $"Students studying optional subjects : {optionalStudents}";

           
        }

        
    }
}
