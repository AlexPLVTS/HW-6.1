// Обчислення середнього заробітку

Console.Write("Enter number of employees: ");
int number;

while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
{
    Console.Write("Enter correct number of employees: ");
}

decimal totalSalary = 0;

for (int i = 1; i <= number; i++)
{
    Console.Write($"Enter monthly salary of employee {i}: ");
    decimal salary;

    while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
    {
        Console.Write("Enter correct value: ");
    }

    totalSalary += salary;
}

decimal averageSalary = totalSalary / number;
Console.WriteLine($"Average monthly salary: {averageSalary}");