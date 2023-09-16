using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a grade percentage: ");
        string gradeNumber = Console.ReadLine();

        int gradePercentage = int.Parse(gradeNumber);

        string letterGrade = "";

        //if statements to determine letter grade
        if (gradePercentage >= 90)
        {
            //Console.WriteLine("The letter grade is an A");
            letterGrade = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            //Console.WriteLine("The letter grade is a B");
            letterGrade = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            //Console.WriteLine("The letter grade is a C");
            letterGrade = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            //Console.WriteLine("The letter grade is a D");
            letterGrade = "D";
        }
        else
        {
            //Console.WriteLine("The letter grade is an F");
            letterGrade = "F";
        }

        string passFail = "";

        //If statement to determine if they passed
        if (gradePercentage >= 70)
        {
            passFail = "Congrats! You passed!";
        }
        else{
            passFail = "Sorry. You did not pass. Do not give up!";
        }

        Console.WriteLine($"Your grade is a {letterGrade}. {passFail}");
    }
}