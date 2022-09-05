/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10);
}
Print(mass);

for (int i = 0; i < mass.Length / 2; i++)
{
    /* int save = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = save; */
    (mass[i], mass[mass.Length - 1 - i]) = (mass[mass.Length - 1 - i], mass[i]);
}
Print(mass);
