using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // giving color to the display info. 
        Console.ForegroundColor = ConsoleColor.Green; 

        // Create videos and comments
        Video video1 = new Video("Title1", "Author1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "This looks really delicious!");

        Video video2 = new Video("Title2", "Author2", 140);
        video2.AddComment("User3", "Yummy!");
        video2.AddComment("User4", "Enjoyed watching.");

        Video video3 = new Video("Title3", "Author3", 160);
        video3.AddComment("User5", "The food looks amazing!");
        video3.AddComment("User6", "Well done.");

        Video video4 = new Video("Title4", "Author4", 180);
        video4.AddComment("User7", "Looking at this food, I am getting hungry!");
        video4.AddComment("User8", "Very nice video.");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display info for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}"); // the number of comments
            
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments()) // display the word Comments:
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}"); // display the user name / comment 
            }

            Console.WriteLine();
        }
    }
}
