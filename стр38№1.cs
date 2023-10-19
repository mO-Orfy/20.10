int sum = 0;
while (true)
{
    sum += Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }

}
Console.WriteLine(sum);