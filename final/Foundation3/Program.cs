// Program.cs
using System;

class Program
{
    static void Main()
    {
        //I have a bug that doesn't clear out my console.
        //google search gave me this solution: https://github.com/dotnet/runtime/issues/28355
        //clears screen and the scrollback buffer
        Console.Clear();
        Console.WriteLine("\x1b[3J");

        //Creating the addresses for the events
        Address address1 = new Address("555 S Street", "Mapleton", "CA", "56214");
        Address address2 = new Address("1753 S 400 E", "Dodgerton", "UT", "84056");
        Address address3 = new Address("100 E Street", "Springville", "CA", "55261");

        //Creating the events with all values
        LectureEvent lecture1 = new LectureEvent("Lecture Event", "How to Win", "Details on how to win at life", "01.20.2024", "2 PM", address1, "Mr. Winner", 100);
        ReceptionEvent reception1 = new ReceptionEvent("Reception Event", "Bailey Reception", "Join us for the Bailey family reception.", "12.22.2023", "11 AM", address2, "rsvp@receptionevent.com");
        OutdoorsEvent outdoorEvent1 = new OutdoorsEvent("Outdoors Event", "Outdoor Expo", "Great outdoor expo for all your adventures.", "05.13.2024", "9 AM", address3, "Sunny weather");

        // Displaying event information
        Console.WriteLine("****    Inheritance with Event Planning    ****");
        Console.WriteLine();
        Console.WriteLine("    Lecture detail messages    ");
        Console.WriteLine();
        lecture1.Display();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();

        Console.WriteLine("    Reception detail messages    ");
        Console.WriteLine();
        reception1.Display();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();

        Console.WriteLine("    Outdoors Event detail messages    ");
        Console.WriteLine();
        outdoorEvent1.Display();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
}
