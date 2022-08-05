Console.WriteLine("This program count a certain formula ");
Console.WriteLine("Author: Menok Oleh");

Console.WriteLine("Enter first competitor");
var firstComp = Console.ReadLine();

Console.WriteLine("Enter second competitor");
var secondComp = Console.ReadLine();

Console.WriteLine("Enter coefficients P1(first competitor win)");
var p1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coefficients X(Draft)");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coefficients P2(Second competitor win)");
var p2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Win {firstComp} " + $": {p1}%");
Console.WriteLine($"Win {secondComp} " +$": {p2}%");
Console.WriteLine($"Draft {x} " + $": {x}%");
Console.WriteLine("Bookmaker's margin : 4%");