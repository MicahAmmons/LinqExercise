using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"The Sum is {sum}");
            Console.WriteLine();
            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine($"The Average is {average}");
            Console.WriteLine();
            //TODO: Order numbers in ascending order and print to the console
           
            
            var ascendingOrder = numbers.OrderBy( x => x);
           
            
            foreach (var i in ascendingOrder)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            
            
            //TODO: Order numbers in descending order and print to the console
            var reverseOrderedArray = numbers.OrderByDescending( x => x);
            foreach (var i in reverseOrderedArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            var greaterThan6 = numbers.Where( x => x > 6 );
            foreach (var i in greaterThan6)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            foreach (var i in ascendingOrder.Take(4))
            {  
                Console.WriteLine(i); 
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 27;
            foreach (var i in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var onlyFirstNamesStartWithCOrS = employees
                .Where(employee => employee.FirstName.ToLower().StartsWith('c') ||
                                   employee.FirstName.ToLower().StartsWith('s'))
                                   .OrderBy(employee => employee.FirstName);
            foreach (var i in onlyFirstNamesStartWithCOrS)
            {
                Console.WriteLine(i.FullName);
            }
            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var over26FullNameAndAgeOrderByNameThenAge = employees
                .Where(employee => employee.Age > 26)
                .OrderBy(employee => employee.Age)
                .OrderBy(employee => employee.FirstName);
            foreach (var i in over26FullNameAndAgeOrderByNameThenAge)
            {
                Console.WriteLine($"Name: {i.FullName} Age: {i.Age}");
            }
            Console.WriteLine() ;

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sumOfYOEIfYOEIsLessOrEqualTo10AndAgeIsGreaterThan35 = employees
                .Where(employee => employee.YearsOfExperience <= 10 &&
                                   employee.Age > 35);
            int sumOfYOE = sumOfYOEIfYOEIsLessOrEqualTo10AndAgeIsGreaterThan35.Sum(employee => employee.YearsOfExperience);
            Console.WriteLine(sumOfYOE);
            Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var averageYOEIfYOELessThanOrEqualto10AndAgeGreater35 = employees
               .Where(employee => employee.YearsOfExperience <= 10 &&
                          employee.Age > 35);
            var averageYOE = averageYOEIfYOELessThanOrEqualto10AndAgeGreater35.Average(employee => employee.YearsOfExperience);
            Console.WriteLine(averageYOE);
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployeeAdded = employees.Append(new Employee { FirstName = "Micah", LastName = "Ammons", Age = 27, YearsOfExperience = 0 });

            foreach ( Employee employee in newEmployeeAdded )
            {
                Console.Write( employee.FullName );
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
