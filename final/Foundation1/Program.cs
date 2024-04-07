using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos with comments
        for (int i = 1; i <= 3; i++)
        {
            Video video = new Video($"Video {i}", $"Author {i}", 120 * i); // Duration increases with each video
            for (int j = 1; j <= 3; j++)
            {
                video.AddComment($"User{j}", $"Comment {j} for video {i}");
            }
            videos.Add(video);
        }

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("-------------------------------------------------");

            // Display comments
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}