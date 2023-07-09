Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int i = 0;
while (i < (number1 - 1))
{
    Console.Write(i += 2);
}