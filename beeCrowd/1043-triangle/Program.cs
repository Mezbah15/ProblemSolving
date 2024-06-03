/*
 * 1043
------------
Read three point floating values (A, B and C) and verify if is possible to make a triangle with them. If it is possible, calculate the perimeter of the triangle and print the message:


Perimetro = XX.X


If it is not possible, calculate the area of the trapezium which basis A and B and C as height, and print the message:


Area = XX.X

Input
The input file has tree floating point numbers.

Output
Print the result with one digit after the decimal point.

Input Sample	Output Sample
6.0 4.0 2.0

Area = 10.0 */

var input = Console.ReadLine().Split(); // Split(); it takes whiteSpace only.
double A = double.Parse(input[0]);
double B = double.Parse(input[1]);
double C = double.Parse(input[2]);


if (A + B > C && A + C > B && B + C > A)
{
    double perimeter = (A + B + C);
    string? perimetro = perimeter.ToString("0.0");
    Console.WriteLine("Perimetro = " + perimetro);
}
else
{
    double trapezium = (A + B) / 2 * C;
    string? area = trapezium.ToString("0.0");
    Console.WriteLine("Area = " + area);
}
