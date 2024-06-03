/*
1098
--------
Make a program that prints the sequence like the following example.

Input
This problem doesn't have input.

Output
Print the sequence like the example below.

Input Sample	Output Sample
I=0 J=1
I=0 J=2
I=0 J=3

I=0.2 J=1.2
I=0.2 J=2.2
I=0.2 J=3.2

I=0.4 J=1.4
I=0.4 J=2.4
I=0.4 J=3.4  
.....
I=2 J=?
I=2 J=?
I=2 J=?
*/
for (double i = 0; i <= 2; i +=0.2)
{
    
    for (double j = 1; j <= 3; j++)
    {
        double x = 0.0; //0.2
        Console.WriteLine($"I={i} J={j+x}");

        if (j == 3)
        {
            x += 0.2;
        }
    }
}