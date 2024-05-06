Этот код создает массив целых чисел и использует метод PrintArrayReversed для рекурсивного вывода элементов массива, начиная с конца.
Мы начинаем с последнего элемента массива и продолжаем рекурсивно вызывать метод, пока не достигнем начала массива (индекс 0).
Каждый элемент выводится на консоль в обратном порядке.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReversed(array, index - 1);
        }
    }
}
