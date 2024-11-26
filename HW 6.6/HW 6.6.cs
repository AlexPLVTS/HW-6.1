/* Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, 
 * та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.
 */

decimal hours = 0;
decimal rate = 0;

while (true)
{
    Console.Write("Enter working hours per day: ");
    string inputHours = Console.ReadLine();

    if (decimal.TryParse(inputHours, out hours) && hours >= 0 && hours <= 24)
    {
        break;
    }
    else
    {
        Console.WriteLine("Wrong input");
    }
}

while (true)
{
    Console.Write("Enter amount paid per 1 hour: ");
    string inputRate = Console.ReadLine();

    if (decimal.TryParse(inputRate, out rate) && rate >= 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Wrong input");
    }
}
decimal dailyPayment = hours * rate;
Console.WriteLine("Your daily wage: " + dailyPayment);