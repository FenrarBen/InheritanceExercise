using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird cardinal = new Bird();
            cardinal.numberOfEyes = 2;
            cardinal.numberOfLegs = 2;
            cardinal.whatItEats = "worms";
            cardinal.doIHaveOne = false;
            cardinal.colorOfFeathers = "red";
            cardinal.doesItFly = true;
            cardinal.isItExtinct = false;
            cardinal.terminalAirspeedVelocity = 3.14159;

            Console.WriteLine($"Cardinal:\n" +
                $"\thas {cardinal.numberOfEyes} eyes\n" +
                $"\thas {cardinal.numberOfLegs} legs\n" +
                $"\teats {cardinal.whatItEats}\n" +
                $"\tflies {cardinal.terminalAirspeedVelocity} m/s");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
