/*Не переделывал под чётные и не чётные*/

Console.Clear();
void PrintArray(int[] array)
{
    Console.WriteLine("PrintArray: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    Console.WriteLine(" ");
}
void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0,10);
    }
}
void ProArray(int[] array, int[] proArray)
{
    int count = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        proArray[i] = array[i] * array[count];
        count--;
    }
}
int[] array = new int[4];
int[] proArray = new int[array.Length / 2];
FillArray(array);
PrintArray(array);
ProArray(array, proArray);
PrintArray(proArray);






