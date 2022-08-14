int indexMax = 0;
Console.Write("Enter quantity number of array:\t ");
int userEntered = Convert.ToInt32(Console.ReadLine());

var nums = new int[userEntered];
Console.WriteLine($"Enter any {userEntered} numbers: ");

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Enter {i+1} value: ");
    nums[i] = int.Parse(Console.ReadLine());
}

double minValue = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < minValue)
    {
        minValue = nums[i];
    }
}
Console.WriteLine("Min elements is: " + minValue);

double maxValue = nums[0];
for (int i = 0; i < nums.Length; i++)
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
for (var i = 0; i < nums.Length; i++)
{
    avsum += nums[i]/2;
}
Console.WriteLine("AvSum of elements is: " + avsum);





