﻿/*
 * 1040
----------
Read four numbers (N1, N2, N3, N4), which one with 1 digit after the decimal point, corresponding to 4 scores obtained by a student. Calculate the average with weights 2, 3, 4 e 1 respectively, for these 4 scores and print the message "Media: " (Average), followed by the calculated result. If the average was 7.0 or more, print the message "Aluno aprovado." (Approved Student). If the average was less than 5.0, print the message: "Aluno reprovado." (Reproved Student). If the average was between 5.0 and 6.9, including these, the program must print the message "Aluno em exame." (In exam student).

In case of exam, read one more score. Print the message "Nota do exame: " (Exam score) followed by the typed score. Recalculate the average (sum the exam score with the previous calculated average and divide by 2) and print the message “Aluno aprovado.” (Approved student) in case of average 5.0 or more) or "Aluno reprovado." (Reproved student) in case of average 4.9 or less. For these 2 cases (approved or reproved after the exam) print the message "Media final: " (Final average) followed by the final average for this student in the last line.

Input
The input contains four floating point numbers that represent the students' grades.

Output
Print all the answers with one digit after the decimal point.

Input Sample	Output Sample
2.0 4.0 7.5 8.0
6.4

Media: 5.4
Aluno em exame.
Nota do exame: 6.4
Aluno aprovado.
Media final: 5.9
*/

var input = Console.ReadLine().Split(); // Split(); it takes whiteSpace only.
double N1 = double.Parse(input[0]);
double N2 = double.Parse(input[1]);
double N3 = double.Parse(input[2]);
double N4 = double.Parse(input[3]);

double average1 = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / (2 + 3 + 4 + 1);
double average = Math.Round(average1, 1);
//var ave = average.ToString("0.0");
Console.WriteLine("Media: " + average.ToString("0.0"));
if(average >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}
else if(average < 5)
{
    Console.WriteLine("Aluno reprovado.");
}
else if (average >= 5 && average <= 6.9)
{
    Console.WriteLine("Aluno em exame.");
    double N5 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Nota do exame: " + N5.ToString("0.0"));

    double reAverage = (N5 + average) / 2;
    if(reAverage >= 5)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else if(reAverage <= 4.9)
    {
        Console.WriteLine("Aluno reprovado.");
    }
    Console.WriteLine("Media final: " + reAverage.ToString("0.0"));
}