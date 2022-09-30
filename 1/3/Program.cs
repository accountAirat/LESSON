Console.Clear();

int[] array = new int[123];
FillArray(array);
int count = 0;
Counter(array);
PrintArray(array);
Print(count);

int Counter(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
         count++;
    }
}
return count;
}
void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0,200);
    }
}
void Print(int count)
{
    Console.WriteLine(count);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine(" ");
}