using System;
using System.Collections.Generic;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> followers = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] command = input
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                var userName = command[1];

                if (action == "New follower")
                {
                    Add(followers, userName);
                }
                else if (action == "Like")
                {
                    int count = int.Parse(command[2]);
                    Add(followers, userName);
                    followers[userName][0] += count;
                }
                else if (action == "Comment")
                {
                    Add(followers, userName);
                    followers[userName][1]++;
                }
                else if (action == "Blocked")
                {
                    if (followers.ContainsKey(userName))
                    {
                        followers.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} doesn't exist.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach (var item in followers)
            {
                Console.WriteLine($"{item.Key}: {item.Value[0] + item.Value[1]}");
            }
        }

        static void Add(Dictionary<string, List<int>> followers, string userName)
        {
            if (!followers.ContainsKey(userName))
            {
                followers.Add(userName, new List<int>() { 0, 0 });
            }
        }
    }
}
