/* 1019
------------------
Read an integer value, which is the duration in seconds of a certain event in a factory, and inform it expressed in hours:minutes:seconds.

Input
The input file contains an integer N.

Output
Print the read time in the input file (seconds) converted in hours:minutes:seconds like the following example.

Input Sample	Output Sample
556

0:9:16 */

//Time Duration in Second
var timeDuration = Convert.ToInt64(Console.ReadLine());

var hour = timeDuration / 3600;
var hourRest = timeDuration % 3600;

var minute = hourRest / 60;
var minuteRest = hourRest % 60;

var second = minuteRest;

Console.WriteLine(timeDuration);
Console.WriteLine($"{hour}:{minute}:{second}");