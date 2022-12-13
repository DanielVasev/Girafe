// See https://aka.ms/new-console-template for more information

// Age calculator 
Console.Write("Hello add your current age: ");
int curAge = Convert.ToInt32(Console.ReadLine());

Console.Write("add years number: ");
int futAge = Convert.ToInt32(Console.ReadLine());

int sum = curAge + futAge;

Console.WriteLine("You will be that old: " + sum);

// Space between the calculators 
Console.WriteLine();


// Simple int calculator 

Console.Write("Add your first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Add your second number: ");

int num2 = Convert.ToInt32(Console.ReadLine());

int sum1 = num2 + num1;

Console.WriteLine("Your result is: " + sum1);

// Space between the calculators 
Console.WriteLine();



// Decimal calculatro 


Console.Write("Add your first number: ");
double numOne = Convert.ToDouble(Console.ReadLine());
Console.Write("Add your second number: ");
double numTwo = Convert.ToDouble(Console.ReadLine());
double sumDouble = numOne + numTwo;

Console.Write("the sum from your numbers is: " + sumDouble);
