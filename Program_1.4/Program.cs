Console.WriteLine("Enter enter primary range limit");
int primaryBorder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter enter final range limit");
int finalBorder = Convert.ToInt32(Console.ReadLine());

for (int i = primaryBorder; i < finalBorder; i++)
{
    Console.WriteLine(i);
}
