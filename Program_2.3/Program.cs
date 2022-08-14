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
/*
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

double avsum = 0;
for (var i = 0; i < nums.Length; i++)
{
    avsum += nums[i]/userEntered;
}
Console.WriteLine("AvSum of elements is: " + avsum);

double summa = 0;
var AvSqrtVid = 0;
for (var i = 0; i < nums.Length; i++)
{
    var riz = avsum - nums[i];
    var kv = Math.Pow(nums[i], 2);
    summa += kv;
    var div = summa / userEntered;
    AvSqrtVid = (int)Math.Sqrt(div);
}
Console.WriteLine("AvSqrtVid of elements is: " + AvSqrtVid);
*/
Console.WriteLine("Enter 1 if you want sorting to increase or enter -1 if you want sort to decrease");
int s = Convert.ToInt32(Console.ReadLine());
for (int j = 0; j < nums.Length; j++)  
for (int i = 0; i < nums.Length-1; i++)
{
    if(nums[i]*s > nums[i + 1]*s)   
    {          
        
    } 
    
}






