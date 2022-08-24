do
{

    try
    {
        Console.WriteLine("Choose the figure in this list:" +
                          "circle = 1, triangle = 2, quadrant = 3, rectangle = 4 ");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        if (userChoice != 1 && userChoice != 2 && userChoice != 3 && userChoice != 4)
        {
            Console.WriteLine("Error, put correct number 1, 2, 3 or 4");
        }

        //Cicle
        if (userChoice == 1)
        {
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius < 0)
            {
                while (radius < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter radius of circle: ");
                    radius = Convert.ToSingle(Console.ReadLine());
                }
                
            }
            double squareCircle = Math.PI * (Math.Pow(radius, 2));
            Console.WriteLine("Square of circle is : " + squareCircle);
        }

        //Triangle

        if (userChoice == 2)
        {

            Console.Write("Enter first side: ");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            if (firstSide < 0)
            {
                while (firstSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter first side: ");
                    firstSide = Convert.ToSingle(Console.ReadLine());
                }
                
            }

            Console.Write("Enter second side: ");
            double secondSide = Convert.ToDouble(Console.ReadLine());
            if (secondSide < 0)
            {
                while (secondSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter second side : ");
                    secondSide = Convert.ToSingle(Console.ReadLine());
                }

            }

            Console.Write("Enter third side: ");
            double thirdSide = Convert.ToDouble(Console.ReadLine());
            if (thirdSide < 0)
            {
                while (thirdSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter third side: ");
                    thirdSide = Convert.ToSingle(Console.ReadLine());
                }

            }

            double p = 0.5 * (firstSide + secondSide + thirdSide);
            double squareTriangle = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            
            if (double.IsNaN(squareTriangle))
            {
                Console.WriteLine("Unable to calculate the area, please enter correct side values !!!");
            }
            else
            {
                Console.WriteLine("Square of triangle is :" + squareTriangle);
            }
        }

        //Quadrant
        if (userChoice == 3)
        {
            Console.Write("Enter first side: ");
            float firstSide = Convert.ToSingle(Console.ReadLine());
            if (firstSide < 0)
            {
                while (firstSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter first side: ");
                    firstSide = Convert.ToSingle(Console.ReadLine());
                }
                
            }

            double s = Math.Pow(firstSide, 2);
            Console.WriteLine("Square of quadrant is: " + s);
        }

        //Rectangle
        if (userChoice == 4)
        {
            Console.Write("Enter first side: ");
            double firstSide = Convert.ToSingle(Console.ReadLine());
            if (firstSide < 0)
            {
                while (firstSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter first side: ");
                    firstSide = Convert.ToSingle(Console.ReadLine());
                }
                
            }

            Console.Write("Enter second side: ");
            double secondSide = Convert.ToDouble(Console.ReadLine());
            if (secondSide < 0)
            {
                while (secondSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    Console.Write("Enter second side: ");
                    secondSide = Convert.ToSingle(Console.ReadLine());
                }
                
            }
            double s = firstSide * secondSide;
            Console.WriteLine("Square of rectangle is: " + s);
        }
        
    }
    catch
    {
        Console.WriteLine("Error, check format");
    }
    finally
    {
        Console.WriteLine(
            "If you want continue click any button, but if you  go out press <Q> in your keyboard ");
        Console.WriteLine("\n");
    }
}
while (Console.ReadKey().Key != ConsoleKey.Q) ;