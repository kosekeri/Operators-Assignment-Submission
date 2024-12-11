using System;

namespace EmployeeOperatorOverload
{
    // Step 1: Create the Employee class with properties Id, FirstName, and LastName
    public class Employee
    {
        public int Id { get; set; } // Employee's Id property
        public string FirstName { get; set; } // Employee's FirstName property
        public string LastName { get; set; } // Employee's LastName property

        // Step 2: Overload the "==" operator to compare two Employee objects based on their Id property
        public static bool operator ==(Employee e1, Employee e2)
        {
            // Check if the Ids are equal, and return true if they are
            return e1.Id == e2.Id;
        }

        // Step 3: Overload the "!=" operator to compare two Employee objects based on their Id property
        public static bool operator !=(Employee e1, Employee e2)
        {
            // Return the negation of the equality check
            return e1.Id != e2.Id;
        }

        // Step 4: Override the Equals method for comparing two Employee objects based on their Id property
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return this.Id == other.Id;
            }
            return false;
        }

        // Step 5: Override the GetHashCode method because Equals was overridden
        public override int GetHashCode()
        {
            return this.Id.GetHashCode(); // Return the hash code based on Id
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 6: Create two Employee objects with the same Id
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Step 7: Use the overloaded "==" operator to compare the two Employee objects
            if (emp1 == emp2) // This uses the overloaded "==" operator
            {
                Console.WriteLine("The employees are the same.");
            }
            else
            {
                Console.WriteLine("The employees are different.");
            }

            // Step 8: Use the overloaded "!=" operator to compare the two Employee objects
            if (emp1 != emp2) // This uses the overloaded "!=" operator
            {
                Console.WriteLine("The employees are different.");
            }
            else
            {
                Console.WriteLine("The employees are the same.");
            }

            // Pause the console to view the output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

