void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); // [100, 999]
}
void CountArray(int[] array)
{
  int evens = 0;
  int odds = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)  
        evens += 1;
    else
        odds += 1;
  }
    Console.WriteLine("Количество четных элементов массива - " + evens);
    Console.WriteLine("Количество нечетных элементов массива - " + odds);
}
Console.Clear();
Console.Write("Введите кол-во элементов масссива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Сформированный массив: [{string.Join(", ", array)}]");
CountArray(array);

