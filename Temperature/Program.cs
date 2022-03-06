using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            x:
            Console.WriteLine("What Measurement Do You Use? (c: Celsius, f: Fahrenhiet, k: Kelvin, r: Rankine)");
            char form = char.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Enter Temperature Value: ");
            float temp = float.Parse(Console.ReadLine());

            switch (form) {
                case 'c':
                    Cel(temp);
                    break;
                case 'f':
                    Faran(temp);
                    break;
                case 'k':
                    Kel(temp);
                    break;
                case 'r':
                    Ran(temp);
                    break;
                default:
                    Console.WriteLine("Invaild Temperature Measurement");
                    break;
            }

            Console.WriteLine("Do You Want to Start Over ? (y/N)");

            if(Console.ReadLine().ToLower() == "y") {
                goto x;
            }
            
        }
        
        static void Cel(float v) {
            float Faran = 9 / 5f * v  + 32;
            float Kel = v + 273;
            float Ran = (v * 9 / 5f) + 491.67f;

            Console.WriteLine("The Temprature in \n Fahrenhiet = {0}.\n in Rankine = {1}.\n in Kelvin ={2}.",Faran, Ran, Kel);
        }

        static void Faran(float v) {
            float Cel= (v - 32) * 5 / 9f;
            float Kel = (v - 32) * 5 / 9f + 273.15f;
            float Ran = v + 459.67f;

            Console.WriteLine("The Temprature in \n Celsius = {0} .\n in Kelvin = {1}. \n in Rankine ={2}.", Cel,Kel, Ran);
        }
        static void Kel(float v) {
            float Cel = v - 273;
            float Faran = (v - 273.15f) * 9 / 5f + 32;
            float Ran = (v * 1.8f);

            Console.WriteLine("The Temprature in \n Celsius = {0} .\n in Fahrenhiet = {1}. \n in Rankine ={2}.", Cel, Faran, Ran);
        }
        static void Ran(float v) {
            float Cel = (v - 491.67f) * 5 / 9f;
            float Kel = v * 5 / 9f;
            float Faran = v - 459.67f; ;

            Console.WriteLine("The Temprature in \n Celsius = {0} .\n in Fahrenhiet = {1}. \n in Kelvine ={2}.", Cel, Faran, Kel);
        }
    }
}
