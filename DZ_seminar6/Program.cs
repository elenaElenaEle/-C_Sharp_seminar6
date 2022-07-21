// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArr (int[] arr1)

{
    for (int j = 0; j < arr1.Length; j++)
    {
        Console.Write(arr1[j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] FillArr = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1} элеменнт массива: ");
    FillArr[i] = int.Parse(Console.ReadLine());
}
PrintArr(FillArr);

int count = 0;
for (int i = 0; i < size; i++)
{
    if( FillArr[i] > 0)  count++;
}
Console.Write("Количество положительных элементов: " + count);

/* *************************************************************************************************************************************

// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());
double x = (b2 - b1) / (k2 - k1);
double y = (k1 * b2 - k2 * b1) / (k1 - k2);
Console.Write("Координаты точки пересечения прямых: x = " + x + ", y = " + y); */