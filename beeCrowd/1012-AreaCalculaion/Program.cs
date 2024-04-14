/* 1012
----------------
Make a program that reads three floating point values: A, B and C. Then, calculate and show:
a) the area of the rectangled triangle that has base A and height C.
b) the area of the radius's circle C. (pi = 3.14159)
c) the area of the trapezium which has A and B by base, and C by height.
d) the area of ​​the square that has side B.
e) the area of the rectangle that has sides A and B.

Input
The input file contains three double values with one digit after the decimal point.

Output
The output file must contain 5 lines of data. Each line corresponds to one of the areas described above, always with a corresponding message (in Portuguese) and one space between the two points and the value. The value calculated must be presented with 3 digits after the decimal point.
*/

double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double C = Convert.ToDouble(Console.ReadLine());

//a) Area of Triangle

double triangleArea = (A * C)/2;
string triangleAreaFormated = triangleArea.ToString("0.000");

//b) the area of the radius's circle C. (pi = 3.14159)
double pi = 3.14159;

double radiusCircle = pi * Math.Pow(C, 2);
string radiusCircleFormated = radiusCircle.ToString("0.000");
// c) the area of the trapezium which has A and B by base, and C by height.
double trapezium = (A + B) / 2 * C;
string trapeziumFormated = trapezium.ToString("0.000");

// d) the area of ​​the square that has side B.
double squareArea = Math.Pow(B, 2);
string squareAreaFormated = squareArea.ToString("0.000");

// e) the area of the rectangle that has sides A and B.
double rectangleArea = (A * B);
string rectangleAreaFormated = rectangleArea.ToString("0.000");


Console.WriteLine("TRIANGULO: " + triangleAreaFormated);
Console.WriteLine("CIRCULO: " + radiusCircleFormated);
Console.WriteLine("TRAPEZIO: " + trapeziumFormated);
Console.WriteLine("QUADRADO: " + squareAreaFormated);
Console.WriteLine("RETANGULO: " + rectangleAreaFormated);
