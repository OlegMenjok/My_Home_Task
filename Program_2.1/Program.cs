int stone = 1;
int scissors = 2;
int paper = 3;
string user = "User";
string comp = "Computer";
int uwin = 0;
int cwin = 0;
int draw = 0;
Random rndComp = new Random();
do
{
    Precondition();
    Game();
} while (Console.ReadKey().Key != ConsoleKey.Spacebar);
{
    Console.WriteLine("\n_____STATISTIC_____");
    Console.WriteLine($"User win {uwin} times ");
    Console.WriteLine($"Computer win {cwin} times ");
    Console.WriteLine($"Draw {draw} times ");
};
void Precondition()
{
    Console.WriteLine("Rule: stone > scissors, scissors > paper, paper > stone");
    Console.WriteLine("Stone = 1, scissors = 2, paper = 3");

    Console.WriteLine("Please tab Enter when you induce with rules");
    while (Console.ReadKey().Key != ConsoleKey.Enter)
    {
    }

    Console.WriteLine();
    Console.WriteLine("     ***        ****      **     **    ** ** **  ");
    Console.WriteLine("   **         **    **    ** * * **    **        ");
    Console.WriteLine("  **   ***    ** ** **    **  *  **    ** **     ");
    Console.WriteLine("   **   *     **    **    **     **    **        ");
    Console.WriteLine("     ***      **    **    **     **    ** ** **  ");
}
void Game()
    {
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

                //paper       //scissors           //stone             //scissors           // paper          // stone 
                if (((rnd > 2) && (userchoose > 1)) || ((userchoose < 2) && (rnd < 3))  || ((userchoose > 2) && (rnd < 2)))
                {
                    Console.WriteLine("User win");
                    uwin++;

                }
                else if (((rnd > 1) && (userchoose > 2)) || ((userchoose < 3) && (rnd < 2)) || ((userchoose < 2)|| (rnd > 2)))
                {
                    Console.WriteLine("Computer win");
                    cwin++;
                }
                else if ((((rnd == 1) && (userchoose == 1)) || ((userchoose == 2) && (rnd == 2)) ||
                          ((userchoose == 3) && (rnd == 3))))
                {
                    Console.WriteLine("Draw");
                    draw++;
                }
            }
        }
        catch
        {
            Console.WriteLine("Exception, Check format");
        }
        finally
        {
            Console.WriteLine("If you want continue click any button, but if you  go out press Space in your keyboard ");
            Console.WriteLine("=====================================================================================");
        }
    }