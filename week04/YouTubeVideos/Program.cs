using System;
using System.Collections.Generic;

namespace AbstractionYouTube
{
    // =========================================================================
    // COMMENT CLASS FOR TRACKING COMMENTS ON YOUTUBE VIDEOS
    // =========================================================================
    public class Comment
    {
        private string _commenterName;
        private string _commentText;

        public Comment(string name, string text)
        {
            _commenterName = name;
            _commentText = text;
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetCommentText()
        {
            return _commentText;
        }

        public string GetFormattedComment()
        {
            return $"- {_commenterName}: \"{_commentText}\"";
        }
    }

    // =========================================================================
    // VIDEO CLASS FOR TRACKING YOUTUBE VIDEOS AND COMMENTS
    // =========================================================================
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int lengthSeconds)
        {
            _title = title;
            _author = author;
            _lengthSeconds = lengthSeconds;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public void DisplayVideoInfo()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Title:    {_title}");
            Console.WriteLine($"Author:   {_author}");
            Console.WriteLine($"Length:   {_lengthSeconds} seconds");
            Console.WriteLine($"Comments ({GetCommentCount()}):");
            Console.WriteLine("--------------------------------------------------");

            foreach (Comment comment in _comments)
            {
                Console.WriteLine(comment.GetFormattedComment());
            }

            Console.WriteLine("==================================================\n");
        }
    }

    // =========================================================================
    // MAIN PROGRAM EXECUTION
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a list to store all videos
            List<Video> videoList = new List<Video>();

            // 2. Instantiate Video #1 and attach comments
            Video video1 = new Video("C# Abstraction Explained in 10 Minutes", "Tech Academy", 600);
            video1.AddComment(new Comment("Alice", "Great explanation! The examples were very clear."));
            video1.AddComment(new Comment("Bob", "This helped me pass my OOP design assignment. Thanks!"));
            video1.AddComment(new Comment("Charlie", "Could you make a video on Encapsulation next?"));
            videoList.Add(video1);

            // 3. Instantiate Video #2 and attach comments
            Video video2 = new Video("How to Build a Console App in VS Code", "Dev Tutorials", 450);
            video2.AddComment(new Comment("David", "Awesome tutorial, simple and straight to the point."));
            video2.AddComment(new Comment("Eve", "I was getting git merge errors before watching this!"));
            video2.AddComment(new Comment("Frank", "Very helpful environment setup walkthrough."));
            videoList.Add(video2);

            // 4. Instantiate Video #3 and attach comments
            Video video3 = new Video("Top 5 C# Best Practices for Beginners", "Code With Sarah", 720);
            video3.AddComment(new Comment("Grace", "Keeping member variables private changed everything for me."));
            video3.AddComment(new Comment("Heidi", "Clean code tips are always appreciated!"));
            video3.AddComment(new Comment("Ivan", "Subscribed! Looking forward to part 2."));
            videoList.Add(video3);

            // 5. Iterate through the list of videos and display details
            Console.WriteLine("YOUTUBE VIDEO TRACKER REPORT\n");
            foreach (Video video in videoList)
            {
                video.DisplayVideoInfo();
            }
        }
    }
}