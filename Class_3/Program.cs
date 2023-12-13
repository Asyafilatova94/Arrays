//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
var array = new[] { 3.4, 45.6, 34.5, 21.2, 65.2, 1.4, 182.2, 4.6 };

var minIndex = 0;
var maxIndex = 0;

for (var i = 0; i < array.Length; i++)
{
    if(array[minIndex] > array[i])
    {
        minIndex = i;
    }

    if(array[maxIndex] < array[i])
    {
        maxIndex = i;
    }
}

Console.WriteLine($"Минимальный элемент - {array[minIndex]}");
Console.WriteLine($"Максимальный элемент - {array[maxIndex]}");
var diff = array[maxIndex] - array[minIndex];
Console.WriteLine($"Разница между максимальным и минимальным элементом - {diff}");

