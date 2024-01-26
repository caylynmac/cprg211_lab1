using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        //attributes (to be assigned in constructor??)
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public string fullName;

        //constructors 

        public Person()
        { }
        public Person(int idP, string firstNameP, string lastNameP, string colourP, int ageP, bool workingP)
        {
            this.personId = idP;
            this.firstName = firstNameP;
            this.lastName = lastNameP;
            this.favoriteColour = colourP;  
            this.age = ageP;
            this.isWorking = workingP;

            this.fullName = this.firstName + " " + this.lastName;
        }

        //methods
        public string DisplayPersonInfo() //display info in sentence
        {//how to put attributes as parameters?????
            
            return $"{personId}: {this.fullName}'s favorite colour is {this.favoriteColour}";
        }

        public void ChangeFavoriteColour() //change favourite colour to white
        {
            this.favoriteColour = "White";
        }

        public string GetAgeInTenYears() // return person age after 10 years
        {
            int newAge = this.age + 10;
            return $"{this.fullName}'s Age in 10 years is: {newAge}";
        }

        public override string ToString() // display person object info as a list
        {
            //string id; //shadows the global id variable ???????????????
            return $"PersonId: {this.personId} \n" +
                $"FirstName: {this.firstName} \n" +
                $"LastName: {this.lastName} \n" +
                $"FavoriteColour: {this.favoriteColour} \n" +
                $"Age: {this.age} \n" +
                $"IsWorking: {this.isWorking}";
        }


    }
}
