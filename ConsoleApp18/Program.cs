Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());

int Sum(int first, int second)
{
    int s = first + second;
    return s;
}
Console.WriteLine();
int result = Sum(first, second);
Console.WriteLine($"{first} + {second} = {result}");