/* 1080
-------
Read 100 integer numbers. Print the highest read value and the input position.

Input
The input file contains 100 distinct positive integer numbers.

Output
Print the highest number read and the input position of this value, according to the given example.

Input Sample	Output Sample
2
113
45
34565
6
...
8
 

34565
4 */
//using System.Linq;
int max = 0;
int maxIndex = 0;
for (int index = 0; index <= 4; index++) //[99]
{
    string? num1 = Console.ReadLine();
   int number1 = int.Parse(num1);

    if (number1 > max)
    {
        max = number1;
        maxIndex = index;
    }
}
Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(maxIndex+1);
