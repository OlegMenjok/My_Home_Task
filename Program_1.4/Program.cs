{
    Console.WriteLine("This program output only primary counts");
    Console.Write("Enter enter primary range limit: ");
    uint primaryBorder = Convert.ToUInt32(Console.ReadLine());
        
    Console.Write("Enter enter final range limit: ");
    uint finalBorder = Convert.ToUInt32(Console.ReadLine());
    
    Console.WriteLine("Primary numbers is ({0}, {1})", primaryBorder, finalBorder);
    for (var i = primaryBorder; i < finalBorder; i++)
    {
        if (IsPrimeNumber(i)) 
        {
                Console.Write($"{i} ");
        }
    }
    static bool IsPrimeNumber(uint finalBorder)
    {
        var result = true;

        if ( finalBorder > 1)
        {
            for (var i = 2u; i < finalBorder ;  i++)
            {
                if ( finalBorder % i == 0 )
                {
                    result = false;
                    break;
                }
            }
        }
        else
        {
            result = false;
        }

        return result;
    }
}