/*1007
-------
Read four integer values named A, B, C and D. Calculate and print the difference of product A and B by the product of C and D (A * B - C * D).

Input
The input file contains 4 integer values.

Output
Print DIFERENCA (DIFFERENCE in Portuguese) with all the capital letters, according to the following example, with a blank space before and after the equal signal. */

Console.WriteLine("Enter Input for A,B,C,D respectively: ");
int A = Convert.ToInt16(Console.ReadLine());
int B = Convert.ToInt16(Console.ReadLine());
int C = Convert.ToInt16(Console.ReadLine());
int D = Convert.ToInt16(Console.ReadLine());

int DIFERENCA = (A * B) - (C * D);

Console.WriteLine("DIFERENCA = " + DIFERENCA);