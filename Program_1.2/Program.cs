Console.WriteLine("This program count a certain formula ");
Console.WriteLine("Author: Menok Oleh");

Console.WriteLine("Enter first competitor name: ");
var firstComp = Console.ReadLine();

Console.WriteLine("Enter second competitor name: ");
var secondComp = Console.ReadLine();

Console.WriteLine("Enter coefficients P1(first competitor win)");
double p1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coefficients X(Draft)");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coefficients P2(Second competitor win)");
double p2 = Convert.ToDouble(Console.ReadLine());
double bmMargin = (1 - 1 / (1 / p1 + 1 / x + 1 / p2 )) * 100;
Console.WriteLine($"Win {firstComp}: {p1}%" );
Console.WriteLine($"Draft :{x}%");
Console.WriteLine($"Win {secondComp} " +$": {p2}%");

Console.WriteLine($"Bookmaker's margin : {bmMargin}%");