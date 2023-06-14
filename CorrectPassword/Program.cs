/* Write a C# program that prompts the user to enter a password. 
The program should repeatedly ask the user for the password until they enter the correct password. 
Use a do-while loop to keep prompting the user for input and checking if it matches the correct password.

To complete this assignment, you'll need to define a correct password, prompt the user for their input, 
compare it with the correct password, and repeat this process until the user enters the correct password.

Remember to provide feedback to the user indicating whether their input is incorrect and to keep prompting 
until they enter the correct password. */

String password = "Coding";
String userInput;

 do
 {
    Console.WriteLine("What is the password?");
    userInput = Console.ReadLine();

    if (userInput == password)
    {
        Console.WriteLine("That is the password");
    }
    else
    {
        Console.WriteLine("That is not the password.");
    }
 }
 while ( userInput != password);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
