/* 1134
----------
A gas station wants to determine which of their products is the preference of their customers. Write a program to read the type of fuel supplied (coded as follows: 1. Alcohol 2. Gasoline 3. Diesel 4. End). If you enter an invalid code (outside the range of 1 to 4) a new code must be requested. The program will end when the inserted code is the number 4.

Input
The input contains only integer and positive values.

Output
It should be written the message: "MUITO OBRIGADO" and the amount of customers who fueled each fuel type, as an example.

Input Sample	Output Sample
8
1
7
2
2
4

MUITO OBRIGADO
Alcool: 1
Gasolina: 2
Diesel: 0
*/
LinkedList<object> result = new LinkedList<object>();
int alcohol = 0;
int gasoline = 0;
int diesel = 0;

while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {
        alcohol++;
    }
    else if (input == 2)
    {
        gasoline++;
    }
    else if (input == 3)
    {
        diesel++;
    }
    else if (input == 4)
    {
        break;
    }
    else
    {
        
    }
}
result.AddFirst("MUITO OBRIGADO");
result.AddLast($"Alcool: {alcohol}");
result.AddLast($"Gasolina: {gasoline}");
result.AddLast($"Diesel: {diesel}");
foreach (object item in result)
{
    Console.WriteLine(item);
}