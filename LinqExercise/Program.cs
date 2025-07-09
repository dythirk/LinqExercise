using System;
using System.Collections.Generic;
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

            Console.WriteLine("Sum:");

            Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers
            Console.WriteLine("\nAvg:");

            Console.WriteLine(numbers.Average());

            //TODO: Order numbers in ascending order and print to the console

            var asc = numbers.OrderBy(x => x);
            Console.WriteLine("\nAscending:");

            foreach (int num in asc)
            {
                Console.WriteLine(num);
            }


            //TODO: Order numbers in descending order and print to the console

            var desc = numbers.OrderByDescending(x => x);
            Console.WriteLine("\nDescending:");

            foreach (int num in desc)
            {
                Console.WriteLine(num);
            }

            //TODO: Print to the console only the numbers greater than 6

            var greaterThanSix =numbers.Where(x => x > 6);
            Console.WriteLine("\nGreater than 6:");

            foreach (int num in greaterThanSix)
                Console.WriteLine(num);

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("\nTake 4:");

            foreach (var num in asc.Take(4))

                { Console.WriteLine(num); }



            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 32;
            desc = numbers.OrderByDescending(x => x);
            Console.WriteLine("\nAge inserted:");

            foreach (int num in desc)
            {
                Console.WriteLine(num);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var filtered = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);
            Console.WriteLine("\nC or S in order");
            foreach (var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var overTwentySix = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            Console.WriteLine("\nOver 26 Age sorted:");
            foreach (var person in overTwentySix) 
            Console.WriteLine($"Full name: {person.FullName} Age: {person.Age}");
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Add an employee to the end of the list without using employees.Add()


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
