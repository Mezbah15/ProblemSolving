/*1048
--------
The company ABC decided to give a salary increase to its employees, according to the following table:

Read the employee's salary, calculate and print the new employee's salary, as well the money earned and the increase percentual obtained by the employee, with corresponding messages in Portuguese, as the below example.
Input
The input contains only a floating-point number, with 2 digits after the decimal point.

Output
Print 3 messages followed by the corresponding numbers (see example) informing the new salary, the among of money earned (both must be shown with 2 decimal places) and the percentual obtained by the employee. Note:
Novo salario:  means "New Salary"
Reajuste ganho: means "Money earned"
Em percentual: means "In percentage"
400.00

Novo salario: 460.00
Reajuste ganho: 60.00
Em percentual: 15 % */

var salary = Convert.ToDouble(Console.ReadLine());
if (salary <= 400)
{
    var newSalary = (salary + salary * 0.15);
    var newSalaryS = newSalary.ToString("0.00");

    var reAdjust = (newSalary - salary);
    var reAdjustS = reAdjust.ToString("0.00");

    Console.WriteLine("Novo salario: " + newSalaryS);
    Console.WriteLine("Reajuste ganho: " + reAdjustS);
    Console.WriteLine("15%");
}
else if (salary > 400 && salary <= 800)
{
    var newSalary = (salary + salary * 0.12);
    var newSalaryS = newSalary.ToString("0.00");

    var reAdjust = (newSalary - salary);
    var reAdjustS = reAdjust.ToString("0.00");

    Console.WriteLine("Novo salario: " + newSalaryS);
    Console.WriteLine("Reajuste ganho: " + reAdjustS);
    Console.WriteLine("12%");
}
else if (salary > 800 && salary <= 1200)
{
    var newSalary = (salary + salary * 0.10);
    var newSalaryS = newSalary.ToString("0.00");

    var reAdjust = (newSalary - salary);
    var reAdjustS = reAdjust.ToString("0.00");

    Console.WriteLine("Novo salario: " + newSalaryS);
    Console.WriteLine("Reajuste ganho: " + reAdjustS);
    Console.WriteLine("10%");
}
else if (salary > 1200 && salary <= 2000)
{
    var newSalary = (salary + salary * 0.07);
    var newSalaryS = newSalary.ToString("0.00");

    var reAdjust = (newSalary - salary);
    var reAdjustS = reAdjust.ToString("0.00");

    Console.WriteLine("Novo salario: " + newSalaryS);
    Console.WriteLine("Reajuste ganho: " + reAdjustS);
    Console.WriteLine("7%");
}
else if (salary > 2000)
{
    var newSalary = (salary + salary * 0.04);
    var newSalaryS = newSalary.ToString("0.00");

    var reAdjust = (newSalary - salary);
    var reAdjustS = reAdjust.ToString("0.00");

    Console.WriteLine("Novo salario: " + newSalaryS);
    Console.WriteLine("Reajuste ganho: " + reAdjustS);
    Console.WriteLine("4%");
}
