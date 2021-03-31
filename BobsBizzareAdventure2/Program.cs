using System;
using System.Collections;
using System.Collections.Generic;

namespace BobsBizzareAdventure2
{
    class Program
    {
        // Note that I only know half of what any of this dose,
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Can I somehow Slow his typing ?, and maybe play some sounds?, like music
            Console.WriteLine(" ");
            // add delay
            Console.WriteLine("     I Am The Narrater I Look Down at the player, and I Think WHAT ARE YOU DOING");
            Console.WriteLine("   FROM ABOVE YOU LOOK LIKE A IDIOT, YOU THE PLAYER DICIDED IT WOULD BE A GOOD IDEA");
            Console.WriteLine("                   TO PRESS THAT BIG RED BUTTON ON THE DEATH PANEL,");
            Console.WriteLine(" ");
            Console.WriteLine("                 I want my own adventure, Hey Player Will you Help me ?");
            Console.WriteLine(" ");
            // NEVER BREAKPOINT V
            Program p = new Program();
            p.Question();

            Console.WriteLine(" ");
            Console.WriteLine("                                       Game Over");
            // add Delay
            Console.WriteLine(" ");
            Console.WriteLine("                                double tap enter to close");
            Console.ReadLine();

        }

        public void Question()
        {
            var multiChoiceAwnser = AskMultiplyChoiceQuestion(new List<Question>
            {
              new Question
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

                    case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.WriteLine("      The Narrator BOB: That a big ask or something?");
                    Console.WriteLine("      The Player: uhh Yeah kinda");
                    Console.WriteLine("      The Narrator BOB: Well Then . . . . .");
                    // Need to add Wait Timer Here
                    Console.WriteLine("      The Narrator BOB: Hmm then Will you Help me With Upper Management player ?");
                    break;

            }

        }
        public void response()
        {
                 //    /\ I think this is an object
            var multiChoiceAwnser = AskMultiplyChoiceQuestion(new List<Question>
            { new Question
              {
                Value = "         Mean: no"
              },
              new Question
              {
                Value = "       Greedy: Maybe"
              },
              new Question
              {
                Value = "         Nice: yes"
              },
               new Question
              {
                Value = "       Creepy: YESSS"
              },
              new Question
              {
                Value = "      Question: Upper Management?"
              },
              new Question
              {
                Value = "      Sarcasm: Ya That would be great Narraror Your such a Great Friend"
              }
            });


            switch (multiChoiceAwnser.AwnseredNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("            Response1");
                    return;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("            Response2");
                    return;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("            Response3");
                    return;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("            Response4");
                    return;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("            Response5");
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("            Response6");
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

                // Need to fix This V
                switch (key.KeyChar)
                {
                    case char c when c == trueAwnser:
                        awnser = true;
                        break;
                    case char c when falseAwnser == null || c == falseAwnser:
                        awnser = false;
                        break;
                    default:
                        Console.WriteLine("Evil Mike: Try Again idoit");
                        // also need to add delay here as well
                        Console.WriteLine("Good Colly: He means PLease try again");
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

            string questionsToAsk = string.Empty; // Very Importent figure out what this is again, NEVER BREAKPOINT
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
