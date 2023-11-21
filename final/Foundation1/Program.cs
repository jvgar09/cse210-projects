using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Title 1", "Author 1", 100);
        Video video2 = new Video("Title 2", "Author 2", 100);
        Video video3 = new Video("Title 3", "Author 3", 100);

        // Add comments to videos
        video1.AddComment("User1", "Awsome video!");
        video1.AddComment("User2", "Peole will learn a lot from this video.");

        video2.AddComment("User3", "Very interstaing stuff.");
        video2.AddComment("User4", "I love the way he cuts carrots into butterflies,etc. He truly has skills..");

        video3.AddComment("User5", "Nice presentation.");
        video3.AddComment("User6", "This Chef is truly a Grand Master!");

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display comments for the video
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Commenter}: {comment.Text}");
            }

            Console.WriteLine(); // Add a blank line between videos for better readability
        }
    }
}