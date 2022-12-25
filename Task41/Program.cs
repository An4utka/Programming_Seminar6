// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел:");
string inputText = Console.ReadLine();
string[] stringArray = inputText.Split(' ');
int[] array = new int[stringArray.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i]=int.Parse(stringArray[i]);
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count = count + 1;
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");
