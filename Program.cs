// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Please enter your grade (0-100)");

string? gradeInput = Console.ReadLine();

int numericalGrade;

try
{
    numericalGrade = Convert.ToInt32(gradeInput);
}
catch (FormatException)
{
    Console.WriteLine("PLease enter a valid number between 0 and 100");
    return;
}
catch (OverflowException)
{
    Console.WriteLine("The number you entered is too large or too small. Please enter a number between 0 and 100.");
    return;
}

if (numericalGrade < 0 ||  numericalGrade > 100)
{
    Console.WriteLine("Grade must be between 0 and 100. Try again");
    return;
}

string letterGrade;

if (numericalGrade >= 90)
{
    letterGrade = "A";
}
else if (numericalGrade >= 80)
{
    letterGrade = "B";
}
else if ((numericalGrade >= 70))
{
    letterGrade = "C";
}
else if ((numericalGrade >= 60))
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}

Console.WriteLine($"Your letter grade is: {letterGrade}");