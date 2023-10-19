Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
double P = 1;
for (double i = 1; i <= N; i++)
{
    P = (2 * i) / (2 * i + 1);

}
Console.WriteLine(P);