/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 
*/
/* Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int Fibonacci = 0;
Console.Write(a + "  " + b);
for (int i = 1; i < N - 1; i++)
{
    Fibonacci = a + b;
    Console.Write(" " + Fibonacci + " ");
    a = b;
    b = Fibonacci;
}
 */

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите Число N: ");
int N = int.Parse(Console.ReadLine());
int[] mass = new int[N];
mass[0] = 0;
mass[1] = 1;
for (int i = 2; i < mass.Length; i++)
{
    mass[i] = mass[i - 2] + mass[i - 1];
}
Console.WriteLine();
Console.WriteLine("Числа Фибоначчи: ");
Print(mass);