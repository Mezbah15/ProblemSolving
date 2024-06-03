/* 1036
--------------
Read 3 floating-point numbers. After, print the roots of bhaskara’s formula. If it's impossible to calculate the roots because a division by zero or a square root of a negative number, presents the message “Impossivel calcular”.

Input
Read 3 floating-point numbers (double) A, B and C.

Output
Print the result with 5 digits after the decimal point or the message if it is impossible to calculate.

Input Samples	Output Samples
10.0 20.1 5.1

R1 = -0.29788
R2 = -1.71212 */

var input = Console.ReadLine().Split();
var A = double.Parse(input[0]);
var B = double.Parse(input[1]);
var C = double.Parse(input[2]);

var discriminant = B * B - 4 * A * C;
if (discriminant < 0 || A == 0) // Remember the condition
{ 
    Console.WriteLine("Impossivel calcular");
}
else
{
    var bhaskaras1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
    var R1 = bhaskaras1.ToString("0.00000");

    var bhaskaras2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
    var R2 = bhaskaras2.ToString("0.00000");

    Console.WriteLine("R1 = " + R1);
    Console.WriteLine("R2 = " + R2);
}