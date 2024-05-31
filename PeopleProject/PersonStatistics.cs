using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class PersonStatistics
    {
        private List<Person> persons;

        public PersonStatistics(List<Person> persons)
        {
            this.persons = persons;
        }

        internal List<Person> Persons { get => persons; private set => persons = value; }
    }
}
