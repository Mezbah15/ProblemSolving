/* The following sequence of numbers 0 1 1 2 3 5 8 13 21 ... is known as the Fibonacci Sequence. Thereafter, each number after the first 2 is equal to the sum of the previous two numbers. Write an algorithm that reads an integer N (N < 46) and that print the first N numbers of this sequence.

Input
The input file contains an integer number N (0 < N < 46).

Output
The numbers ​​should be printed on the same line, separated by a blank space. There is no space after the last number.

Input Sample	Output Sample
5

0 1 1 2 3 */
//presentation error
int input = int.Parse(Console.ReadLine()); //5
int prev2 = 0;
int prev1 = 1;

Console.Write(prev2 + " ");
Console.Write(prev1 + " ");

for (int i = 2; i < input; i++)
{
    int next = prev1 + prev2;
    prev2 = prev1;
    prev1 = next;

    Console.Write(next);
    if (i % input != 0)
    {
        Console.Write(" ");
    }
}
