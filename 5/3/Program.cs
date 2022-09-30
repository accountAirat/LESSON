// Задача 37: Напишите метод, который объединяет 2 массива в 1.
// [5, 18, 123, 6, 2] + [1, 2, 3] = [5, 18, 123, 6, 2, 1, 2, 3]


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
int[] UniteArray(int[] array1, int[] array2)
{
    int[] arrayUnite = new int[array1.Length + array2.Length];
    
    int j = 0;
    for (int i = 0; i < arrayUnite.Length; i++)
    {
        if (i < array1.Length)
        {
            arrayUnite[i] = array1[i];
        }
        else
        {
            arrayUnite[i] = array2[j];
            j++;
        }
    }
    return arrayUnite;
}

int[] array1 = CreateArray();
int[] array2 = CreateArray();
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();

int[] arrayRoom6 = UniteArray(array1, array2);
PrintArray(arrayRoom6);
