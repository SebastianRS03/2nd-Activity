using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Activity
{
    internal class Register
    {
        private List<Person> people;
        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public Register()
        {
            Console.WriteLine("================ System messages ===============");
            this.people = new List<Person>();
        }

        public void addPeople(Person person)
        {
            this.people.Add(person);
        }

        public void printData()
        {
            foreach (Person person in people)
            {
                person.showPerson();
            }
        }
    }
}
