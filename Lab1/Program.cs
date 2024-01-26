using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args) // delete after, make main class????
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            //supposed to read these from file?


            //Display Gina's info as a sentence
            Console.WriteLine(person2.DisplayPersonInfo());

            //Display mike's info as a list
            Console.WriteLine(person3);

            //change ian's favourite colour to white and print sentence
            person1.ChangeFavoriteColour();
            Console.WriteLine(person1.DisplayPersonInfo());

            //display mary's age in 10 years
            Console.WriteLine(person4.GetAgeInTenYears());

            //create 2 relation objects, display relationships
            //the grammar provided in the lab wouldn't really make sense in the case of brother-sister, mother-daughter etc. relationships
            Relation sisters = new Relation(person2, person4, "Sisterhood");
            Relation brothers = new Relation(person1, person3, "Brotherhood");
            Console.WriteLine(sisters.ShowRelationship());
            Console.WriteLine(brothers.ShowRelationship());

            //add all person objects to list, then display average age, youngest and oldest, M names, who likes blue
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            float totalAge = 0;
            float avgAge;

            //blank person objects to reassign found objects to
            Person youngest = new Person();
            youngest.age = 140;
            Person oldest = new Person();
            oldest.age = 0;
            List<Person>mNames = new List<Person>();
            List<Person>blueLovers = new List<Person>();

            foreach (Person person in people)
            {
                totalAge = totalAge + person.age;
              
                //find youngest
                if (person.age < youngest.age)
                {
                    youngest = person;
                }

                //find oldest
                if (person.age > oldest.age)
                {
                    oldest = person;
                }

                //find M names
                if (person.firstName[0] == 'M')
                {
                    mNames.Add(person);
                }

                //find who likes blue
                if ((person.favoriteColour).Equals("Blue"))
                {
                    blueLovers.Add(person);
                }
            }
            avgAge = totalAge / 4;
            Console.WriteLine($"Average age is: {avgAge}");
            Console.WriteLine($"The youngest person is: {youngest.firstName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName}");
            foreach (Person m in mNames)
            {
                Console.WriteLine(m);
            }

            foreach (Person blue in blueLovers)
            {
                Console.WriteLine(blue);
            }

        }
    }
}
