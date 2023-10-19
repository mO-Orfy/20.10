int sum = 0;
int count = 0;
while (true)
{
    sum += Convert.ToInt32(Console.ReadLine());
    count++;
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }

}
Console.WriteLine(Convert.ToDouble( sum )/ Convert.ToDouble(count));
