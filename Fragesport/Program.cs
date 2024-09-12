
using System.Drawing;

int points = 0; 
Console.WriteLine("Welcome to the dumbest quiz in the world");

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
     }
}

if (answer1 == "b")
{
    points++; 
    Console.WriteLine("Correct");
}
else 
{
    Console.WriteLine("Wrong Answer");
}


Console.ReadLine();
Console.Clear();
Console.WriteLine("If you drop a yellow hat in the Red Sea, what does it become?");
Console.WriteLine("A) Wet B) Purple C) Confused");

string answer2 = Console.ReadLine().ToLower();

if (answer2 == "a")
{
    points++;
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine("Wrong answer");
}

Console.ReadLine();
Console.Clear();
Console.WriteLine("If a tomato is a fruit, does that mean ketchup is a smoothie?");
Console.WriteLine("A) Yes B) No C) ...................");

string answer3 = Console.ReadLine().ToLower();

if (answer3 == "a" || answer3 == "c") 
{
    points++;
    Console.WriteLine("Correct answer, Good thing you got that one right");
}
else
{
    Console.WriteLine("there was only one wrong answer and you still managed to get it wrong");
}

Console.ReadLine();