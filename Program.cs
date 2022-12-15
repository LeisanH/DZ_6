/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int n;
Console.Write($"Введите количество чисел: ");
int.TryParse(Console.ReadLine()!, out n);

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"[{i}]= ");
    int.TryParse(Console.ReadLine()!, out array[i]);
}
int k = 0;
foreach (var i in array)
    if (i > 0)
        k++;
Console.Write($"\n{k} чисел больше 0");