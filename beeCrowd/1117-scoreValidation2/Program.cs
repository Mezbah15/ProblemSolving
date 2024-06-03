/* 
1117
-----------
Write a program that reads two scores of a student. Calculate and print the average of these scores. Your program must accept just valid scores [0..10]. Each score must be validated separately.

Input
The input file contains many floating-point numbers​​, positive or negative. The program execution will be finished after the input of two valid scores.

Output
When an invalid score is read, you should print the message "nota invalida".
After the input of two valid scores, the message "media = " must be printed followed by the average of the student. The average must be printed with 2 numbers after the decimal point.

Input Sample	Output Sample
-3.5
3.5
11.0
10.0

nota invalida
nota invalida
media = 6.75 */

LinkedList<string> results = new LinkedList<string>();
double input1;
double input2;
while (true)
{
     input1 = double.Parse(Console.ReadLine());
    if (input1 >= 0 && input1 <= 10)
    {
        //we can keep the value into a variable. a = input1;
        break;
    }
    else
    {
        results.AddLast("nota invalida");
    }
}
while (true)
{
     input2 = double.Parse(Console.ReadLine());

    if (input2 >= 0 && input2 <= 10)
    {
        break;
    }
    else
    {
        results.AddLast("nota invalida");
    }
}

double average = (input1 + input2) / 2.0;
results.AddLast($"media = {average.ToString("0.00")}");

foreach (var item in results)
{
    Console.WriteLine(item);
}