/* Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок. 
 * Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок
 */
Console.Write("Enter number of rows: ");
int rows;

while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
{
    Console.Write("Wrong input");
}
for (int i = 1; i <= rows; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}