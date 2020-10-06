using CSharpComponent.Models;
using System;

namespace CSharpComponent
{
    public class SomeFunctionality
    {
        public Person GetPersonDetails(Person details)
        {
            return new Person
            {
                FirstName = "First Name provided was: " + details.FirstName,
                LastName = "Last Name provided was: " + details.LastName,
                Age = details.Age
            };
        }

   
    }
}
