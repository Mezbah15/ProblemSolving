/**
 * 1041
----------
Write an algorithm that reads two floating values (x and y), which should represent the coordinates of a point in a plane. Next, determine which quadrant the point belongs, or if you are at one of the Cartesian axes or the origin (x = y = 0).

If the point is at the origin, write the message "Origem".

If the point is at X axis write "Eixo X", else if the point is at Y axis write "Eixo Y".

Input
The input contains the coordinates of a point.

Output
The output should display the quadrant in which the point is.

Input Sample	Output Sample
4.5 -2.2

Q4
**/
var input = Console.ReadLine().Split();
var x = double.Parse(input[0]);
var y = double.Parse(input[1]);

if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (y == 0)
{
    Console.WriteLine("Eixo X");
}
else if (x == 0)
{
    Console.WriteLine("Eixo Y");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
else
{
    Console.WriteLine("Enter the right input");
}
