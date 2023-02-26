//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
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
    fillArray[i] = rnd.Next(100, 1000);
  }
  return fillArray;
}
int NumberOfEvenNumbers (int [] ArrayIn)
{
   int count = 0;
  for (int i = 0; i < ArrayIn.Length; i++)
  {
    if (ArrayIn[i]%2 == 0)
    {
      count++;
    };
  }
  return count;
}
int sizeArray = Promt ("Enter the size your of an array of three-digitpositive values");
int [] newArray = FillDigitPositiveArray(sizeArray);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Number of even numbers is {NumberOfEvenNumbers(newArray)}");