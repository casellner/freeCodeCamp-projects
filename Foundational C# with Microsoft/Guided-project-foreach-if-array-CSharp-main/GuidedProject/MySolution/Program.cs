using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaGrades = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewGrades = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaGrades = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganGrades = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyGrades = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisGrades = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericGrades = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorGrades = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentGrades = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentGrades = sophiaGrades;
    }
    else if (currentStudent == "Andrew")
    {
        studentGrades = andrewGrades;
    }
    else if (currentStudent == "Emma")
    {
        studentGrades = emmaGrades;
    }
    else if (currentStudent == "Logan")
    {
        studentGrades = loganGrades;
    }
    else if (currentStudent == "Becky")
    {
        studentGrades = beckyGrades;
    }
    else if (currentStudent == "Chris")
    {
        studentGrades = chrisGrades;
    }
    else if (currentStudent == "Eric")
    {
        studentGrades = ericGrades;
    }
    else if (currentStudent == "Gregor")
    {
        studentGrades = gregorGrades;
    }
    else
    {
        continue;
    }
    
    int sumAssignmentGrades = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int grade in studentGrades)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentGrades += grade;
        }
        else
        {
            sumAssignmentGrades += grade / 10;
        }
    }
        
    currentStudentGrade = (decimal)(sumAssignmentGrades) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
