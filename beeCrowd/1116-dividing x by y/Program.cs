/* 1116
-------
Write a program that read two numbers X and Y and print the result of dividing the X by Y. If it's not possible, print the message "divisao impossivel".

Input
The input contains an integer number N. This N is the quantity of pairs of integer numbers X and Y read (dividend and divisor).

Output
For each test case print the result of this division with one digit after the decimal point, or “divisao impossivel” if it isn't possible to perform the calculation.

Obs.: Be carefull. The division between two integers in some languages generates another integer. Use cast:)

Input Sample	Output Sample
3
3 -2
-8 0
0 8

-1.5
divisao impossivel
0.0
*/

int testCaseN = int.Parse(Console.ReadLine());
LinkedList<string> results = new LinkedList<string>();
for (int i = 0; i < testCaseN; i++)
{
    string[]? input = Console.ReadLine().Split();
    double X = double.Parse(input[0]);
    double Y = double.Parse(input[1]);
    if (Y == 0)
    {
        results.AddLast("divisao impossivel");
    }
    else
    {
        double result = X / Y;
        results.AddLast(result.ToString("0.0"));
    }
}
foreach (string item in results)
{
    Console.WriteLine(item);
}