using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditPost
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RrditPost> allPosts = new List<RrditPost>();

            Console.WriteLine("Please enter your Username and post your message.");

            var input = Console.ReadLine();

            while (input != "done") {
                
                RrditPost user = new RrditPost(input);

                Console.WriteLine("Write your post: \n");
                input = Console.ReadLine();

                user.Post = input;

                allPosts.Add(user);

                        foreach (var item in allPosts)
                        {
                            PostContainer(item);
                        }

                Console.WriteLine("If you are finished, type \"done\"");
                input = Console.ReadLine();
            }
        }

        public static void PostContainer(RrditPost message) {

            Console.WriteLine("{0}-------------------------------------------------------------------------------+", message.GetUserName());
            Console.WriteLine("{0}", message.Post);
            Console.WriteLine("\n");
            Console.WriteLine("+ Votes:{0}--------------------------------------------------------------------------------+", message.GetVotes());

        }
    }
}
