//Task 5
class Program
{
    static void Main()
    {
        //DateTime variable for birthdate
        DateTime birthDate = new DateTime(2005, 06, 03); 

        //DateTime variable for the current date and time
        DateTime currentDate = DateTime.Now;

        //Calculate age using TimeSpan
        TimeSpan ageSpan = currentDate - birthDate;

        //Convert age from days to years (approximate)
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        //Print birthdate, current date, and age
        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
        Console.WriteLine("Age: " + ageInYears + " years");

        //Add 10 days to birthdate 
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + newDate.ToShortDateString());
    }
}
