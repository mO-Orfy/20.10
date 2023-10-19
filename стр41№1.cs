
Console.WriteLine("Ввеедите число n");
int n = Convert.ToInt32(Console.ReadLine());
int g = n;
while (n > 9)
{
    n /= 10;
}
int sum = g % 10 + n;

Console.WriteLine(sum);
