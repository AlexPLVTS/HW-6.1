/* Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. 
 * Число вважається простим, якщо воно ділиться лише на 1 і на себе.
 */

Console.Write("Enter number to test for primality: ");
int number;

while (!int.TryParse(Console.ReadLine(), out number) || number < 2)
{
    Console.WriteLine("Wrong input, number must be even and more or equal than 2");
}

bool isPrime = true;

for (int i = 2; i <= Math.Sqrt(number); i++)
{
    if (number % i == 0)
        isPrime = false; 
        break;
}
if (isPrime)
{
    Console.WriteLine($"{number} is prime");
}
else
{
    Console.WriteLine($"{number} is not prime");
}