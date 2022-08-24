
Console.WriteLine("Primary range limit is: 1");

Console.Write("Please enter final range limit: ");
int finalBorder = Convert.ToInt32(Console.ReadLine());

Random compNumber = new Random();
double comp = compNumber.Next(0, finalBorder);
double user = 0;

double f = 0;
while (true)
{
    Console.WriteLine("Please guess number");
    user = Convert.ToDouble(Console.ReadLine());
    if(user == comp)
    {
        double i = 1;
        double n = 1;

        for ( i = 1; i < finalBorder;)
        {
            
            double kv = Math.Pow(2, i++);
            if (kv < finalBorder)
            {
                n = i-1;
            }
        }
        double res = 0.0;
        Console.WriteLine("You won, congratulation!!!!!!");
        
        res = Math.Round(Math.Abs(100 * ((n - f) / n)), 0);
        Console.WriteLine($"You score = {res} points");
        Console.WriteLine($"Number of failed attempts = {f}");
        break;
        
    }
    
    else if (user < comp)
    {
        Console.WriteLine("More");
        f++;
    }
    else if (user > comp)
    {
        Console.WriteLine("Less");
        f++;
    }
}

/*
 * Недоліки до програми
 * 1) Початкова границя діапазону не може бути задана так як зібється "n"
 * 2) Якщо кількість невдалих спроб співпаде зі степенем то буде 0
*/




