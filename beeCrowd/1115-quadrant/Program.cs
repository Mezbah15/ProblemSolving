/* 1115
-------
Write a program to read the coordinates (X, Y) of an indeterminate number of points in Cartesian system. For each point write the quadrant to which it belongs. The program finish when at least one of two coordinates is NULL (in this situation without writing any message).

Input
The input contains several tests cases. Each test case contains two integer numbers.

Output
For each test case, print the corresponding quadrant which these coordinates belong, as in the example.

Input Sample	Output Sample
2 2
3 -2
-8 -1
-7 1
0 2

primeiro
quarto
terceiro
segundo
*/
LinkedList<string> results = new LinkedList<string>();
while (true)
{
    string[]? input = Console.ReadLine().Split();
    int X = int.Parse(input[0]);
    int Y = int.Parse(input[1]);

    if (X == 0 || Y == 0)
    {
        break;
    }

    if (X > 0 && Y > 0)
    {
        results.AddLast("primeiro");
    }
    else if (X > 0 && Y < 0)
    {
        results.AddLast("quarto");
    }
    else if (X < 0 && Y < 0)
    {
        results.AddLast("terceiro");
    }
    else if (X < 0 && Y > 0)
    {
        results.AddLast("segundo");
    }
}
foreach (string item in results)
{
    Console.WriteLine(item);
}