//Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

void MiddleDigit()
{
  int n = new Random().Next(100, 999 + 1);
  Console.WriteLine(n);
  int num = (n / 10) % 10;
  Console.WriteLine(num);
}

MiddleDigit();