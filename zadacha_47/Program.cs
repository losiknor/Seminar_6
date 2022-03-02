// 47. Написать программу копирования массива
int n = new Random().Next(3, 15);
int[] array = new int[n];
Console.WriteLine("Дан массив array:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(30, 150);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int[] arrayCopy = new int[array.Length];
Console.WriteLine("Его копия arrayCopy:");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i] = array[i];
    Console.Write(arrayCopy[i] + " ");
}