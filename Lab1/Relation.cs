using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relation
    {

        public Person person1;
        public Person person2;
        public string relationshipType;

        public Relation(Person person1, Person person2, string relationship)
        {
            this.person1 = person1;
            this.person2 = person2;
            this.relationshipType = relationship; 
        }

        public string ShowRelationship()
        {
            return $"Relationship between {this.person1.firstName} and {this.person2.firstName} is: {this.relationshipType}";
        }
    }
}
