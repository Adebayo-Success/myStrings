// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Question 1
//Input a string and print it out 
// using System.Runtime.InteropServices;

// using Microsoft.VisualBasic.FileIO;

// string myWords = "How are you all in the building";
// Console.WriteLine("my words are : " + myWords);


// //Question 2
// //find the length of a string 
// string aWords = "building";
// int lengthOfWords = aWords.Length;
// Console.WriteLine("the length a words is : " + lengthOfWords);


// //Question 3
// //Sweperate a string
// string mySurnName = "Adebayo";
// string splitCharacters = mySurnName;
// foreach (char c in splitCharacters)
// {
//     Console.Write($"{c}  ");
// }
// Console.WriteLine(" ");
// Console.WriteLine(" ");

// // Question 4
// // seperate a string in a reversed order 
// reversedCharacters();
// static void reversedCharacters()
// {
//     string myName = "khalid";
//     string characters = myName;
//     foreach (char d in characters.Reverse())
//     {
//         Console.Write($"{d}  ");
//     }
// }
// Console.WriteLine(" ");
//Question 5
// count how many words are in this sentences: Success is mine Insha Allah

// System.Console.WriteLine("Enter my slogan ");
// Countwords([Console.ReadLine()!]);
// void Countwords(string[] slogan)
// {   
//     foreach (string word in slogan)
//     {
//         Console.WriteLine("the number of words i this sentence is: " + word.Split().Count());
//     }
// }



// int wordCount = new List<int> [myWord];
// for (int a = 0; a >= wordCount; a++)
// {
//     Console.WriteLine($"Hello, World! {a}");
// }



// //Question 6 
// // Compare two string chck 
// //if  the string are the same print the string 
// //if the length are the same print the length 

// System.Console.WriteLine("Enter my middle name: ");
// string myMiddleName = Console.ReadLine()!;

// System.Console.WriteLine("Enter my surname: ");
// string mySurname = Console.ReadLine()!;

// if(myMiddleName == mySurname && myMiddleName.Length == mySurname.Length)
// {
//     Console.WriteLine("the length of both strings are equal also the string are equal");
// }
// else 
// {
//     Console.WriteLine(" they are not equal");
// }


//Question 7
// input a string  
// chech for the length of the special character 
// if there's special charcters, check for the length of the special charcters 
// if there's numbers, check for the length of the numbers 



// int SpecialCharCount = 0;
// int digitsCount = 0;
// int alphabethCount = 0;
// Console.WriteLine("Enter my Email Address: ");
// string myEmail = Console.ReadLine()!;
// foreach (char i in myEmail)
// {
//     if (char.IsWhiteSpace(i))
//     {
//         SpecialCharCount++;
//     }
//     else if (char.IsDigit(i))
//     {
//         digitsCount++;
//     }
//     else if (char.IsLetter(i))
//     {
//         alphabethCount++;
//     }
// }
// Console.WriteLine("Numbers of special characters is: " + SpecialCharCount);
// Console.WriteLine("Numbers of digit is: " + digitsCount);
// Console.WriteLine("Numbers of letters is: " + alphabethCount);


//Question 8
// input a string and print in defferent lines

//  Console.WriteLine("Enter my Address: ");
//  string myAddress = Console.ReadLine()!;
// Console.WriteLine("my first address is: "+ myAddress);
// Console.WriteLine("my second address is: "+ myAddress);
// System.Console.WriteLine("the number of character in my string is: " + myAddress.Length);


//Question 9
// 1 input a string 
// 2 check for the total number of vowels in the string 
// 3 check for the total number of consonant in the string 
// 4 print the total nubers of vowels and the total number of consonant in the string 

// System.Console.WriteLine("Enter my slogan");
// string mySlogan = Console.ReadLine()!;
// int vowelCount = 0;
// int consonantCount = 0;
// foreach (char c in mySlogan)
// {
//     if (char.IsLetter(c))
//     {
//         char myVowel = (c);

