/*
1066
--------
Make a program that reads five integer values. Count how many   of these values are even, odd, positive and negative. Print these information like following example.

Input
The input will be 5 integer values.

Output
Print a message like the following example with all letters in lowercase, indicating how many of these values ​​are even, odd, positive and negative.

Input Sample	Output Sample
-5
0
-3
-4
12

3 valor(es) par(es)
2 valor(es) impar(es)
1 valor(es) positivo(s)
3 valor(es) negativo(s)
*/
var even = 0;
var odd = 0;
var positive = 0;
var negative = 0;
var number = new int[5];
for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());

    if (number[i] % 2 == 0)
    {
        even++;
    }
    if (number[i] % 2 != 0)
    {
        odd++;
    }
    if (number[i] > 0)
    {
        positive++;
    }
    if (number[i] < 0)
    {
        negative++;
    }
}
Console.WriteLine($"{even} valor(es) par(es)");
Console.WriteLine($"{odd} valor(es) impar(es)");
Console.WriteLine($"{positive} valor(es) positivo(s)");
Console.WriteLine($"{negative} valor(es) negativo(s)");