// Задайте одномерный массив, заполненный случайными числами. 

int[] FillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    while (i < length)
    {
        arr[i] = new Random().Next(1, 10);
        i++;
    }
    return arr;
}
int SumNeg(int[] arr1)
{
    int length = arr1.Length;
    int i = 0;
    int sum = 0;
    while (i < length)
    {
        if (i % 2 != 0) 
        {
            sum = sum + arr1[i];
        }
        i++;
    }
    return sum;
}
int[] numArray = new int[5];
FillArray(numArray);
Console.WriteLine(String.Join(" ", numArray));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + SumNeg(numArray));