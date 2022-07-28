// Задайте массив, заполненный случайными положительными трёхзначными числами. 

int[] FillArray(int[] arr) 
{
    int length = arr.Length; 
    int i = 0; 
    while (i < length) 
    {
        arr[i] = new Random().Next(100, 1000); 
        i++; 
    }
    return arr; 
}
int EvenNumbers(int[] arr1)
{
    int length = arr1.Length;
    int count = 0; 
    int i = 0; 
    while (i < length)
    {
        if (arr1[i] % 2 == 0)
        {
            count = count + 1;
        }
        i++;
    }
    return count; 
}
int[] numArray = new int[8];
FillArray(numArray);
Console.WriteLine(String.Join(" ", numArray)); 
Console.WriteLine("Количество чётных чисел в массиве = " + EvenNumbers(numArray));