/*
1038
-----
Using the following table, write a program that reads a code and the amount of an item. After, print the value to pay. This is a very simple program with the only intention of practice of selection commands.

Input
The input file contains two integer numbers X and Y. X is the product code and Y is the quantity of this item according to the above table.

Output
The output must be a message "Total: R$ " followed by the total value to be paid, with 2 digits after the decimal point.

Input Sample	Output Sample
3 2

Total: R$ 10.00
*/

short X = Convert.ToInt16(Console.ReadLine());
short Y = Convert.ToInt16(Console.ReadLine());


if (X == 1)
{
    var value1 = (Y * 4);
    var valuestr1 = value1.ToString("0.00");
    Console.WriteLine(valuestr1);
}
if (X == 2)
{
    var value2 = Y * 4.5;
    var valuestr2 = value2.ToString("0.00");
    Console.WriteLine(valuestr2);
}
if (X == 3)
{
    var value3 = Y * 5;
    var valuestr3 = value3.ToString("0.00");
    Console.WriteLine(valuestr3);
}
if (X == 4)
{
    var value4 = Y * 2;
    var valuestr4 = value4.ToString("0.00");
    Console.WriteLine(valuestr4);
}
if (X == 5)
{
    var value5 = Y * 1.5;
    var valuestr5 = value5.ToString("0.00");
    Console.WriteLine(valuestr5);
}

