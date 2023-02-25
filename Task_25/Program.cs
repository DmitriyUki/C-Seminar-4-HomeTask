// Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int ReadNumber(string usernumber)
{
  Console.WriteLine(usernumber);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}


int DegreeA(int numberA, int numberB) //int a; int b означает что на входе будут целые числа
{
  int  deg = 1;
  for(int i = 1; i<=numberB; i++)
  {
  deg = deg*numberA;
  }
  return deg;
}
int numberA = ReadNumber("Введите число A");
int numberB = ReadNumber("Введите число B");
//int degreeA = DegreeA(numberA, numberB);
Console.WriteLine("Ответ: " + DegreeA(numberA, numberB));
