const double e = 2.71828182846;

Console.WriteLine("Enter your birthday year");
int year = Convert.ToInt32(Console.ReadLine());
double eps = e / year;


for (int i = 1; i < eps; i++)
{
    //double y = 1 / (i * (eps + 1));
    Console.WriteLine(i);
}
