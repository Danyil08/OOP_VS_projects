using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.PositiveIntegersOperationsAbout();
            facade.RationalNumbersOperationsAbout();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem ClassA" 
    class Adding
    {
        public void About()
        {
            Console.WriteLine("Adding method");
        }
    }

    // Subsystem ClassB" 
    class Subtraction
    {
        public void About()
        {
            Console.WriteLine("Subtraction method");
        }
    }


    // Subsystem ClassC" 
    class Multiplication
    {
        public void About()
        {
            Console.WriteLine("Multiplication method");
        }
    }
    // Subsystem ClassD" 
    class Division
    {
        public void About()
        {
            Console.WriteLine("Division method");
        }
    }
    // "Facade" 
    class Facade
    {
        Adding adding;
        Subtraction subtraction;
        Multiplication multiplication;
        Division division;

        public Facade()
        {
            adding = new Adding();
            subtraction = new Subtraction();
            multiplication = new Multiplication();
            division = new Division();
        }

        public void PositiveIntegersOperationsAbout()
        {
            Console.WriteLine("\nPositiveIntegersOperationsAbout() ---- ");
            adding.About();
            multiplication.About();
        }

        public void RationalNumbersOperationsAbout()
        {
            Console.WriteLine("\nRationalNumbersOperationsAbout() ---- ");
            adding.About();
            subtraction.About();
            multiplication.About();
            division.About();
        }
    }
}