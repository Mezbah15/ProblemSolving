/*1052
--------
Read an integer number between 1 and 12, including. Corresponding to this number, you must print the month of the year, in english, with the first letter in uppercase.

Input
The input contains only an integer number.

Output
Print the name of the month according to the input number, with the first letter in uppercase.

Input Sample	Output Sample
4

April
*/

var input = int.Parse(Console.ReadLine());

if (input == 1)
{
    Console.WriteLine("January");
}
else if (input == 2)
{
    Console.WriteLine("February");
}
else if (input == 3)
{
    Console.WriteLine("March");
}
else if (input == 4)
{
    Console.WriteLine("April");
}
else if (input == 5)
{
    Console.WriteLine("May");
}
else if (input == 6)
{
    Console.WriteLine("June");
}
else if (input == 7)
{
    Console.WriteLine("July");
}
else if (input == 8)
{
    Console.WriteLine("August");
}
else if (input == 9)
{
    Console.WriteLine("September");
}
else if (input == 10)
{
    Console.WriteLine("October");
}
else if (input == 11)
{
    Console.WriteLine("November");
}
else if (input == 12)
{
    Console.WriteLine("December");
}
else
{
    Console.WriteLine("Enter the correct Number");
}

/**
string[] months = {
    "January", "February", "March", "April", "May", "June", "July", "August", "September",
    "October", "November", "December"
};
//var input = int.Parse(Console.ReadLine());
if (int.TryParse(Console.ReadLine(), out int input))
{

    if (input >= 1 && input <= 12)
    {
        var monthn = months[input - 1];
        Console.WriteLine(monthn);
    }
    else
    {
        Console.WriteLine("00");
    }
}
else
{
    Console.WriteLine("89");
} **/