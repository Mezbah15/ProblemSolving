/*1064
------------------------
Read 6 values that can be floating point numbers. After, print how many of them were positive. In the next line, print the average of all positive values typed, with one digit after the decimal point.

Input
The input consist in 6 numbers that can be integer or floating point values. At least one number will be positive.

Output
The first output value is the amount of positive numbers. The next line should show the average of the positive values ​typed.

Input Sample	Output Sample
7
-5
6
-3.4
4.6
12

4 valores positivos
7.4
*/
int count = 0;
double sum = 0;
for (int i = 0; i < 6; i++)
{
    double number;
    if (!double.TryParse(Console.ReadLine(), out number))
    {
        return;
    }

    /*var input = Console.ReadLine().Split();
    int count = 0;
    double sum = 0;

    foreach (var item in input)
    {
        double number;
        if (!double.TryParse(item, out number))
        {
            Console.WriteLine("Invalid");
            return;
        } */
    if (number > 0)
    {
        count++;
        sum += number;
    }
}
var average = sum / count;
Console.WriteLine(count + " valores positivos");
Console.WriteLine(average.ToString("0.0"));