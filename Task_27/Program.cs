// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

// принимаем на вход число

int ReadNumber(string usernumber)
{
  Console.WriteLine(usernumber);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}
int SumOfDigit(int number)
{
  int sum = 0;
  while(number>0)
  {
    sum = sum + number % 10;
    number = number/10; // number /= 10 
  }
  return sum;
}

int number = ReadNumber("Введите число");
int Sum = SumOfDigit(number);
Console.WriteLine(Sum);