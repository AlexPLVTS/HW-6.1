/* Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
 * Просте число - це число, яке ділиться лише на 1 і на себе.
 */

Console.Write("Enter interval for prime numbers: ");
int interval = 0;

while (!int.TryParse(Console.ReadLine(), out interval) ||  interval <= 2)
{
    Console.WriteLine("Wrong input");
}

for (int number = 2; number <= interval; number++)
{
    bool isPrime = true;
    for (int i = 2; i  <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(number);
    }
}