//         if (myVowel  == 'a' ||  myVowel == 'e' || myVowel == 'i' || myVowel  == 'o' || myVowel == 'u')
//             vowelCount++;
//         else
//             consonantCount++;
//     }
// }
// Console.WriteLine("Number of Vowels: " + vowelCount);
// Console.WriteLine("Number of Consonants: " + consonantCount);

using System.Numerics;

// string name = "Adebayo";
// int vowelCount = 0;
// int consonantCount = 0;
// string vowels = " AEIOUaeiou";
// string consonant = "bdyxzfhpwqs";
// for (int o = 0; o < name.Length; o++)
// {
//     foreach (char c in vowels)
//     {
//         if (c == name[o])
//         {
//             vowelCount++;
//         }
//     }
//     foreach (char b in consonant)
//     {

//         if (b == name[o])
//         {
//             consonantCount++;
//         }
//     }
// }
// Console.WriteLine(vowelCount);
// Console.WriteLine(consonantCount);

//Question 10
//Find the maximum of characters in a string 
// variable of my string and the value (user input)
//check for the highest characters in my string 
// how many times does the charster occurs
// Console.WriteLine("Enter my profession");
// List<string> profession = new List<string> ();
// string profession = Console.ReadLine()!;
// char maxChar = char.MaxValue;
// foreach (char k in profession)
// {
//     if (k > maxChar)
//     {
//        maxChar = k;
//     }
// }
//  Console.WriteLine( maxChar);

// Console.WriteLine("Enter my profession");
// // List<string> profession = new List<string> ();
// string profession = Console.ReadLine()!;
// char maxChar = profession[0];
// foreach (char k in profession)
// {
//     if (k > maxChar)
//     {
//        maxChar = k;
//     }
// }
//  Console.WriteLine( maxChar );
// string name = "Adeeeee";
// char maxChar = name.Max();
// System.Console.WriteLine(maxChar);

//Question 11
// System.Console.WriteLine("Enter a door");
// string doors = "that is my friend";
// string sort =new string(doors.OrderBy(c => c).ToArray());
// System.Console.WriteLine(sort);
// foreach(char k in doors)
// {
//     if(k == 0)
//     {

//     }
// }




// int num1 = 0;
// while (num1 <= 9)
// {
//     num1++;
//     Console.Write(num1);
// }

// char letters = 'a';
// char add = 'a';
// while (letters < 'z' )
// {  
//     letters++;
//     add += letters;
//     Console.WriteLine( letters);
// }
//  Console.Write(" = " + add);

// Console.Write("n = ");
// int n = int.Parse(Console.ReadLine()!);
// int num = 1;
// int mult = 1;
// Console.Write("The sum 1");
// while (num < n)
// {
// num++;
// mult *= num;
// Console.Write(" * " + num);
// }
// Console.WriteLine(" = " + mult);


// Console.Write("Enter a positive number: ");
// int num = int.Parse(Console.ReadLine()!);
// int divider = 2;
// int maxDivider = 2;
// bool prime = true;
// while (prime && (divider <= maxDivider))
// {
// if (num % divider == 0)
// {
// prime = false;
// }
// divider++;
// }
// Console.WriteLine("Prime? " + prime);




// int n = int.Parse(Console.ReadLine()!);
// // "decimal" is the biggest C# type that can hold integer values
// decimal factorial = 1;
// // Perform an "infinite loop"
// while (true)
// {
// if (n <= 1)
// {
// break;
// }
// factorial += n;
// n--;
// }
// Console.WriteLine("n! = " + factorial);


// Console.Write("n = ");
// int n = int.Parse(Console.ReadLine()!);
// BigInteger factorial = 1;
// do
// {
// factorial *= n;
// n--;
// } while (n > 0);
// Console.WriteLine("n! = " + factorial);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
int num = n;
long product = 1;
do
{
    product *= num;
    num++;
} while (num <= m);
Console.WriteLine("product[n...m] = " + product);
