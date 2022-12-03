Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());

double x = number % 2;

if (x == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}