using Bobsadventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace BobsAdveture
{



    class Program
    {
        private const ConsoleColor red = ConsoleColor.Red;

        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();

            Console.WriteLine("Press:double tap enter to close");
            Console.ReadLine();
        }

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hey BOB GET UP");
            
            Thread.Sleep(TimeSpan.FromSeconds(1.5));
            Console.WriteLine("your Wife's telling you, It's Time to get Up");
            
            Awnser result = AskQuestion("Do you wake up? y/n:", 'y', 'n');

            switch (result)
            {
                case Awnser.No:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("your Wife Came Up and stabbed you to death while you slept");
                    Console.WriteLine("You Died a not so peacefully Death While You Slept");
                    Console.WriteLine("GAME OVER");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Well What Did You Think Would Happen");
                    return;
                case Awnser.Yes:
                    Console.WriteLine("You Wake up");
                    Console.WriteLine("And are Ready to Start The Day");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You Smell Breakfast");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Awnser.Unknown:
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you hesitated and Your Wife Came Up And Stabbed You To Death");
                    Console.WriteLine("GAME OVER");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Perhaps Choose an option on screen Next time");
                    return;
            }


            var multiChoiceAwnser = AskMultiplyChoiceQuestion(new List<Question>
            {
                new Question
                {
                    Value = "Decide What To Wear"
                },
                new Question
                {
                    Value = "go downstair's To Eat breakfast"
                },
                new Question
                {
                    Value = "Go Outside (Naked)"
                }
            });

            switch(multiChoiceAwnser.AwnseredNumber)
            {
                case 1:
                    Console.WriteLine("Do You Wear?");  
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("you Went downstairs and tred to eat breakfast naked. Your wife screams Robber and throws a knife at you");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you die...");
                    Console.WriteLine("GAME OVER");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Perhaps IT's Best not Surprize Your Wife Like That (I Mean seriously Dude Chill)");
                    return;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You Decide to go Commando");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the police see you naked and they beat you to Death...");
                    Console.WriteLine("GAME OVER");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Perhaps IT's Best not to Go outside nude in communist czech");
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you hesitated and DIED");
                    Console.WriteLine("GAME OVER");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Perhaps Choose an option on screen Next time");
                    return;
            }

            multiChoiceAwnser = AskMultiplyChoiceQuestion(new List<Question>
            {
                new Question
                {
                    Value = "your Black shirt And Pants With a Skee Mask"
                },
                new Question
                {
                    Value = "Your Normal Suit and Tie"
                },
                  new Question
                {
                 Value = "your Monkey Suit"
                },
                new Question
                {
                Value = "your Bee Suit"
                }

            });

            switch (multiChoiceAwnser.AwnseredNumber)
            {
                    case 1:
                    Console.WriteLine("You Decide to Wear");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("your Black shirt And Pants With a Skee Mask");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You Walk DownStairs");
                    Console.WriteLine("Your Wife See's You in a Black shirt And Pants With a Skee Mask, She Screem's Theif and Throw's her knife at you");
                    Console.WriteLine("Bad Luck For You She Is So Terrified Her instinstics Kick in, SHE HITS YOU SQARE IN THE FOREHEAD YOU FALL BACK AND BLEED OUT");
                    Console.WriteLine("The Wife: It was an Accident");
                    Console.WriteLine("You Know Gazing Down at them From Heaven, She Meant To kill You, She even Planned What She would do after you were dead, she was going to disney world");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Got THE BAD ending");
                    return;

                    case 2:
                    Console.WriteLine("You Decide to Wear");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your Normal Suit and Tie");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You Walk DownStairs");
                    Console.WriteLine("Your Wife See's You in a Your Normal Suit and Tie, She Throw's her knife at you (You Think To Yourself After all Iv'e Worked For Her, How Could she KILL Me)");
                    Console.WriteLine("Luckly She Misses, She Say's that Shes Done With You And that She's Leaveing She Open's The Door Just Then You Here Woo Hoo ha ha And a Monkey");
                    Console.WriteLine("Bite's Your Wife's Neck HER Head Is Barely Still Attached to her Body Then You Hear a Buzzing But Before you Can See What it is");
                    Console.WriteLine("The Monkey Bite's off Your Leg as You Sit There Bleeding out The Source of the Buzzing Break's through Your Kitchen Window");
                    Console.WriteLine("it's A SWARM OF BEE's, The Monkey Run's Away Leaveing Out the Front Door, Then The Bee's Sting You TO DEATH in there Fenzy");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You Got PAINFUL ending");
                    return;

                    case 3:
                    Console.WriteLine("You Decide to Wear");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("a Monkey Suit");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You Walk DownStairs");
                    Console.WriteLine("Your Wife See's You in a Bee Suit, She Screem's Theif and Throw's her knife at you");
                    Console.WriteLine("Luckly She Misses, Just Then You Here Woo Hoo ha ha And a Monkey Break's through Your Front Door He Look's Terrified, Then He See's Your Monkey Suit Suit");
                    Console.WriteLine("He Thinks Your an Alpha Male, And Run's Back Were he Came From");
                    Console.WriteLine("Luckly She Misses, She Say's That Shes Done With You And that She's Leaveing She Open's The Door Just Then You Hear Some Buzzing");
                    Console.WriteLine("A SWARM OF ANGRY BEE'S Come throw The Newly Open Door And Sting Your Wife To Death Then in there now calm state Return To The Outside");
                    Console.WriteLine("You call the Police And inform them that your Wife was Stung To Death, They Tell You That They Will Be there Shortly");
                    Console.WriteLine("When The Police Arrive They See Your wife Dead, However She Show No Swelling And it Look's Like You Beat her To Death With The Knife");
                    Console.WriteLine("Seeing This They Cuff You and Send you off to jail Despite Your Bizarre Claims");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You Got THE CRAZY HUSBEND ending");
                    return;

                    case 4:
                    Console.WriteLine("You Decide to Wear");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("your Bee Suit");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You Walk DownStairs");
                    Console.WriteLine("Your Wife See's You in a Bee Suit, She Screem's Theif and Throw's her knife at you");
                    Console.WriteLine("Luckly She Misses, Just Then You Here Woo Hoo ha ha And a Monkey Break's through Your Front Door he Look's Terrified, He See's Your Bee Keeper Suit");
                    Console.WriteLine("It Scare's Him He See's Your Wife and Attack's Her Biteing Her Neck, She's Dying, Just Then Some Bee's Come through Your Front Door");
                    Console.WriteLine("You Guess That's Why The Monkey Was So Scared Sence Your Wearing A Bee Keeper Suit You Can Just Walk Out the Front Door");
                    Console.WriteLine("You Run To Get Help And Get Ran Over By a Car");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You Got The TRUE ending");
                    Console.WriteLine("Hope You Enjoyed");
                    Console.WriteLine("Bobs Bizarre Adveture");
                    break;
            }
        }


        private bool AskYesOrNoQuestion(string question, char trueAwnser, char? falseAwnser = null)
        {
            if (string.IsNullOrWhiteSpace(question))
            {
                throw new ArgumentNullException(nameof(question));
            }

            bool? awnser = null;
            do
            {
                Console.Write(question);

                var key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case char c when c == trueAwnser:
                        awnser = true;
                        break;
                    case char c when falseAwnser == null || c == falseAwnser:
                        awnser = false;
                        break;
                    default:
                        Console.WriteLine();

                        Console.WriteLine("PLease try again");
                        break;
                        
                }
            }
            while (awnser.HasValue == false);
            Console.WriteLine();
            return awnser.Value;
        }
        private Awnser AskQuestion(string question, char trueAwnser, char? falseAwnser = null)
        {
            if(string.IsNullOrWhiteSpace(question))
            {
                throw new ArgumentNullException(nameof(question));
            }

            Awnser? awnser = null;
            do
            {
                Console.Write(question);

                var key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case char c when c == trueAwnser:
                        awnser = Awnser.Yes;
                        break;
                    case char c when falseAwnser == null || c == falseAwnser:
                        awnser = Awnser.No;
                        break;
                    default:
                        awnser = Awnser.Unknown;
                        break;

                }
            }
            while (awnser.HasValue == false);
            Console.WriteLine();
            return awnser.Value;
        }

        private (int AwnseredNumber, Question QuestionAwnsered) AskMultiplyChoiceQuestion(List<Question> questions, int timesToAsk = 10)
        {
            if (questions == null)
            {
                throw new ArgumentNullException(nameof(questions));
            }
            if (questions.Count == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(questions), "Need to ask at least one quest.");
            }
            if (questions.Count > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(questions), "Only supports up to nine questions.");
            }
 
            string questionsToAsk = string.Empty;
            Dictionary<int, Question> keyValuePairs = new Dictionary<int, Question>(questions.Count); 
            for(int index = 0; index < questions.Count; index++)
            {
                // index=1 +1 =2

                // index = index + 1 == index++;

                var number = index + 1;
                var question = questions[index];
                keyValuePairs.Add(number, question);

                questionsToAsk += $"{number}. {question.Value}\r\n";
            }

            int timesAsked = 0;

            do
            {
                Console.Write(questionsToAsk);

                var key = Console.ReadKey();

                string numberString = new string(key.KeyChar, 1);

                if (int.TryParse(numberString, out int awnserKey) 
                    && keyValuePairs.TryGetValue(awnserKey, out Question question))
                {
                    Console.WriteLine();
                    return (awnserKey, question);
                }
                Console.WriteLine();
            }
            while (++timesAsked > timesToAsk);

            return (-1, null);
        }

    }
}
