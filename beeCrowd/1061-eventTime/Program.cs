/* 1061
--------------
Peter is organizing an event in his University. The event will be in April month, beginning and finishing within April month. The problem is: Peter wants to calculate the event duration in seconds, knowing obviously the begin and the end time of the event.

You know that the event can take from few seconds to some days, so, you must help Peter to compute the total time corresponding to duration of the event.

Input
The first line of the input contains information about the beginning day of the event in the format: “Dia xx”. The next line contains the start time of the event in the format presented in the sample input. Follow 2 input lines with same format, corresponding to the end of the event.

Output
Your program must print the following output, one information by line, considering that if any information is null for example, the number 0 must be printed in place of W, X, Y or Z:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Consider that the event of the test case have the minimum duration of one minute. “dia” means day, “hora” means hour, “minuto” means minute and “Segundo” means second in Portuguese.

Input Sample	Output Sample
Dia 5
08 : 12 : 23
Dia 9
06 : 13 : 23 

3 dia(s)
22 hora(s)
1 minuto(s)
0 segundo(s)*/

Console.Write("Dia ");
int startDay = Convert.ToInt32(Console.ReadLine());
string[] startTime = Console.ReadLine().Split(':');

Console.Write("Dia ");
int endDay = Convert.ToInt32(Console.ReadLine());
string[] endTime = Console.ReadLine().Split(':');

int startHour = int.Parse(startTime[0]);
int startMinute = int.Parse(startTime[1]);
int startSecond = int.Parse(startTime[2]);
int endHour = int.Parse(endTime[0]);
int endMinute = int.Parse(endTime[1]);
int endSecond = int.Parse(endTime[2]);
int hour = 0;
int minute = 0;
int second = 0;

int day = endDay - startDay;
if (startHour < endHour)
{
    hour = endHour - startHour;
}
else if (startHour > endHour)
{
    hour = 24 - startHour + endHour;
    day -= 1;
}
else if (startHour == endHour)
{
    hour = 0;
}
//Minute
if (startMinute < endMinute)
{
    minute = endMinute - startMinute;
}
else if (startMinute > endMinute)
{
    minute = 60 - endMinute + startMinute;
    hour -= 1;
}
else if (startMinute == endMinute)
{
    minute = 0;
}
//Second
if (startSecond < endSecond)
{
    second = endSecond - startSecond;
}
else if (startSecond > endSecond)
{
    second = 60 - endSecond + startSecond;
    minute -= 1;
}
else if (startSecond == endSecond)
{
    second = 0;
}
if (day == 0 && hour == 0 && minute == 0 && second == 0)
{
    minute += 1;
}
Console.WriteLine($"{day} dia(s)");
Console.WriteLine($"{hour} hora(s)");
Console.WriteLine($"{minute} minuto(s)");
Console.WriteLine($"{second} segundo(s)");

/* Unhandled Exception:
System.FormatException: Input string was not in a correct format.
  at System.Number.StringToNumber (System.String str, System.Globalization.NumberStyles options, System.Number+NumberBuffer& number, System.Globalization.NumberFormatInfo info, System.Boolean parseDecimal) [0x00057] in <65984520577646ec9044386ec4a7b3dd>:0 
  at System.Number.ParseInt32 (System.String s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info) [0x00013] in <65984520577646ec9044386ec4a7b3dd>:0 
  at System.Int32.Parse (System.String s, System.IFormatProvider provider) [0x00008] in <65984520577646ec9044386ec4a7b3dd>:0 
  at System.Convert.ToInt32 (System.String value) [0x0000b] in <65984520577646ec9044386ec4a7b3dd>:0 
  at URI.Main (System.String[] args) [0x0000f] in <ffffacbffb184eacbb96b07cb10c6973>:0 
[ERROR] FATAL UNHANDLED EXCEPTION: System.FormatException: Input string was not in a correct format.
  at System.Number.StringToNumber (System.String str, System.Globalization.NumberStyles options, System.Number+NumberBuffer& number, System.Globalization.NumberFormatInfo info, System.Boolean parseDecimal) [0x00057] in <65984520577646ec9044386ec4a7b3dd>:0 
  at System.Number.ParseInt32 (System.String s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info) [0x00013] in <65984520577646ec9044386ec4a7b3dd>:0 
  at System.Int32.Parse (System.String s, System.IFormatProvider provider) [0x00008] in <65984520577646ec9044386ec4a7b3dd>:0 
  at System.Convert.ToInt32 (System.String value) [0x0000b] in <65984520577646ec9044386ec4a7b3dd>:0 
  at URI.Main (System.String[] args) [0x0000f] in <ffffacbffb184eacbb96b07cb10c6973>:0 */