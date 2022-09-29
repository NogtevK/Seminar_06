/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
 */

/* Console.WriteLine("Введите числа через запятую: ");
string s = Console.ReadLine();
string[] nums = s.Split(',');
for (int i = 0; i < nums.Length; i++)
{
    int num = int.Parse(nums[i]);
}
/* PrintArray(nums);
void PrintArray(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
} 
Console.WriteLine();
Console.WriteLine("Пользователь ввёл чисел >0: ");
Console.WriteLine(); */

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}




/////////////////////////////////////////////////////////////////////
/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =9 
-> (-0,5; 5,5)// ошибка  в ответе должно быть (-0.5 , -0.5)
 */
//k1*x+b1=k2*x+b2  / (k1-k2)*x=(b2-b1)
//x=(b2-b1)/(k1-k2)=2/-4= -0.5
//y = k1 *x + b1=5*(-0.5)+2= -0.5         
//y = k2 * x + b2=9*(-0.5)+4= -0.5      
/* 
Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}"); */