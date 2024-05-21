Random random = new Random();

int amountOfCourses = 5;

string[] viewStudentScore = { "0", "0", "0", "0" };
string[] editStudentGrade = { "F", "F", "F", "F" };
string[] viewStudentNames = { "Jane", "John", "Jill", "Jack" };

decimal[] editStudentScore = { 0, 0, 0, 0 };

for (int i = 0; i < amountOfCourses - 1; i++)
{
    int score = 0;
    string grade = "F";

    for (int j = 0; j < amountOfCourses - j; j++)
    {
        score += random.Next(59, 101);
    }

    int total = (score + 100) / amountOfCourses;

    if (total >= 90)
    {
        grade = "A";

        if (total >= 97)
        {
            grade += "+";
        }
        else if (total <= 92)
        {
            grade += "-";
        }
    }
    else if (total >= 80 && total <= 89)
    {
        grade = "B";

        if (total >= 87)
        {
            grade += "+";
        }
        else if (total <= 82)
        {
            grade += "-";
        }
    }
    else if (total >= 70 && total <= 79)
    {
        grade = "C";

        if (total >= 77)
        {
            grade += "+";
        }
        else if (total <= 72)
        {
            grade += "-";
        }
    }
    else if (total >= 60 && total <= 69)
    {
        grade = "D";

        if (total >= 67)
        {
            grade += "+";
        }
        else if (total <= 62)
        {
            grade += "-";
        }
    }
    editStudentGrade[i] = grade;
    editStudentScore[i] = total;
    viewStudentScore[i] = $"{total}";
}

Console.WriteLine("\nStudent\t\tGrade\n");

int turn = 0;
foreach (string name in viewStudentNames)
{
    Console.WriteLine($"{name}:\t\t{viewStudentScore[turn]}\t{editStudentGrade[turn]}");
    turn++;
}


