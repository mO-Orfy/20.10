﻿int n = 1;
while (true)
{
    n *= Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }

}
Console.WriteLine(n);