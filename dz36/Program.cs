//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
int [] FillDigitPositiveArray (int sizeArray)
{
  int [] fillArray = new int [sizeArray];
  Random rnd = new Random();
  for (int i = 0; i < sizeArray; i++)
  {
    fillArray[i] = rnd.Next(-9, 10);
  }
  return fillArray;
}
int SumOfElementsOfOddIndeces (int [] ArrayIn)
{
  int sum = 0;
  for (int i = 1; i < ArrayIn.Length; i+=2)
  {
    sum += ArrayIn[i];
  }
  return sum;
}
int sizeArray = Promt ("Enter the size your array");
int [] newArray = FillDigitPositiveArray(sizeArray);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Sum of element of odd indeces is {SumOfElementsOfOddIndeces(newArray)}");