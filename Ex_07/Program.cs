/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 
*/
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int Fibonacci = 0;
Console.Write(a + "  " + b);
for (int i = 1; i < N-1; i++)
{
    Fibonacci = a + b;
    Console.Write(" "+Fibonacci+" ");
    a = b;
    b = Fibonacci;
}
