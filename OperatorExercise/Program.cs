using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)

            Console.WriteLine("17/4 is 4 remainder " + (remainder));

            // Exercise 2

            Console.WriteLine("What is the radius of your circle ?");
            
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with the radius of {radius} is {area}");

            // Thought Exercise
            // So we are solving for k = 1+3 * 4 ,  4 * 4 = 16 So k = 16

            // var i = 3;
            // var j = 4;
            // var k = ++i * j++;
            // Console.WriteLine(k);





        }
    }
}