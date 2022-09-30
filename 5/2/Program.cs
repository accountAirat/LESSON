// Задача 35: Напишите метод, который суммирует 2 массива. 
// Каждый элемент одного массива должен суммироваться с соответствующим элементом из второго массива. 
// Если длины массивов не равны, то должно появляться сообщение об ошибке
// [5, 18, 123, 6, 2] + [1, 2, 3, 6, 2] = [6, 20, 126, 12, 4]

int[] CreateArray()
{
    Console.Write("Введи размерность массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
//SummArray(array1, array2);
