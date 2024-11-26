/* Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, 
 * а потім генерує таблицю множення для цього числа від 1 до 10.
 */

Console.Write("Enter number for multiplication table: ");
string inputNumber = Console.ReadLine();

decimal number = 0;

if (decimal.TryParse(inputNumber, out number))
{
    Console.WriteLine("Multiplication table for " + number);

    for (int i = 1; i <= 10; i++)
    {
        decimal result = number * i;
        Console.WriteLine($"{number} * {i} = {result}");
    }
}
else
{
    Console.WriteLine("Wrong input");
}

