Console.WriteLine("Thia program count sum of range");
Console.Write("Enter your birthday year: ");
double year = Convert.ToDouble(Console.ReadLine());
double eps = (1 / year)*10000;
double sum = 0;
for (double i = 1; i < eps; i++)
{
    sum = (1 / (i * (i + 1))/10000);
}

Console.WriteLine("Sum of range: " + sum);