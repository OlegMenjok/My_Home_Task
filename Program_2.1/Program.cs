int stone = 1;
int scissors = 2;
int paper = 3;
string user = "User";
string comp = "Computer";
Random rndComp = new Random();
do
    {
            Console.WriteLine("Rule: stone > scissors, scissors > paper, paper > stone");
            Console.WriteLine("Stone = 1, scissors = 2, paper = 3");

            Console.WriteLine("Please tab Enter when you induce with rules");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            try
            {
            Console.WriteLine("\n\nPlease choose figure");
            int userchoose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You choose figure " + userchoose);
            
            if (userchoose != 1 && userchoose != 2 && userchoose != 3)
            {
                Console.WriteLine("Error, put correct number 1,2 or 3");
            }
            else
            {
                Console.WriteLine("Computer choose figure");
                int rnd = rndComp.Next(1, 3);
                Console.WriteLine(rnd);


                if ((userchoose != 3) && (userchoose != 1))
                {
                    Console.WriteLine("User choose scissors");
                }
                else if ((userchoose != 3) && (userchoose != 2))
                {
                    Console.WriteLine("User choose stone");
                }
                else if ((userchoose != 1) && (userchoose != 2))
                {
                    Console.WriteLine("User choose paper");
                }

                if ((rnd != 3) && (rnd != 1))
                {
                    Console.WriteLine("Computer choose scissors");
                }
                else if ((rnd != 3) && (rnd != 2))
                {
                    Console.WriteLine("Computer choose stone");
                }
                else if ((rnd != 1) && (rnd != 2))
                {
                    Console.WriteLine("Computer choose paper");
                }

                //paper       //scissors           //stone             //scissors
                if (((rnd > 2) && (userchoose > 1)) || ((userchoose < 2) && (rnd < 3)))
                {
                    Console.WriteLine("User win");
                }
                else if (((rnd > 1) && (userchoose > 2)) || ((userchoose < 3) && (rnd < 2)))
                {
                    Console.WriteLine("Computer win");
                }
                else if ((((rnd == 1) && (userchoose == 1)) || ((userchoose == 2) && (rnd == 2)) ||
                          ((userchoose == 3) && (rnd == 3))))
                {
                    Console.WriteLine("Draw");
                }
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