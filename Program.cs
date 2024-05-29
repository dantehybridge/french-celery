Random random = new Random();

int amountOfCodes = 4;
int lengthOfCodes = 6;

string[] codes = new string[4];
string[] letters = { "A", "B", "C", "D", "E", "F" };

for (int i = 0; i < amountOfCodes; i++)
{
    string[] digits = new string[lengthOfCodes]; // The code is set with each iteration
    int amountOfLettersInCode = random.Next(1, lengthOfCodes); // Each code must have at least ONE letter

    do
    {
        int index = random.Next(lengthOfCodes);
        if (digits[index] == null)
        {
            digits[index] = letters[random.Next(letters.Length)];
            amountOfLettersInCode--;
        }
    } while (amountOfLettersInCode != 0);

    for (int j = 0; j < lengthOfCodes; j++)
    {
        if (digits[j] == null)
        {
            digits[j] = random.Next(10).ToString();
        }
    }

    string code = string.Join("", digits);
    codes[i] = code;
}

// Randomly generate the scores per course, then calculate its average. Also, assign the grade letter corresponding to the average of the scores per student.
int amountOfCourses = 5;

string[] viewStudentCodes = { "0", "0", "0", "0" };
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

Console.WriteLine("\nID\tStudent\t\tGrade\n");

int turn = 0;
foreach (string name in viewStudentNames)
{
    Console.WriteLine($"{codes[turn]}\t{name}\t\t{viewStudentScore[turn]}\t{editStudentGrade[turn]}");
    turn++;
}


