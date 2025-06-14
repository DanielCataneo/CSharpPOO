using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_2___demo_StringB.Entities;

namespace Exercício_2___demo_StringB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("How, that's awesome");
            Post post1 = new Post(
                DateTime.Parse("13/08/2018 13:05:58"),
                "Travelling to New Zealand ",
                "I'm going to visit this wonderful country",
                12
                );
        
        
                post1.AddComment(comment1);
                post1.AddComment(comment2);

            Comment comment3 = new Comment("Good Night");
            Comment comment4 = new Comment("May the force be with you");
            Post post2 = new Post(
                DateTime.Parse("28/07/2018 22:53:48"),
                "Good Night for you guys",
                "See ya tomorrow",
                5
                );
        
                post2.AddComment(comment3);
                post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);

            Console.ReadKey();
        }
    }
}
