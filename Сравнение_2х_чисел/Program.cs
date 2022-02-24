int numberA = new int();
int numberB = new int();

Console.Write("Введите число №1: ");
numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) Console.WriteLine("Большее число: " + numberA.ToString());
if (numberB > numberA) Console.WriteLine("Большее число: " + numberB.ToString());
if (numberA == numberB) Console.WriteLine("Числа равны");