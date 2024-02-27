using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Principal;
using ConsoleApp1.Entities.Enum;
using ConsoleApp1.Entities;



namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("choose color, first letter in capital letters (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (resp == 'r')
                {
                    Console.Write("Width, using a period instead of a comma: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height, using a period instead of a comma: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Radius, using a period instead of a comma: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("f2"), CultureInfo.InvariantCulture);
            }

        }
    }
}