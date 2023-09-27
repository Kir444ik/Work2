Console.WriteLine("Enter a tree-digit number");
int a = tens(Convert.ToInt32(Console.ReadLine()));
int tens(int num)
{
    return num/10%10;
}
Console.WriteLine(a);