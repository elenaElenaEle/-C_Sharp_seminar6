// 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Num (string num)
{
    Console.Write("Введите число в десятичном формате: ");
    return int.Parse(Console.ReadLine());
}

int N = Num("");
int A = N;
int ost = 0;
string result = string.Empty;
while (A > 0)
{
   ost = A % 2;
   A = A / 2;
   result = ost + result;
}
Console.Write("Число " + N + " в двоичном формате =  " + result);
