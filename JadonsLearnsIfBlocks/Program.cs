// See https://aka.ms/new-console-template for more information
Console.WriteLine("I am the lorax I Speak for the Trees]");


var response = Console.ReadLine();

if(response == "Y" || response == "y")
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
