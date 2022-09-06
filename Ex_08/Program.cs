/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.  */

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
Console.WriteLine();

int[] mass = new int[5];
int[] copy = new int[mass.Length];
for (int i = 0, j = 0; i < mass.Length && j < mass.Length; i++, j++)
{
    mass[i] = new Random().Next(0, 10);
    copy[j] = mass[i];

}
Print(mass);
Console.WriteLine();
Print(copy);
Console.WriteLine();


