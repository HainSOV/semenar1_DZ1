Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2) 
{
    Console.Write($"Число {number1} больше числа {number2}");
}
else;
{
    Console.Write($"Число {number2} больше числа {number1}");
}
