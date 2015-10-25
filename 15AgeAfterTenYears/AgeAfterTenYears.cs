using System;

class AgeAfterTenYears
{
    static void Main()
    {
        // using DateTime and its methods AddYears() for adding years to the result and Substract() -> for substract birth year and current year  
        Console.Write("Please enter your birthday in format (dd.mm.yyyy): ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        long result = DateTime.Today.Subtract(userBirthday).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(result).Year - 1);
        Console.WriteLine("After 10 years you will be {0} years old.", new DateTime(result).AddYears(10).Year - 1);
    }
}

