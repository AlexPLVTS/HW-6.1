/* Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. 
 * Послідовність Фібоначчі починається з 0 і 1, 
 * а кожне наступне число є сумою двох попередніх чисел у послідовності.
 */
Console.Write("Enter interval of Fibonacci sequence: ");
int interval;
int nextNumber, frstNumber = 0, scndNumber = 1;

while (!int.TryParse(Console.ReadLine(), out interval) || interval <= 0)
{
    Console.WriteLine("Wrong input");
}

for (int i = 0; i < interval; i++)
{
    if (i == 0)
    {
        Console.WriteLine(frstNumber);
    }
    else if (i == 1)
    {
        Console.WriteLine(scndNumber);
    }
    else
    {
        nextNumber = frstNumber + scndNumber;
        Console.WriteLine(nextNumber);
        frstNumber = scndNumber;
        scndNumber = nextNumber;
    }
}