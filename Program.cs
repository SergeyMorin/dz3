
int number = int.Parse(Console.ReadLine()!);
int temp = number;
int i = 1;

while (number >= 10) // определение количества разрядов в числе
{
    number = number / 10;
    i++;
}

int[] array = new int[i]; // создание массива по количеству разрядов заданного числа

int icopy = i; // запоминание количества разрядов

while (i > 0) // заполнение массива по разрядам 
{
    array[i - 1] = temp % 10;
    temp = temp / 10;
    i--;
}

/*
for (int k = 0; k < array.Length; k++)  // вывод в консоль массива по элементам
{
    Console.Write($" {array[k]}");
}
*/

int[] array2 = new int[icopy];

for (int y = 0; y < array.Length; y++) // разворот массива
{
    array2[y] = array[(array.Length - 1) - y];
}

/*
for (int k = 0; k < array.Length; k++)  // вывод в консоль обратного массива
{
    Console.Write($" {array2[k]}");
}
*/

int magic = 0;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] == array2[index])
    {
        magic++;
    }
}

if (magic == array.Length)
{
    Console.WriteLine(" ДА, заданное число палиндромом");
}
else
{
    Console.WriteLine(" НЕТ, , заданное число не палиндромом");
}