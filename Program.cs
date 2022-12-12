// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr= new int [8];
void PrintArray (int [] arr)
{
    Random rand= new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=rand.Next(100);
        Console.Write($"{arr[i]}, ");
    }
}
PrintArray (arr);
