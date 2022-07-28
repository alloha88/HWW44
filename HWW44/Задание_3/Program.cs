//  Задайте массив вещественных чисел. 

double [] FillArray(double [] arr) 
{
  int length = arr.Length; 
  int i = 0; 
  while(i < length) 
  {
    arr[i] = new Random().Next(1,100) / 10.0; 
    i++; 
  }
  return arr; 
}
double FindDif (double [] arr1)
{
    int length = arr1.Length;
    int i = 0;
    double max = arr1[i];
    double min = arr1[i];
    while(i < length)
    {
      if(arr1[i] > max) max = arr1[i];
      if(arr1[i] < min) min = arr1[i];
      i++;
    }
    double dif = max - min;
    return dif;
}
double [] numArray = new double [8];
FillArray(numArray);
Console.WriteLine(String.Join("|",numArray));
Console.WriteLine("Разница = " + FindDif(numArray));