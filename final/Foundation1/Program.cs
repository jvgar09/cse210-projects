using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos and comments
        Video video1 = new Video("Title1", "Author1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "This looks really delicious!");

        Video video2 = new Video("Title2", "Author2", 180);
        video2.AddComment("User3", "Yummy!");
        video2.AddComment("User4", "Enjoyed watching.");

        Video video3 = new Video("Title3", "Author3", 150);
        video3.AddComment("User5", "The food looks amazing!");
        video3.AddComment("User6", "Well done.");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display info for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}

