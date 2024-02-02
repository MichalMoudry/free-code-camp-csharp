namespace ConsoleProject.ArraysForeach;

internal static class ArraysForeach
{
    public static void RunAssignment()
    {
        var currentAssignments = 5;

        int[] sophiaScores = [90, 86, 87, 98, 100];
        int[] andrewScores = [92, 89, 81, 96, 90];
        int[] emmaScores = [90, 85, 87, 98, 68];
        int[] loganScores = [90, 95, 87, 88, 96];

        // Student names
        string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

        int[] studentScores = new int[10];

        // Write the Report Header to the console
        Console.WriteLine("Student\t\tGrade\n");

        foreach (var name in studentNames)
        {
            var currentStudent = name;

            if (name == "Sophia")
                studentScores = sophiaScores;

            else if (name == "Andrew")
                studentScores = andrewScores;

            else if (name == "Emma")
                studentScores = emmaScores;

            else if (name == "Logan")
                studentScores = loganScores;

            // initialize/reset the sum of scored assignments
            var sumAssignmentScores = 0;

            // initialize/reset the calculated average of exam + extra credit scores
            var currentStudentGrade = 0.0m;

            foreach (var score in studentScores)
            {
                // add the exam score to the sum
                sumAssignmentScores += score;
            }

            currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

            Console.WriteLine($"{name}\t\t{currentStudentGrade}\t?");
        }
    }
}