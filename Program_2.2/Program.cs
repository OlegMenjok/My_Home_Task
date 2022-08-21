//методи хотів зробити і перевірку щоб сторони не були менше 0
do{

        try
        {
            
            Console.WriteLine("Choose the figure in this list:" +
                              "Circle = 1, Triangle = 2");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice != 1 && userChoice != 2 && userChoice != 3)
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
                double squareCircle = Math.PI * (Math.Pow(radius, 2));
                Console.WriteLine("Square of circle is : " + squareCircle);
            }

            //Triangle
          
        if (userChoice == 2)
        {
           
            Console.Write("Enter first side: ");
            float firstSide = Convert.ToSingle(Console.ReadLine());
            checkFirstSide();
            Console.Write("Enter second side: ");
            float secondSide = Convert.ToSingle(Console.ReadLine());
            checkSecondSide();
            Console.Write("Enter third side: ");
            float thirdSide = Convert.ToSingle(Console.ReadLine());
            checkThirdSide();
            
            float p = (1 / 2)*(firstSide + secondSide + thirdSide);
            double squareTriangle = Math.Sqrt(p*(p-firstSide)*(p - secondSide)*(p - thirdSide));
            Console.WriteLine("Square of triangle is :" + squareTriangle);
            
            void checkFirstSide()
            {
                if (firstSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                    
                }
                
            }
            void checkSecondSide()
            {
                if (secondSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                }
            }
            void checkThirdSide()
            {
                if (thirdSide < 0)
                {
                    Console.WriteLine("Enter positive(>0) number, please");
                }
            }
        }

        if (userChoice == 3)
        {
            Console.Write("Enter first side: ");
            float firstSide = Convert.ToSingle(Console.ReadLine());

            double s = Math.Pow(firstSide, 2);
            Console.WriteLine("Square of quadrant is: "+ s);
        }
        if (userChoice == 4)
        {
            Console.Write("Enter first side: ");
            float firstSide = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second side: ");
            float secondSide = Convert.ToSingle(Console.ReadLine());
            double s = firstSide * secondSide;
            Console.WriteLine("Square of rectangle is: "+ s);
        }
        }
        
        catch
        {
            Console.WriteLine("Exception, Check format");
        }
        finally
        {
            Console.WriteLine(
                "If you want continue click any button, but if you  go out press <Q> in your keyboard ");
            Console.WriteLine("\n");
        }
        void
        void triangle(float firstSide, float secondSide, float thirdSide)
        {
            float p = (1 / 2)*(firstSide + secondSide + thirdSide);
            double resultTriangle = Math.Sqrt(p*(p-firstSide)*(p - secondSide)*(p - thirdSide));
            Console.WriteLine("Square of triangle is :" + resultTriangle);
        }
        
}while(Console.ReadKey().Key != ConsoleKey.Q);
