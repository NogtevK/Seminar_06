/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

/* 
Console.WriteLine("Введите десятичное число: ");
int x = int.Parse(Console.ReadLine());
string s = string.Empty;
while (x > 0)
{
    Console.Write(x % 2);
    s = x % 2 + s;
    x = x / 2;

}
Console.WriteLine();
Console.Write(s);
Console.WriteLine();
 */

Console.WriteLine("Введите десятичное число: ");
int a = int.Parse(Console.ReadLine());

int save = a;
int count = 0;

while (a > 0)
{
    a = a / 2;
    count++;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[count];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = save % 2;
    save = save / 2;
}
Print(mass);
Console.WriteLine();

int s;
for (int i = 0; i < mass.Length / 2; i++)
{
    s = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = s;
}
Print(mass);




