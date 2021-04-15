using System;

namespace tweet_analyzer
{
    class Program
    {
        static void analyzer (string tweet)
        {
            string hashtags = "";
            int hashtagsCounter = 0;
            string users = "";
            int usersCounter = 0;

            for (int i = 0; i < tweet.Length; i++)
            {
                //if(tweet[i] == '#' && tweet[i+1] != ' ')
                //{
                //   while(tweet[i] != ' ')
                //    {
                //        hashtags += tweet[i + 1];
                //        i++;
                //    }
                //    hashtagsCounter += 1;

                //}

                //if (tweet[i] == '@' && tweet[i + 1] != ' ')
                //{
                //    usersCounter += 1;

                //}

                if(tweet[i] != ' ')
                {
                    hashtags += tweet[i];
                } else
                {
                    //Console.WriteLine(hashtags);
                    hashtags = "";
                }
                
            }
            //Console.WriteLine(hashtagsCounter);
            //Console.WriteLine(usersCounter);
        }
        static void Main(string[] args)
        {
            string tweet = "@Rno71: Yo anyone wanna battle @jasmine #AnimalCrossing #ACNH #NintendoSwitch";
            analyzer(tweet);
        }
    }
}
