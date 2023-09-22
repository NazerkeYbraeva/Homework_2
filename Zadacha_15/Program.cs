//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

bool FindWeekEnd(int num)
{
  int we = 6 & 7;
  if(num < we)
  {
    return false;
  }
  else
  {
    return true;
  }
}

int num = new Random().Next(1, 7 + 1);
Console.WriteLine(num);
bool result = FindWeekEnd(num);
Console.WriteLine(result);