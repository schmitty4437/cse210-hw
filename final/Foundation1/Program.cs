using System;

class Program
{
    static void Main(string[] args)
    {
        //Instance of Video class
        Video listVideos = new Video();

        //Video 1 information
        listVideos.AddVideo
        (
            "The Prodigal and the Road That Leads Home | Dieter F. Uchtdorf | October 2023 General Conference",
            "General Conference",
            "00:14:31",
            "@dannyrocket77", "16 months ago I came back! I was welcomed home with love, tattoos and all. It’s been worth it. I’m on the right team! Onward and steadfast!",
            "@deegold6233", "❤❤❤What a beautiful talk by our beloved Apostle Uchtdorf! The Father does forgive the lost sheep, I was one 🥹",
            "@madizen6312", "I love this talk! Christ can carry us through anything! I left and came back. I had my temple blessings restored yesterday ❤"
        );

        //Video 2 information
        listVideos.AddVideo
        (
            "Cute Baby Animals Videos Compilation | Funny and Cute Moment of the Animals #4 - Cutest Animals 2023",
            "Cutest Animals",
            "00:15:45",
            "@DailyDoseFarsi", "These are so cute😍😍😍",
            "@OplozannLima", "Funny and cute cats adorable 😂😂",
            "@ming09888", "Sooo cute 🤩"
        );

        //Video 3 information
        listVideos.AddVideo
        (
            "Taylor Swift - Anti-Hero (Official Music Video)",
            "Taylor Swift",
            "00:5:09",
            "@MadilynBailey", "I CANNOT WAIT FOR THIS!!! you do no wrong... <3",
            "@leonardlynn2425", "I even get more emotional when I watch this MV or listen to Anti-Hero when I am down. It is never exhausting to stand for you,Taylor.❤",
            "@PPPerdona", "I’m not a huge fan of Taylor’s music but this one is just amazing. Very very nice and sweet song"
        );

        //Display video information
        listVideos.Display();
    }
}