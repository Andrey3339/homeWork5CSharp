void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32); // [1, 31]
}
void CountArray(int[] array)
{
  string evens = string.Empty;
  string odds = string.Empty;
  int evensCount = 0;
  int oddsCount = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)  
    {
        evens = evens + array[i].ToString() + " ";
        evensCount++;
    }
    else
    {
        odds = odds + array[i].ToString() + " ";
        oddsCount++;
    }
  }
    Console.WriteLine("Дни, когда Вася получал тройки - " + odds);
    Console.WriteLine("Дни, когда Вася получал четверки - " + evens);
    if (evensCount > oddsCount)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
Console.Clear();
Console.Write("Введите кол-во элементов масссива от 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1 || n > 100)
{
    Console.Write("Введите кол-во элементов масссива от 1 до 100: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Дни, когда Вася получал оценки: [{string.Join(" ", array)}]");
CountArray(array);
