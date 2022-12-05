// See https://aka.ms/new-console-template for more information

// Moving the rest after "n" on the new line 
Console.WriteLine("Giraffe \n Accademy");
 

// How to write down a cittation mark 
Console.WriteLine("Hello \" My friend \" ");


// Using backslash 
string name = "Adam \n \"the fastest\"";
Console.WriteLine(name);

// Concatenation 

string phrase = "Adam" + " is" + " Cool!";
Console.WriteLine(phrase);

//String lenght 
Console.WriteLine(phrase.Length);

//Convert all laters to UPPERCASE
string upperCase = phrase.ToUpper();

Console.WriteLine(upperCase);

string lowerCase = phrase.ToLower();
Console.WriteLine(lowerCase);

//Contains method 

Console.WriteLine(phrase.Contains("A")); 

// Accessing different characters in variable 

Console.WriteLine(phrase[0]);
Console.WriteLine(phrase[3]);

//Index of  Will show us if the character exist and were in the string 

string animal = "Antilopa";
Console.WriteLine(animal.IndexOf('A'));

//Substring() method with one or two parameters... 

string morning = "Good Morning";
Console.WriteLine(morning.Substring(4));
Console.WriteLine(morning.Substring(4, 4));


