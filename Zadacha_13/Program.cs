//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void FindThirdNum()
{
  Console.Write("Input num: ");
  int num = Convert.ToInt32(Console.ReadLine());
  int third = num % 10;
  if(num < 99 + 1)
  {
    Console.WriteLine("Третьей цифры нет");
  }
  else
  {
    Console.WriteLine(third);
  }
}

FindThirdNum();