//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int Promt (string message)
{
  System.Console.WriteLine(message);
  string str = System.Console.ReadLine() ?? String.Empty;
  double numberDouble = (int) Convert.ToDouble(str);
  int result = (int) Math.Abs(Convert.ToInt32(numberDouble));
  if (result == 0)
  {
    System.Console.WriteLine("You specified an insufficient array size!");
    return -1;
  }
  return result;
}
double [] PaddingWithRealNumbers (int sizeArray)
{
  double [] fillArray = new double [sizeArray];
  Random rnd = new Random();
  for (int i = 0; i < sizeArray; i++)
  {
    fillArray[i] = rnd.Next(-99,100) + Math.Round(rnd.NextDouble(), 2);
  }
  return fillArray;
}
double DifferenceMaxMinValue (double [] ArrayIn)
{
  double maxElement = ArrayIn[0];
  double minElement = ArrayIn[0];
  if (ArrayIn.Length == 1)
  {
    System.Console.WriteLine("Not enough array elements!");
    return -1;
  }

  for (int i = 0; i < ArrayIn.Length; i++)
  {
    if (maxElement<ArrayIn[i])
    {
      maxElement = ArrayIn[i];
    }
    if (minElement>ArrayIn[i])
    {
      minElement = ArrayIn[i];
    }
  }
  System.Console.WriteLine($"Your maximum value is: {maxElement}");
  System.Console.WriteLine($"Your minimum value is: {minElement}");
  return maxElement-minElement;
}
int sizeDoubleArray = Promt ("Enter the size your array");
double [] newArray = PaddingWithRealNumbers(sizeDoubleArray);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Difference betweeen values is: {DifferenceMaxMinValue(newArray)}");