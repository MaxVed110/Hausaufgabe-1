int number = new int();
int count = new int();

count = 2;

Console.Write("Введите целое положительное число: ");
number = Convert.ToInt32(Console.ReadLine());

if (number >= 2)
{
    Console.Write("Чётные числа: ");
    while (count <= number)
    {
        Console.Write(count.ToString() + ", ");
        count = count + 2;
    }
}
else 
{
    Console.WriteLine("Чётных чисел нет");
}
