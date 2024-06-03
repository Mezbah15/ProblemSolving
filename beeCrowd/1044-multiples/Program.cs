/*
 * 1044
-----
Read two integer values (A and B). After, the program should print the message "Sao Multiplos" (are multiples) or "Nao sao Multiplos" (aren’t multiples), corresponding to the read values.

Input
The input has two integer numbers.

Output
Print the relative message to the input as stated above.

Input Sample	Output Sample
6 24

Sao Multiplos
*/

var input = Console.ReadLine().Split();
var  A = int.Parse(input[0]);
var  B = int.Parse(input[1]);

if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}
