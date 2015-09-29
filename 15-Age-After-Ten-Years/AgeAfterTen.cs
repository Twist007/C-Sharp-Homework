using System;

class AgeAfterTen
{
    static void Main()
    {

        Console.WriteLine("Write your birthday (dd.mm.yyyy):");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;

        int currAge = today.Year - birthDay.Year;
        if (today.Date.Month < birthDay.Date.Month)
            Console.WriteLine("Now: " + (currAge - 1));
        else
            Console.WriteLine("Now: " + currAge);

        Console.WriteLine("After 10 years: " + (currAge + 10));
        Console.WriteLine();

    }
}

