/* Write an algorithm to read a value A and a value N. Print the sum of N numbers from A (inclusive). While N is negative or ZERO, a new N (only N) must be read. All input values are in the same line.

Input
The input contains only integer values, ​​can be positive or negative.

Output
The output contains only an integer value.

Input Sample	Output Sample
3 2
7
3 -1 0 -2 2
7 */
//var sum = 0;

string[] input = Console.ReadLine().Split(); //3 2
int A = int.Parse(input[0]); //3
while (true)
{
    int N = int.Parse(input[1]); //2 -2
    if (N >= 0)
    {
        break;
    }
    else
    {
        N = int.Parse(Console.ReadLine());
    }
}
