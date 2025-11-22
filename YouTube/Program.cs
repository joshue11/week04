using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video #1
        Video vid1 = new Video("How to Cook Tacos", "Josh Murillo", 480);
        vid1.AddComment(new Comment("Ana", "These tacos look amazing!"));
        vid1.AddComment(new Comment("Luis", "I tried this and it worked!"));
        vid1.AddComment(new Comment("Carlos", "Best recipe ever."));
        videos.Add(vid1);

        // Video #2
        Video vid2 = new Video("Minecraft Survival Tips", "GamerMike", 600);
        vid2.AddComment(new Comment("Noah", "I finally survived my first night!"));
        vid2.AddComment(new Comment("Julia", "More Minecraft content pls."));
        vid2.AddComment(new Comment("Sam", "This was super helpful, thanks!"));
        videos.Add(vid2);

        // Video #3
        Video vid3 = new Video("Beginner Guitar Chords", "MusicZone", 720);
        vid3.AddComment(new Comment("Ava", "Learning guitar now, thanks!"));
        vid3.AddComment(new Comment("John", "Great explanations."));
        vid3.AddComment(new Comment("Leo", "Can you do a tutorial on strumming?"));
        videos.Add(vid3);

        // Display all video data
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {v.GetLength()}");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($" - {c.GetName()}: {c.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
