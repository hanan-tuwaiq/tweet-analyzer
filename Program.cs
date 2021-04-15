using System;

namespace tweet_analyzer
{
    class Program
    {
        static void analyzer(string tweet)
        {
            string hashtags = "";
            int hashtagsCounter = 0;
            string users = "";
            int usersCounter = 0;

            int i = 0;
            while (i < tweet.Length)
            {
                if (tweet[i] == '#' && tweet[i + 1] != ' ')
                {
                    hashtagsCounter += 1;
                }

                if (tweet[i] == '@' && tweet[i + 1] != ' ')
                {
                    usersCounter += 1;
                    {
                        //
                        i++;
                    }

                    Console.WriteLine(hashtagsCounter);
                    Console.WriteLine(usersCounter);
                }
            }
        }
                static void Main(string[] args)
                {
                    string tweet = "@Rno71: Yo anyone wanna battle @jasmine #AnimalCrossing #ACNH #NintendoSwitch";
                    analyzer(tweet);
                }
            }
        }
    
