double sum = 0;
while (true)
{
    sum += Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }

}
Console.WriteLine(sum);
