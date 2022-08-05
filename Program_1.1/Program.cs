Console.WriteLine("This program count a certain formula ");
Console.WriteLine("Author: Menok Oleh");

Console.WriteLine("Enter any number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birthday year");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birthday month");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birthday day");
int d = Convert.ToInt32(Console.ReadLine());

const double e = 2.71828182846;

double y = (Math.Pow(e, a) + 4 * Math.Log(c)) / (Math.Sqrt(b)) * Math.Atan(d) + 5 / Math.Sin(a);

Console.WriteLine(y);
