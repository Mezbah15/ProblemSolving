/* 1010
--------
In this problem, the task is to read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2. After this, calculate and show the amount to be paid.

Input
The input file contains two lines of data. In each line there will be 3 values: two integers and a floating value with 2 digits after the decimal point.

Output
The output file must be a message like the following example where "Valor a pagar" means Value to Pay. Remember the space after ":" and after "R$" symbol. The value must be presented with 2 digits after the point.*/

var product_1 = Console.ReadLine().Split(' ');
var product_1Code = int.Parse(product_1[0]);
var product_1Units = int.Parse(product_1[1]);
var product_1Price = double.Parse(product_1[2]);

var product_2 = Console.ReadLine().Split(' ');
var product_2Code = int.Parse(product_2[0]);
var product_2Units = int.Parse(product_2[1]);
var product_2Price = (double.Parse(product_2[2]));

var amount = (product_1Units * product_1Price) + (product_2Units * product_2Price);
var totalAmount = amount.ToString("0.00");

Console.WriteLine("Valor a pagar: R$ " + totalAmount);



