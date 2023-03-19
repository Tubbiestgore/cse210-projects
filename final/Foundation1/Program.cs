using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "I DESTORY the One Ring";
        video1._author = "Frodo_Baggins";
        video1._length = 40920;
        video1._totalComments = 4;
        video1._comments = new List<Comments>();
        video1._comments.Add(new Comments(){_commentAuthor = "OrcCaptain299", _comment = "This is so stupid."});
        video1._comments.Add(new Comments(){_commentAuthor = "Gondor Guard", _comment = "YOOOOOOOOOOOOOOO, he ded."});
        video1._comments.Add(new Comments(){_commentAuthor = "LittleFatGuy", _comment = "Time to Party."});
        video1._comments.Add(new Comments(){_commentAuthor = "ElfLover40", _comment = "Good for you."});

        Video video2 = new Video();
        video2._title = "Lord Voldemort: GET DUNKED ON";
        video2._author = "HARRY P0TT3R";
        video2._length = 70740;
        video2._totalComments = 3;
        video2._comments = new List<Comments>();
        video2._comments.Add(new Comments(){_commentAuthor = "R0N_Weasel", _comment = "What a right git."});
        video2._comments.Add(new Comments(){_commentAuthor = "Her_names_mione", _comment = "Excellent Job Harry."});
        video2._comments.Add(new Comments(){_commentAuthor = "Drakeyo_Malfoy", _comment = "Filthy Mudblood."});

        Video video3 = new Video();
        video3._title = "Why Paul Atredies should be the rightful Emperor";
        video3._author = "Duke Leto";
        video3._length = 8220;
        video3._totalComments = 4;
        video3._comments = new List<Comments>();
        video3._comments.Add(new Comments(){_commentAuthor = "Shai_Hulud", _comment = "He is the Mahdi"});
        video3._comments.Add(new Comments(){_commentAuthor = "BeneJesserite", _comment = "The Kawizatz Hadrach. Agreed."});
        video3._comments.Add(new Comments(){_commentAuthor = "Idaho_is_the_best", _comment = "nah, he's too skinny, wouldn't ever work."});
        video3._comments.Add(new Comments(){_commentAuthor = "VoicesRC00L", _comment = "Guess we'll see what happens in the next movie, eh?"});

        Video video4 = new Video();
        video4._title = "ObiWan Kenobi -Hello There- Two Full Hours";
        video4._author = "MyNewEmpire422";
        video4._length = 7200;
        video4._totalComments = 3;
        video4._comments = new List<Comments>();
        video4._comments.Add(new Comments(){_commentAuthor = "ClonesRock", _comment = "Good Soldiers Follow Orders."});
        video4._comments.Add(new Comments(){_commentAuthor = "NormalDude", _comment = "Who thought this was a good idea? jeez."});
        video4._comments.Add(new Comments(){_commentAuthor = "Obiwan_is_dabest", _comment = "I will listen to this in its full length."});

        video1.Display();
        video2.Display();
        video3.Display();
        video4.Display();
        
    }
}