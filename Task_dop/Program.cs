// Доп. задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine("Enter your number:");
int number = int.Parse(Console.ReadLine());
// int numberAfterDiv2 = number / 2;
// int count = 0;
// while (numberAfterDiv2 >= 0)
//     count = count + 1;
// numberAfterDiv2 = numberAfterDiv2 / 2;
// int array=new int [count];
// for (int i = 0; i < count; i++)
// {
//     if ()
//     array[i]=number%2;
// }
int ostatok = number;

int count = 0;

while (ostatok > 0)

{

    ostatok = ostatok / 2;

    count = count + 1;

}

int[] array = new int[count];

for (int i = 0; i < count; i++)

{

    array[i] = number % 2;

    number = number / 2;

}

int[] arrayNew = new int[array.Length];

for (int i = 0; i < array.Length; i++)

{

    arrayNew[i] = array[array.Length - 1 - i];

    Console.Write(arrayNew[i] + " ");

}