// 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите кол-во чисел Фибо: ");
int count = int.Parse(Console.ReadLine());
int[] Fibo = new int[count];
Fibo[0] = 0;
Fibo[1] = 1;
int N = 0;
Console.Write("Ряд первых " + count + " чисел Фибоначчи: " + Fibo[0]+ " "+ Fibo[1] + " ");

for (int i = 2; i < count; i++)
{
   Fibo[i] = ((Fibo[i-1]) + (Fibo[i - 2]));
   Console.Write(Fibo[i] + " ");
}
