// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{  
  Console.WriteLine("Первое число больше чем второе, и равно: " +number1);
}

if(number1 < number2)
{
  Console.WriteLine("Второе число больше чем первое, и равно: " +number2);
}

if(number1 == number2)
{
  Console.WriteLine("Числа равны ");
}
