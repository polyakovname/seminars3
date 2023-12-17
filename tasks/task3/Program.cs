// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] Array = {1, 2, 5, 0, 10, 34};
void PrintArray(int[] Array, int i = 0)
{
    if (i<Array.Length)
    {
        PrintArray(Array, i+1);
        Console.Write(Array[i] + " ");
    }
}
PrintArray(Array);