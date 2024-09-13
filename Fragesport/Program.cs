
using System.Drawing;
using System.Runtime.InteropServices;

int points = 0;
Console.WriteLine("Welcome to the dumbest quiz in the world");
Console.WriteLine("Press any button to start");
Console.ReadLine();
Console.Clear();
Console.WriteLine("How many sides does a circle have?");
Console.WriteLine("A) 2,738 B) 0 C) 1, but its a secret");

String answer1 = Console.ReadLine().ToLower();

while (answer1 != "a" && answer1 != "b" && answer1 != "c")
{
    Console.WriteLine("Chose between A, B Or C");
    answer1 = Console.ReadLine();

    if (answer1 != "a" && answer1 != "b" && answer1 != "c")
    {
        Console.WriteLine("You have to chose between the options A B Or C");
        answer1 = Console.ReadLine();
    }
}

if (answer1 == "b")
{
    points++;
    Console.WriteLine("Correct");
    Console.WriteLine("Press any button to continue");
}
else
{
    Console.WriteLine("Wrong Answer");
    Console.WriteLine("Press any button to continue");
}

Console.ReadLine();
Console.Clear();
Console.WriteLine("If you drop a yellow hat in the Red Sea, what does it become?");
Console.WriteLine("A) Wet B) Purple C) Confused");

string answer2 = Console.ReadLine().ToLower();

while (answer2 != "a" && answer2 != "b" && answer2 != "c")
{
    Console.WriteLine("Chose between A, B Or C");
    answer2 = Console.ReadLine();

    if (answer2 != "a" && answer2 != "b" && answer2 != "c")
    {
        Console.WriteLine("You have to chose between the options A B Or C");
        answer2 = Console.ReadLine();
    }
}


if (answer2 == "a")
{
    points++;
    Console.WriteLine("Correct");
    Console.WriteLine("Press any button to continue");
}
else
{
    Console.WriteLine("Wrong answer");
    Console.WriteLine("Press any button to continue");
}

Console.ReadLine();
Console.Clear();
Console.WriteLine("If a tomato is a fruit, does that mean ketchup is a smoothie?");
Console.WriteLine("A) Yes B) No C) Huh");

string answer3 = Console.ReadLine().ToLower();

while (answer3 != "a" && answer3 != "b" && answer3 != "c")
{
    Console.WriteLine("Chose between A, B Or C");
    answer3 = Console.ReadLine();

    if (answer3 != "a" && answer3 != "b" && answer3 != "c")
    {
        Console.WriteLine("You have to chose between the options A B Or C");
        answer3 = Console.ReadLine();
    }
}

if (answer3 == "a" || answer3 == "c")
{
    points++;
    Console.WriteLine("Correct answer, Good thing you got that one right");
    Console.WriteLine("Press any button to continue");
}
else
{
    Console.WriteLine("there was only one wrong answer and you still managed to get it wrong");
    Console.WriteLine("Press any button to continue");
}

Console.ReadLine();
Console.Clear();
Console.WriteLine("Which is heavier: 1 kilogram of feathers or 1 kilogram of bricks?");
Console.WriteLine("A) Feathers B) none of them C) Bricks ");

string answer4 = Console.ReadLine().ToLower();

while (answer4 != "a" && answer4 != "b" && answer4 != "c")
{
    Console.WriteLine("Chose between A, B Or C");
    answer4 = Console.ReadLine();

    if (answer4 != "a" && answer4 != "b" && answer4 != "c")
    {
        Console.WriteLine("You have to chose between the options A B Or C");
        answer4 = Console.ReadLine();
    }
}

if (answer4 == "b")
{
    points++;
    Console.WriteLine("Correct");
    Console.WriteLine("Press any button to continue");
}
else
{
    Console.WriteLine("Wrong answer");
    Console.WriteLine("Press any button to continue");
}

Console.ReadLine();
Console.Clear();
Console.WriteLine("Well done you completed a dumb quiz.");
Console.WriteLine("Press 'Enter' to see how well you did!");
Console.ReadLine();
Console.WriteLine($"Points:{points}/4");




Console.ReadLine();