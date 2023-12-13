//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10] { 45, 26, 63, 68, 57, 34, 55, 56, 86, 26 };
int even_numbers = 0;

for (int i = 0; i < 10; i++)
{
    var reminderDivision = array[i] % 2; // остаток от деление текущего элемента массива на 2

    if (reminderDivision == 0) // если остаток = 0 это четное число
    {
        even_numbers = even_numbers + 1;  //even_numbers++; или
    }
}

Console.WriteLine($"Количество {even_numbers}");