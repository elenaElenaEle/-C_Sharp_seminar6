// 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования. 
void FillArr(int []arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}
void PrintArr (int[] arr1)
{
    for (int j = 0; j < arr1.Length; j++)
    {
        Console.Write(arr1[j] + " ");
    }
    Console.WriteLine();
}

int N = 5;
int[] mass = new int[N];
int[] rez = new int[mass.Length];

FillArr(mass);

for (int i = 0; i < mass.Length-1; i++)
    {
        rez[i] = mass[i];
    }

int[] newArr = mass;// получается ссылка, а не копия. меняешь пв одном массиве элемент, и он автоматич меняется в другом

PrintArr(mass);
PrintArr(rez);
PrintArr(newArr);
mass[0] = 999;
PrintArr(mass);
PrintArr(rez);
PrintArr(newArr);