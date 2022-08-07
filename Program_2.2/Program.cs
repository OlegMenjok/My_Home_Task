do{
        try
        {
            Console.WriteLine("Choose the figure in this list:" +
                              "Circle = 1, Triangle = 2");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice != 1 && userChoice != 2)
            {
                Console.WriteLine("Error, put correct number 1 or 2");
            }

            //Cicle
            if (userChoice == 1)
            {
                Console.WriteLine("Enter radius of circle: ");
                float radius = Convert.ToSingle(Console.ReadLine());
                if (radius < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                }

                const double Pi = 3.14;
                double squareCircle = Pi * (Math.Pow(radius, 2));
                Console.WriteLine("Square of circle is : " + squareCircle);
            }

            //Triangle
        if (userChoice == 2)
        {
            Console.WriteLine("Enter first side");
            float firstSide = Convert.ToSingle(Console.ReadLine());
            if (firstSide < 0)
            {
                Console.WriteLine("Enter positive(>0) number, please");
            }

            Console.WriteLine("Enter second side");
            float secondSide = Convert.ToSingle(Console.ReadLine());
            if (secondSide < 0)
            {
                Console.WriteLine("Enter positive(>0) number, please");
            }

            float squareTriangle = (firstSide + secondSide) / 2;
            Console.WriteLine("Square of triangle is :" + squareTriangle);
        }
        }
        catch
        {
            Console.WriteLine("Exception, Check format");
        }
        finally
        {
            Console.WriteLine(
                "If you want continue click any button, but if you  go out press Home in your keyboard ");
            Console.WriteLine("\r\n\n");
        }
}while(Console.ReadKey().Key != ConsoleKey.Home);