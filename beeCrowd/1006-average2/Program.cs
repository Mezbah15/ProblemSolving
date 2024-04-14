/*1006
-------
Read three values (variables A, B and C), which are the three student's grades. Then, calculate the average, considering that grade A has weight 2, grade B has weight 3 and the grade C has weight 5. Consider that each grade can go from 0 to 10.0, always with one decimal place.

Input
The input file contains 3 values of floating points (double) with one digit after the decimal point.

Output
Print the message "MEDIA"(average in Portuguese) and the student's average according to the following example, with a blank space before and after the equal signal.

 */

Console.WriteLine("Enter three student grade respectively: ");
double A = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
double B = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
double C = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);

A = Math.Max(0, Math.Min(10, A));
A = A * 2;
B = Math.Max(0, Math.Min(10, B));
B = B * 3;
C = Math.Max(0, Math.Min(10, C));
C = C * 5;

double SUM = (A + B + C) / (2 + 3 + 5);
string MEDIA = SUM.ToString("0.0");

Console.WriteLine("MEDIA = " + MEDIA);