using static System.Console;

string[] listOfStudents = {"Alex", "Nora", "Jane", "Kim"};

WriteLine("");

WriteLine(listOfStudents); // Does't work as I expected

WriteLine("");

foreach(string student in listOfStudents)
{
    Write($"{student}; ");
}

WriteLine("");
WriteLine("");


// Invert an array
int studentsLength  = listOfStudents.Length;
int middle          = (studentsLength - 1) / 2;

for (int i = 0; i <= middle; i++)
{
    string tmp                              = listOfStudents[i];
    listOfStudents[i]                       = listOfStudents[studentsLength - 1 - i];
    listOfStudents[studentsLength - 1 - i]  = tmp;
}

foreach(string student in listOfStudents)
{
    Write($"{student}; ");
}

WriteLine("");
WriteLine("");


// Sort an array
int[] numbers = [1, 4, 7, 89, 102, 11, -2, -66, 69, -80, 0];

for (int i = 0; i < numbers.Length; i++)
{
    int tmp;
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            tmp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = tmp;
        }
    }

    Write($"{numbers[i]} ");
}

WriteLine("");
WriteLine("");


// Test "input" and "output" parameters
void Sum(out int result, params int[] numbers) // "params" are always LAST!
{
    result = 0;
    foreach(int number in numbers)
    {
        result += number;
    }
}

Sum(out int output, numbers);
WriteLine(output);

WriteLine("");


// Test "ref"
void Addition(int number)
{
    number++;
    WriteLine($"Variable during: {number}");
}

void SpecialAddition(ref int number)
{
    number++;
    WriteLine($"Variable during: {number}");
}

void SuperSpecialAddition(in int number)
{
    number++;
    WriteLine($"Variable during: {number}");
}

int x = 55;

WriteLine($"Variable before: {x}");
Addition(x);
WriteLine($"Variable after: {x}");

WriteLine("");

// WriteLine($"Variable before: {x}");
// SpecialAddition(ref x);
// WriteLine($"Variable after: {x}");


// Get elements