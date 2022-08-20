
Console.WriteLine("Primary range limit is: 1");

Console.Write("Please enter final range limit: ");
var finalBorder = Convert.ToInt32(Console.ReadLine());

Random compNumber = new Random();
var comp = compNumber.Next(0, finalBorder);
var user = 0;

var f = 0;
while (true)
{
    Console.WriteLine("Please guess number");
    user = Convert.ToInt32(Console.ReadLine());
    if(user == comp)
    {
        var i = 1;
        var n = 1;

        for ( i = 1; i < finalBorder;)
        {
            
            var kv = Math.Pow(2, i++);
            if (kv < finalBorder)
            {
                
                Console.WriteLine(kv);
                n = i-1;
                Console.WriteLine("n="+n);
        
            }
        }
        var res = 0.0;
        Console.WriteLine("You won, congratulation!!!!!!");
        //Console.WriteLine(100 * ((n - f) / n));
        res = 100 * ((n - f) / n);
        Console.WriteLine($"You score is: {res}");
        
        break;
        
    }
    
    else if (user < comp)
    {
        Console.WriteLine("More");
        f++;
        Console.WriteLine("f= "+f);
    }
    else if (user > comp)
    {
        Console.WriteLine("Less");
        f++;
        Console.WriteLine("f= "+f);
    }
}






