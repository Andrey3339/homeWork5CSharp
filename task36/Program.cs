void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}
void CountArray(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i = i + 2)
  {
    sum += array[i];
  }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях - " + sum);
}
Console.Clear();
Console.Write("Введите кол-во элементов масссива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Сформированный массив: [{string.Join(", ", array)}]");
CountArray(array);
