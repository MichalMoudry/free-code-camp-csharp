namespace ConsoleProject.FinalGpa;

internal static class FinalGpa
{
    public static void RunAssignment()
    {
        var studentName = "Sophia Johnson";

        var course1Name = "English 101";
        var course2Name = "Algebra 101";
        var course3Name = "Biology 101";
        var course4Name = "Computer Science I";
        var course5Name = "Psychology 101";

        var course1Credit = 3;
        var course2Credit = 3;
        var course3Credit = 4;
        var course4Credit = 4;
        var course5Credit = 3;

        var gradeA = 4;
        var gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        var totalCreditHours =
            course1Credit
            + course2Credit
            + course3Credit
            + course4Credit
            + course5Credit;

        var totalGradePoints =
            course1Credit * course1Grade
            + course2Credit * course2Grade
            + course3Credit * course3Grade
            + course4Credit * course4Grade
            + course5Credit * course5Grade;

        var gradePointAvg = (decimal) totalGradePoints / totalCreditHours;
        var leadingDigit = (int)gradePointAvg;
        var firstDigit = (int) (gradePointAvg * 10) % 10;
        var secondDigit = (int) (gradePointAvg * 100) % 10;

        Console.WriteLine($"Student name: {studentName}\n");
        Console.WriteLine($"Course\t\t\tGrade\tCredit");
        Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}");
        Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
    }
}