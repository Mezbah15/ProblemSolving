/*1050
--------
Read an integer number that is the code number for phone dialing. Then, print the destination according to the following table:
If the input number isn’t found in the above table, the output must be:
DDD nao cadastrado
That means “DDD not found” in Portuguese language.

Input
The input consists in a unique integer number.

Output
Print the city name corresponding to the input DDD. Print DDD nao cadastrado if doesn't exist corresponding DDD to the typed number.

Input Sample	Output Sample
11

Sao Paulo 
----------
----------
61 Brasilia
71 Salvador
11 Sao Paulo
21 Rio de Jeneiro
32 Juiz de Fora
19 Campinas
27 Vitoria
31 Belo Horizonte*/

var number = Convert.ToInt16(Console.ReadLine());
if (number == 61)
{
    Console.WriteLine("Brasilia");
}
else if (number == 71)
{
    Console.WriteLine("Salvador");
}
else if (number == 11)
{
    Console.WriteLine("Sao Paulo");
}
else if (number == 21)
{
    Console.WriteLine("Rio de Janeiro");
}
else if (number == 32)
{
    Console.WriteLine("Juiz de Fora");
}
else if (number == 19)
{
    Console.WriteLine("Campinas");
}
else if (number == 27)
{
    Console.WriteLine("Vitoria");
}
else if (number == 31)
{
    Console.WriteLine("Belo Horizonte");
}
else
{
    Console.WriteLine("DDD nao cadastrado");
}