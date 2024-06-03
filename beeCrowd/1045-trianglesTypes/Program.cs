/*
 * 1045
-----
Read 3 double numbers (A, B and C) representing the sides of a triangle and arrange them in decreasing order, so that the side A is the biggest of the three sides. Next, determine the type of triangle that they can make, based on the following cases always writing an appropriate message:

if A ≥ B + C, write the message: NAO FORMA TRIANGULO
if A2 = B2 + C2, write the message: TRIANGULO RETANGULO
if A2 > B2 + C2, write the message: TRIANGULO OBTUSANGULO
if A2 < B2 + C2, write the message: TRIANGULO ACUTANGULO
if the three sides are the same size, write the message: TRIANGULO EQUILATERO
if only two sides are the same and the third one is different, write the message: TRIANGULO ISOSCELES
Input
The input contains three double numbers, A (0 < A) , B (0 < B) and C (0 < C).

Output
Print all the classifications of the triangle presented in the input.

Input Samples	Output Samples
7.0 5.0 7.0

TRIANGULO ACUTANGULO
TRIANGULO ISOSCELES
*/

string[] input = Console.ReadLine().Split();
double[] numbers = new double[input.Length];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = double.Parse(input[i]);
}
Array.Sort(numbers);
Array.Reverse(numbers);

double A = (numbers[0]);
double B = (numbers[1]);
double C = (numbers[2]);

if (A >= B + C)
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else if (A * A == (B * B) + (C * C))
{
    Console.WriteLine("TRIANGULO RETANGULO");
}
else if (A*A > B*B + C*C)
{
    Console.WriteLine("TRIANGULO OBTUSANGULO");
}
else if (A*A < B*B + C*C)
{
    Console.WriteLine("TRIANGULO ACUTANGULO");
}
if (A == B && A == C && B == C)
{
    Console.WriteLine("TRIANGULO EQUILATERO");
}
else if ((A == B || A == C || B ==C))
{
    Console.WriteLine("TRIANGULO ISOSCELES");
}