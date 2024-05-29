
# Create and run simple C# console applications (Get started with C#, Part 2)

In this challenge project, you'll use Visual Studio Code to develop a C# application. The application will use arrays, `foreach` statements, and `if` statements to implement a list of design parameters. You'll begin by creating the array variables that contain your application data. To complete the project, you'll develop `foreach` and `if` statements that implement the application design goals.

## Guided project - Develop foreach and if-elseif-else structures to process array data in C#

### Introduction

Creating a code branch and iterating through a code block are essential capabilities for a developer. In C#, the `if` statement can be used to evaluate an expression and branch the execution path. The code block of a `foreach` statement can be used to iterate through each element of an array. Powerful and extensible applications can be created by combining the ability to iterate through an array with the ability to branch the execution path.

Suppose you're a teacher's assistant at a school. You've been working with a teacher to create an application that automates the grading process. Your C# programming skills have increased since you completed the initial version of your application. The teacher has asked you to update your application. The updates focus on using arrays, `foreach` statements, and `if` statements. The teacher also wants you to include extra credit assignments in your calculations of the final grades.

In this module, you'll be guided through the process of updating your Student Grading application. You'll use arrays to store student names and the scores of graded assignments, and you'll use `foreach` statements to iterate through array values. Each student's final grade will be calculated inside a `foreach` code block. You'll use an `if` statement to assign a final letter grade. Your completed application will output student grades using the teacher's score report specification.

By the end of this module, you'll have experience developing applications that use arrays, `foreach` statements, and `if` statements. You'll also be comfortable creating applications that efficiently process data using nested iteration and selection statements.

> This is a guided project module where you’ll complete an end-to-end project by following step-by-step instructions.

#### Learning objectives

In this module, you'll practice how to:
- Use Visual Studio Code to develop a C# console application that uses `foreach` loops to access array data.
- Use `if` statements to evaluate expressions and create code branches.
#### Prerequisites

- Experience using Visual Studio Code to develop, build, and run C# console applications that include console I/O and access the methods of .NET classes.
- Experience using `if` statements in C# to evaluate an expression and branch code accordingly.
- Experience using a `foreach` loop to access elements of array variables.

### Prepare

In this guided project, you'll use Visual Studio Code to develop a C# application. The application will use arrays, `foreach` statements, and `if` statements to implement a list of design parameters. You'll begin by creating the array variables that contain your application data. To complete the project, you'll develop `foreach` and `if` statements that implement the application design goals.

> This module includes coding activities that require Visual Studio Code. You'll need access to a development environment that has Visual Studio Code installed and configured for C# application development.

#### Project overview

You're developing a Student Grading application that automates the calculation of grades for each student in a class. The parameters for your application are:

- Create a C# console application.
- Start with four students. Each student has five exam scores.
- Each exam score is an integer value, 0-100, where 100 represents 100% correct.
- A student's overall exam score is the average of their five exam scores.
- Criteria for extra credit assignments:
    - Include extra credit assignment scores in the student's scores array.
    - Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
    - Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
- Your application needs to automatically assign letter grades based on the calculated final score for each student.
- Your application needs to output/display each student’s name and formatted grade.
- Your application needs to support adding other students and scores with minimal impact to the code.

You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

- The code declares variables used to define student names and individual exam scores for each student.
- The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
- The code includes a hard coded letter grade that the developer must apply manually.
- The code includes Console.WriteLine() statements to display the student grading report.

Your goal is to update the existing code to include the following features:

- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate through the assignment scores array and sum the values.
- Use an updated algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - Your code must detect extra credit assignments based on the number of elements in the student's scores array.
    - Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

The following list shows the letter grade that corresponds to numeric scores:

```
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
```

The update application needs to produce a formatted student grading report that appears as follows:

```
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
```

## Challenge project - Develop foreach and if-elseif-else structures to process array data in C#

### Introduction

End users often ask developers to add new features to an application. User requests indicate that your application is being used, and more importantly, that the customer plans to continue using your application. The customer just wants some features updated. The ability to update an existing application based on user requests is very important. A successful update will preserve the integrity of the original application while providing the user with the improved experience that they requested.

Suppose you're a teacher's assistant at a school and that you developed an application to automate the grading process. The application uses arrays to store student names and graded assignments. The application also implements a combination of iteration and selection statements to calculate and report each student's final grade. Your application even differentiates between exam assignments and extra credit assignments when calculating student grades. Although the application does everything that the teacher asked for, you've received a request for new features. The teacher has asked you to update the grading report to show exam and extra credit assignment scores separately from the final numeric score and letter grade.

This module challenges you to add new capabilities to your Student Grading application.

In short, you need to use the teacher's updated grading report specification to:

- update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
- update the code that writes the grading report to the console.

By the end of this module, you'll have an updated version of the Student Grading application that's able to calculate and report student grades in accordance with the teacher's updated requirements.

> This is a challenge project module where you’ll complete an end-to-end project from a specification. This module is intended to be a test of your skills; there’s little guidance and no step-by-step instructions.

#### Learning Objectives

In this module, you'll demonstrate your ability to:

- Use Visual Studio Code to revise a C# console application based on an updated feature specification.
- Update the variables and `if` statements in a C# console application to create the code branches and calculations required to satisfy an updated feature specification.

#### Prerequisites

- Experience using Visual Studio Code to develop, build, and run C# console applications that include console I/O and access the methods of .NET classes.
- Experience using `if` statements in C# application to evaluate expressions and branch code accordingly.
- Experience using a `foreach` loop to access elements of array variables.

### Prepare

In this guided project, you'll use Visual Studio Code to develop portions of a C# console application. You'll begin by writing the code that performs various numeric calculations. All calculations must be completed within the existing iteration and selection structures. This Prepare unit provides you with the overall goals of the project and the requirements for your application. The Setup section describes how to set up your development environment, including a "Starter" code project.

> This module includes coding activities that require Visual Studio Code. You'll need access to a development environment that has Visual Studio Code installed and configured for C# application development.

#### Project specification

The Starter code project for this module is a C# console application that implements the following code features:

- Uses arrays to store student names and assignment scores.
- Uses a `foreach` statement to iterate through the student names as an outer program loop.
- Uses an `if` statement within the outer loop to identify the current student's name and access that student's assignment scores.
- Uses a `foreach` statement within the outer loop to iterate through the assignment scores array and sum the values.
- Uses an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrates extra credit scores when calculating the student's final score and letter grade as follows:
    - Detects extra credit assignments based on the number of elements in the student's scores array.
    - Applies a 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

Your goal in this challenge is to implement the coding updates required to produce the teacher's requested score report.

The current score report lists the student's name followed by the calculated overall grade and letter grade. Here is the existing report format:

```
Student         Grade   Letter Grade

Sophia          95.6    A
Andrew          91.6    A-
Emma            89.2    B+
Logan           93      A
```

In addition to the student's final numeric score and letter grade, the teacher wants the updated report to include the exam score and the impact that extra credit work has on the student's final grade. The format of the updated score report should appear as follows:

```
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```