Console.WriteLine("Enter your birthday year");
var year = Convert.ToInt32(Console.ReadLine());
double eps = 1 / year;
double sum = 0;
for (double i = 0; i < eps; i++)
{
    sum = 1 / (i * (i + 1));
}
Console.WriteLine("Sum of range: " + sum);