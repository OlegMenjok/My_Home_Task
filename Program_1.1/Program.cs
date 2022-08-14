Console.WriteLine("This program count a certain formula ");
Console.WriteLine("Author: Menok Oleh");

Console.WriteLine("Enter any number");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birthday year");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birthday month");
var c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birthday day");
var d = Convert.ToInt32(Console.ReadLine());

void y()
{
    const double e = Math.E;

    double y = (Math.Pow(e, a) + 4 * Math.Log(c)) / (Math.Sqrt(b)) * Math.Abs(Math.Atan(d)) + 5 / Math.Sin(a);
}


Console.WriteLine(y);
