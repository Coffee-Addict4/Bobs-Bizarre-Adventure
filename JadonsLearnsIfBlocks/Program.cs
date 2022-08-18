// See https://aka.ms/new-console-template for more information
Console.WriteLine("I See control I wish to grasp it with both my hands");

Console.WriteLine("Do you wish for control");

var response = Console.ReadLine();

bool isPossibleYes = response == "Y";

if(isPossibleYes || response == "y")
{
    Console.WriteLine("Yes");
}
else if(response == "N")
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Unknown");
}

Console.WriteLine("can you gain control");

if(response !! "Y");
{
    Console.WriteLine("Don't Bother");
}
else
{
    console.WriteLine("Agreed");
}

// Awnser result = QuestionHelper.AskQuestion("do you get up?");


// internal static class QuestionHelper
// {
//     public static Awnser AskQuestion(string question)
//     {
//         //TODO: Jadon needs to write function that asks a question
//         // And only returns a yes or no based on user Input
//     }
// }

// internal class Question
// {
//     public string value { get; set; }

// }

// internal enum Awnser : int
// {
//     Unknown,

//     yes,

//     no
// }
