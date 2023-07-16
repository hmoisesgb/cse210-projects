using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //First video and comments
        Video v1 = new Video();
        v1._author = "David";
        v1._lenght = 50;
        v1._title = "Minecraft";

        Comment c1 = new Comment();
        c1._name = "Paul";
        c1._text = "What a nice video!";
        v1.AddComment(c1);

        Comment c2 = new Comment();
        c2._name = "Moses";
        c2._text = "Amazing, I want to learn more!";
        v1.AddComment(c2);

        Comment c3 = new Comment();
        c3._name = "Peter";
        c3._text = "Impressive. I really liked this video";
        v1.AddComment(c3);

        //Second video and comments
        Video v2 = new Video();
        v2._author = "Allan";
        v2._lenght = 200;
        v2._title = "How to cook salmon";

        Comment c4 = new Comment();
        c4._name = "John";
        c4._text = "The salmon looks amazing.";
        v2.AddComment(c4);

        Comment c5 = new Comment();
        c5._name = "jcStani";
        c5._text = "I love when they teach me how to cook.";
        v2.AddComment(c5);

        Comment c6 = new Comment();
        c6._name = "Pedro";
        c6._text = "Impressive. This looks delicious";
        v2.AddComment(c6);

        //Third video and comments

        Video v3 = new Video();
        v3._author = "Allan";
        v3._lenght = 350;
        v3._title = "Gangplank Gameplay - League of Legends";

        Comment c7 = new Comment();
        c7._name = "Caedrel";
        c7._text = "That Amumu is an inter";
        v3.AddComment(c7);

        Comment c8 = new Comment();
        c8._name = "johnGaming3";
        c8._text = "Gangplank is such an easy champ, disgusting.";
        v3.AddComment(c8);

        Comment c9 = new Comment();
        c9._name = "Jankos";
        c9._text = "This guy does not miss a barrel.";
        v3.AddComment(c9);

        //Adding each video to the list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        //Loop to iterate through each video and comment
        foreach (Video v in videos)
        {
            v.DisplayVideoInformation();
            v.DisplayComments();
            Console.WriteLine();
        }
    }
}