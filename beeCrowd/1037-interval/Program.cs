﻿/* 1037
---------------
You must make a program that read a float-point number and print a message saying in which of following intervals the number belongs: [0,25] (25,50], (50,75], (75,100]. If the read number is less than zero or greather than 100, the program must print the message “Fora de intervalo” that means "Out of Interval".

The symbol '(' represents greather than. For example:
[0,25] indicates numbers between 0 and 25.0000, including both.
(25,50] indicates numbers greather than 25 (25.00001) up to 50.0000000.

Input
The input file contains a floating-point number.

Output
The output must be a message like following example.

Input Sample	Output Sample
25.01

Intervalo (25,50]
*/

double A = Convert.ToDouble(Console.ReadLine());
if (A >= 0 && A <= 25)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (A > 25 && A <= 50)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (A > 50 && A <= 75)
{
    Console.WriteLine("Intervalo (50,75]");
}
else if (A > 75 && A <= 100)
{
    Console.WriteLine("Intervalo (75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo");
}
