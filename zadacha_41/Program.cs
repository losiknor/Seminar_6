// 41. Выяснить являются ли три числа сторонами треугольника
int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
int c = new Random().Next(1, 100);
Console.Write($"Три числа: {a}  {b}  {c}");
if ((a + b > c) && (b + c > a) && (a + c > b))
Console.WriteLine("  являются сторонами треугольника.");
else Console.WriteLine("  не являются сторонами треугольника.");
