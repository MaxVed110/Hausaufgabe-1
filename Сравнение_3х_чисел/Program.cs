int numberA = new int();
int numberB = new int();
int numberC = new int();

Console.Write("Введите первое число: ");
numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if(numberB > max)
{
    max = numberB;
    if(numberC > max) max = numberC;
    else max = numberB;
}
else
{
    if(numberC > max) max = numberC;
    else max = numberA;
}

if (numberA == numberB && numberB == numberC) Console.WriteLine("Числа равны");
else Console.WriteLine("Наибольшее число: " + max.ToString());
  