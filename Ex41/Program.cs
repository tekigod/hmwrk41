// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например: 
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int s;
int count = 0;
int[] arr;
 
Console.Write("Введите размер массива: ");
s = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите числа: ", s);
arr = new int[s];
for (int i = 0; i < s; i++)
{
    Console.Write("Число {0}: ", i+1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел > 0: {count}");