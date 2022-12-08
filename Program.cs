/* Задача 19: Напишите программу, которая принимает
на вход пятизначное число и проверяет, является ли
оно палиндромом */


/* Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - Палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - Не палиндром.");
}

if (number.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число"); */



/* Задача 21: Напишите программу, которая принимает
на вход координаты двух точек и находит расстояние
между ними в 3D пространстве. */


/* Console.WriteLine("Введите X1: ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1: ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1: ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2: ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2: ");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2: ");
int Zb = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}"); */


/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
double kub = 1;
while (i <= N)
{
kub = Math.Pow(i, 3);
Console.Write($"{kub}; ");
i++;
}