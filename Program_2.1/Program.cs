int stone = 1;
int scissors = 2;
int paper = 3;
string user = "User";
string comp = "Computer";
Random rndComp = new Random();
Console.WriteLine("Rule: stone > scissors, scissors > paper, paper > stone");

Console.WriteLine("List of command: stone, scissors, paper, exit");

Console.WriteLine("Please choose figure");

if ( stone > scissors || scissors > paper || paper > stone )
