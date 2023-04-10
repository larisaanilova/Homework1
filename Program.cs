Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int min = numberA;
int max = numberB;
if (numberA>numberB)
{
    max = numberA;
    min = numberB;
}
Console.Write("Минимальное число: ");
Console.WriteLine(min);
Console.Write("Максимальное число: ");
Console.WriteLine(max);

