int count = 0;
Console.WriteLine("Введите число для подсчёта");
int n = Convert.ToInt32(Console.ReadLine());
while (true)
{
    int tmp = Convert.ToInt32(Console.ReadLine());
    if (tmp == n) {
    count++;
    }
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }

}
Console.WriteLine(count);