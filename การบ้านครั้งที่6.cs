using System;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
                double score = 0;
                double score_sum = 0;
                int numberlevel = 0;
                double correct_answer = 0;
                int many_answer;
                bool check_input = false;
                while (check_input == false)
                {

                    Difficulty level;
                    level = (Difficulty)numberlevel;
                    Console.WriteLine("Score: {0}, Difficulty: {1}", score_sum, level);
                    if (numberlevel == 0)
                    {
                        numberlevel += 3;
                    }
                    else if (numberlevel == 1)
                    {
                        numberlevel += 4;
                    }
                    else if (numberlevel == 2)
                    {
                        numberlevel += 5;
                    }

                    Console.WriteLine("Please input. \n Number 0 = Start \n Number 1 = Setting \n Number 2 = End");
                    int numbersetting = int.Parse(Console.ReadLine());
                    if (numbersetting == 0 || numbersetting == 1 || numbersetting == 2)
                    {
                        if (numbersetting == 0)
                        {
                            DateTimeOffset.Now.ToUnixTimeSeconds();
                            DateTime foo = DateTime.UtcNow;
                            long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();

                            Problem[] problem = GenerateRandomProblems(numberlevel);
                            foreach (Problem test in problem)
                            {
                                Console.WriteLine("Question : " + test.Message);
                                Console.Write("Answer : ");
                                int Answer = int.Parse(Console.ReadLine());
                                if (Answer == test.Answer)
                                {
                                    correct_answer++;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong answer.");
                                }
                            }
                            many_answer = numberlevel;

                            if (numberlevel == 3)
                            {
                                numberlevel -= 3;
                            }
                            else if (numberlevel == 5)
                            {
                                numberlevel -= 4;
                            }
                            else if (numberlevel == 7)
                            {
                                numberlevel -= 5;
                            }

                            DateTime foo1 = DateTime.UtcNow;
                            long unixTime1 = ((DateTimeOffset)foo1).ToUnixTimeSeconds();


                            double spend_time;
                            spend_time = unixTime1 - unixTime;
                            Console.WriteLine("Time : " + spend_time);
                            Console.WriteLine("correct answer : " + correct_answer);
                            Console.WriteLine("numberlevel : " + numberlevel);

                            double sum_1 = (correct_answer / many_answer)
                                , sum_2 = (25 - Math.Pow(numberlevel, 2)) / (Math.Max(spend_time, 25 - Math.Pow(numberlevel, 2)))
                                , sum_3 = Math.Pow(((2 * numberlevel) + 1), 2);

                            score = sum_1 * sum_2 * sum_3;

                            score_sum += score;

                            correct_answer = 0;
                        }
                        else if (numbersetting == 1)
                        {
                            bool check_level = false;
                            while (check_level == false)
                            {
                                Console.WriteLine("Please input level. \n Number 0 = Easy \n Number 1 = Normal \n Number 2 = Hard");
                                numberlevel = int.Parse(Console.ReadLine());
                                if (numberlevel != 0 && numberlevel != 1 && numberlevel != 2)
                                {
                                    Console.WriteLine("Please input level tryagain. \n" + numberlevel);
                                }
                                else
                                    check_level = true;
                            }
                        }
                        else if (numbersetting == 2)
                        {
                            check_input = true;
                        }
                    }
                    else
                        Console.WriteLine("Please input 0 - 2. \n");
                }
            }
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }
        stat
    }
    }
}
