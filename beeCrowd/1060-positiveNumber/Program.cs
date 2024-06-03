/* 1060
-----------
Write a program that reads 6 numbers. These numbers will only be positive or negative (disregard null values). Print the total number of positive numbers.

Input
Six numbers, positive and/or negative.

Output
Print a message with the total number of positive numbers.

Input Sample	Output Sample
7
-5
6
-3.4
4.6
12

4 valores positivos
*/

int count = 0;
var number = new double[6];
for (int i = 0; i < number.Length; i++)
{
    number[i] = double.Parse(Console.ReadLine());

    /* 
    var string[] numbers = Console.ReadLine().Split();
    int count = 0;
    foreach (string item in numbers)
    {
        double number;
        if (!double.TryParse(item, out number))
        {
            //Console.WriteLine("invalid");
            return;
        }
    */
    if (number[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count + " valores positivos");
/*
var first = double.Parse(Console.ReadLine());
var second = double.Parse(Console.ReadLine());
var third = double.Parse(Console.ReadLine());
var fourth = double.Parse(Console.ReadLine());
var fifth = double.Parse(Console.ReadLine());
var sixth = double.Parse(Console.ReadLine());
*/