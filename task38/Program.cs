void InputArray(double[] array)
{
  int begin = 1; 
  int end = 99;
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}
void CountArray(double[] array)
{
  double max = array[0];
  double min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
      max = array[i];
    if (array[i] < min)
      min = array[i];
  }
    Console.WriteLine("Разница между max и min элементом: {0:F2}", (max - min));
}
Console.Clear();
Console.Write("Введите кол-во элементов масссива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Сформированный массив: [{string.Join(", ", array)}]");
CountArray(array);

