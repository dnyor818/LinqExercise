using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            
            
                Console.WriteLine(sum);
            
            var avg = numbers.Average();

            Console.WriteLine(avg);


            //Order numbers in ascending order and decsending order. Print each to console.
            var uppers = numbers.OrderBy(x => x);

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            var downers = numbers.OrderByDescending(x => x);

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------");

            //Print to the console only the numbers greater than 6
            var greaterSix = numbers.Where(x => x > 6);

            foreach (var i in greaterSix)
            {
                Console.WriteLine(i);
            }

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var onlyFour = numbers.OrderByDescending(x => x).Take(4);

            foreach (var i in onlyFour)
            {
                Console.WriteLine(i);
            }


            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 35;
            var myAge = numbers.OrderByDescending(x => x);

            foreach (var i in myAge)
            {
                Console.WriteLine(i);
            }

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            var cNames = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S');
            foreach (var i in cNames)
            {
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            }

            Console.WriteLine("-----------");
            //Order this in acesnding order by FirstName.
            var aNames = employees.OrderBy(x => x.FirstName);
            foreach (var i in aNames)
            {
                Console.WriteLine($"{i.FirstName}");
            }

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var overTwoSix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var i in overTwoSix)
            {
                Console.WriteLine(i.FullName, i.Age);
            }

            //Print all the employees' FullName and Age who are over the age 26 of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("--------");

            var overAnd = employees.Where(x => x.Age > 26 && x.YearsOfExperience >= 10 && x.YearsOfExperience <= 35);
            foreach (var i in overAnd)
            {
                Console.WriteLine(i.FullName, i.Age);
            }

            //Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee("David", "Yordle", 32, 2));
            
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
