/* 1035
----------------------
Read 4 integer values A, B, C and D. Then if B is greater than C and D is greater than A and if the sum of C and D is greater than the sum of A and B and if C and D were positives values and if A is even, write the message “Valores aceitos” (Accepted values). Otherwise, write the message “Valores nao aceitos” (Values not accepted).

Input
Four integer numbers A, B, C and D.

Output
Show the corresponding message after the validation of the values​​.

Input Sample	Output Sample
5 6 7 8

Valores nao aceitos */

var A = Convert.ToInt32(Console.ReadLine());
var B = Convert.ToInt32(Console.ReadLine());
var C = Convert.ToInt32(Console.ReadLine());
var D = Convert.ToInt32(Console.ReadLine());

if(B > C && D > A && (C + D) > (A + B) && C >= 0 && D >= 0 && (A % 2 == 0))
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}