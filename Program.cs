Random random = new Random();

int maxLengthOfCode = 6;

string[] ids = new string[4];
string[] sAccess = { "", "", "", "", "", "" };
string[] letters = { "A", "B", "C", "D", "E", "F" };

/* int amountOfLettersInAccess = 1;
while (amountOfLettersInAccess % 2 != 0) {
    amountOfLettersInAccess = random.Next(maxLengthOfCode);
}
Console.WriteLine($"Letters In Access: {amountOfLettersInAccess}");

int amountOfNumbersInAccess = maxLengthOfCode - amountOfLettersInAccess;
Console.WriteLine($"Numbers In Access: {amountOfNumbersInAccess}"); */

for (int i = 0; i < 4; i++) {
    for (int j = 0; j < maxLengthOfCode; j++) {        
        int digit = random.Next(10); // WHAT we are saving "digit" with.
        //int indexLetter = random.Next(maxLengthOfCode); 
        int indexAccess = random.Next(maxLengthOfCode); // WHERE we are saving "digit".

        if(sAccess[indexAccess] == "") {
            sAccess[indexAccess] = $"{digit}";
        } else {
            j--;
        }
    }

    string id = string.Join("", sAccess);
    ids[i] = id;

    for (int k = 0; k < maxLengthOfCode; k++) {
        sAccess[k] = "";
    }
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
    Console.WriteLine($"{ids[turn]}\t{name}\t\t{viewStudentScore[turn]}\t{editStudentGrade[turn]}");
    turn++;
}


