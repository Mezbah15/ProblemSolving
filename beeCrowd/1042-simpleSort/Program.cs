/**1042
--------
Read three integers and sort them in ascending order. After, print these values in ascending order, a blank line and then the values in the sequence as they were readed.

Input
The input contains three integer numbers.

Output
Present the output as requested above.

Input Sample	Output Sample
7 21 -14

-14
7
21

7
21
-14
**/
string[]? input = Console.ReadLine().Split();
int[] number = new int[input.Length];

for (int i = 0; i < input.Length; i++)
{
    number[i] = int.Parse(input[i]);
}
Array.Sort(number);
foreach (int item in number)
{
    Console.WriteLine(item);
}

Console.WriteLine();
foreach (var item in input)
{
    Console.WriteLine(item);
}