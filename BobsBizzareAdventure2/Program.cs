using System;
using System.Collections;
using System.Collections.Generic;

namespace BobsBizzareAdventure2
{
    class Program
    {

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.WriteLine("     I Am The Narrater I Look Down at the player, and I Think WHAT ARE YOU DOING");
            Console.WriteLine("   FROM ABOVE YOU LOOK LIKE A IDIOT, YOU THE PLAYER DICIDED IT WOULD BE A GOOD IDEA");
            Console.WriteLine("                   TO PRESS THAT BIG RED BUTTON ON THE DEATH PANEL,");
            Console.WriteLine(" ");
            Console.WriteLine("                 I want my own adventure, Hey Player Will you Help me ?");
            Console.WriteLine(" ");

            Program p = new Program();
            p.Run();

            Console.WriteLine(" ");
            Console.WriteLine("                                       Game Over");
            Console.WriteLine(" ");
            Console.WriteLine("                                double tap enter to close");
            Console.ReadLine();

        }

        public void Run()
        {
            var multiChoiceAwnser = AskMultiplyChoiceQuestion(new List<Question>
            { new Question
              {
                Value = "        Laugh: PFFFF AHAAHAHAHAHAAH YOUR NAME IS BOB, REALLY YOUR NAME IS BOB"
              },
              new Question
              {
                Value = "         Lazy: Have Fun with That Because I'm not helping"
              },
              new Question
              {
                Value = "Super Sarcasm: Ya That would be Awsome Narraror Your such a Good Friend"
              },
              new Question
              {
                Value = "      Sarcasm: oh Really You Want an Adventure"
              }
            });


            switch (multiChoiceAwnser.AwnseredNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.WriteLine("      The Narrator BOB: Well I Dont think's it's that Funny Thank YOU");
                    Console.WriteLine(" ");
                    Console.WriteLine("                                        BANG!!!!!");
                    Console.WriteLine("                                    You were Shot With a Revolver!!!");
                    return;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.WriteLine("      The Narrator BOB: You won't Help Me ?!, you Lazy Jerk I'll have you Shot for this");
                    Console.WriteLine(" ");
                    Console.WriteLine("                                    5 Year's Later");
                    Console.WriteLine("                                   BANG BANG BANG!!!!!");
                    Console.WriteLine("                                    You were Shot With a Rifle!!!");
                    Console.WriteLine("                                   By The Assassin");
                    return;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.WriteLine("      The Narrator BOB: Flattery won't get you places kid");
                    Console.WriteLine(" ");
                    Console.WriteLine("                                   BANG BANG BANG!!!!!");
                    Console.WriteLine("                                    You were Shot With a Revolver!!!");
                    Console.WriteLine("                                   By The Narrator BOB");
                    return;

                   default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.WriteLine("      The Narrator BOB: That a big ask or something?");
                    return;

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
            if (string.IsNullOrWhiteSpace(question))
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
            for (int index = 0; index < questions.Count; index++)
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


}   }  
