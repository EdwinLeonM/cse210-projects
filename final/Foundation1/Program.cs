using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Test Video 1", "Harry", 120);
        Video video2 = new Video("Test Video 2", "Charlie", 150);
        Video video3 = new Video("Test Video 3", "James", 200);

        video1.AddComment(new Comment("User1", "Good video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "I liked it a lot."));

        video2.AddComment(new Comment("User4", "Interesting content."));
        video2.AddComment(new Comment("User5", "I learned something new today."));
        video2.AddComment(new Comment("User6", "It wasn't bad."));

        video3.AddComment(new Comment("User7", "Excellent explanation."));
        video3.AddComment(new Comment("User8", "Very clear and concise."));
        video3.AddComment(new Comment("User9", "Great job!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine(new string('.', 50));
        }
    }
}