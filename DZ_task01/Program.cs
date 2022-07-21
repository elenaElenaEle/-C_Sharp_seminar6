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

