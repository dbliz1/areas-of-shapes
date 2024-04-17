using System.ComponentModel.DataAnnotations;

namespace Opgave_014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A
            //You can use this program to calculate the area of a triangle

            double length, bredth;
            double area;

            //Here you tell the user what this program is about
            Console.WriteLine(" In this exercise, you are going to calculate the area of a triangle. ");

            Console.WriteLine();

            //Formula for finding the area of a triangle
            Console.WriteLine(" The formula is ½ * length * bredth");

            Console.WriteLine();

            //Now we ask the user to enter the value of length
            Console.Write(" Enter the value of length: ");

            //Assign user's length value to length variable and then convert

            //length = Convert.ToInt16(Console.ReadLine());
            //length = Convert.ToDouble(Console.ReadLine());
            length = double.Parse(Console.ReadLine());

            Console.WriteLine();

            //Now we ask the user to enter the value of bredth and assign it to bredth variable
            Console.Write(" Enter the value of bredth: ");
            bredth = double.Parse(Console.ReadLine());

            Console.WriteLine();

            area = 0.5 * length * bredth;
            Console.WriteLine(" The area of your triangle is: " + area);
            
            Console.WriteLine();

            Console.WriteLine("     ***************     ");

            // Part B
            //We use this part of the progragram to calculate the area of a rectangle

            // First n foremost we declare our variables and tell the user what this part of program is for
            double length1, bredth1, area1;
            Console.WriteLine(" In this part, we are going to calculate area of a rectangle");

            Console.WriteLine();

            //Now we ask the user to enter the value of length and bredth
            Console.Write(" Enter the value of length: ");
            length1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write(" Enter the value of bredth: ");
            bredth1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            //Now we calculate the area of the rectangle and print it out to user
            area1 = length1 * bredth1;
            Console.WriteLine(" Using the formula Length * Bredth, the area of the triangle is " +  area1);

            //Now the program is done and we wait for the user to press a key to close the program
            Console.ReadKey();


        }   
    }
}
