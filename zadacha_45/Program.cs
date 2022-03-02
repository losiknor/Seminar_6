// 45. Показать числа Фибоначчи
int n = new Random().Next(3, 10);
int x = 1;
int y = 1;
Console.Write($"Числа Фибоначчи:  {x}  {y}  ");
for (int i = 1; i <= n; i++)
{
    Console.Write(x + y);
    Console.Write("  ");
    int xtmp = x;
    x = y;
    y = xtmp + y;
}



