Console.WriteLine("enter number");
string a = Console.ReadLine();
if (a.Length >= 3)
{
    Console.WriteLine(a[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}