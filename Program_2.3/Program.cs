
try
{
    int indexMax = 0;
    Console.Write("Enter quantity number of array:\t ");
    int userEntered = Convert.ToInt32(Console.ReadLine());

    var nums = new int[userEntered];
    Console.WriteLine($"Enter any {userEntered} numbers: ");

    for (var i = 0; i < nums.Length; i++)
    {
        Console.WriteLine($"Enter {i + 1} value: ");
        nums[i] = int.Parse(Console.ReadLine());
    }

    double minValue = nums[0];
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] < minValue)
        {
            minValue = nums[i];
        }
    }

    Console.WriteLine("Min elements is: " + minValue);

    double maxValue = nums[0];
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] > maxValue)
        {
            maxValue = nums[i];
        }
    }

    Console.WriteLine("Max elements is: " + maxValue);

    var sum = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        sum = sum + nums[i];
    }

    Console.WriteLine("Sum of elements is: " + sum);

    var avsum = 0;
    avsum = sum / userEntered;

    Console.WriteLine("AvSum of elements is: " + avsum);

    double summa = 0;
    var AvSqrtVid = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        
        
        var riz = avsum - nums[i];
        var kv = Math.Pow(riz, 2);
        summa += kv;
        var div = summa / userEntered;
        AvSqrtVid = (int)Math.Sqrt(div);
    }

    Console.WriteLine("AvSqrtVid of elements is: " + AvSqrtVid);

    int x = 0;
    for (int i = 0; i <= nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] > nums[j])
            {

                x = nums[i];
                nums[i] = nums[j];
                nums[j] = x;

            }
        }
    }

    Console.Write("Sorting array is: ");
    foreach (var item in nums)
    {
        Console.Write("\t");
        Console.Write(item);
    }

    Console.ReadLine();

}
catch (System.FormatException)
{
    Console.WriteLine("Only int value");
   
}
finally
{
    Console.WriteLine("Goodbye");
}


