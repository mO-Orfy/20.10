Console.WriteLine("Введите некоторое число e");
double e = Convert.ToDouble(Console.ReadLine());
double sum = 0;
while (true)
{
    Console.WriteLine("Введите число n");
    double n = Convert.ToDouble(Console.ReadLine());
    n = (1 / Math.Pow(2, n) + 1 / Math.Pow(3, n));
    if (Math.Abs(n) >= e)
    {
        sum += n;
    }
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }
}
Console.WriteLine(sum);