Console.Write("Введите число: ");
double N =  Convert.ToInt32(Console.ReadLine());
double x = 1;

while (x <= N)
{ 
    if ((x % 2) == 0)
    {
    Console.WriteLine(x);
    }
    x++;
}

