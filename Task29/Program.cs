// Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.
void fillArray(int[]array, int A, int B)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(A, B);
    }
}
void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
int[] mass = new int[8];
fillArray(mass, 0, 100);
PrintArray(mass);
