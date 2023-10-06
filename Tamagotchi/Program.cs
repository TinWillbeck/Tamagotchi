
// Question q1 = new();
// q1.text = "5+4";
// q1.answers new List<string>() {"14", "9", "7", "2"};
// q1.correct = 2;

// Question q2 = new(){
//     text = "5+2",
//     answers = new List<string>() {"7", "3","2","1"},
//     correct = 1,
// }


// Question q1 = new("5+6", new List<string>(){"11","2","3","19"}, 1);

Tamagotchi t1 = new();

string input;

Console.WriteLine("Vad vill du döpa din Tamagotchi?");
t1.name = Console.ReadLine();

while (t1.GetAlive() == true)
{
    t1.PrintStats();

    Console.WriteLine($"Vill du lära {t1.name} ett nytt ord [1], hälsa på den[2], mata den[3], eller inte göra något[4?");
    input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine($"Vilket ord vill du lära {t1.name}?");
        t1.TeachWord(Console.ReadLine());
        Console.WriteLine($"{t1.name} kan nu ett nytt ord!");
        t1.Tick();
        Console.ReadLine();

    }
    else if (input == "2")
    {
        t1.Hi(); 
        t1.Tick();
        Console.ReadLine();
 
    }
    else if (input == "3")
    {
        Console.WriteLine($"Du matade {t1.name}");
        t1.Feed();
        t1.Tick();
        Console.ReadLine();

    }
    else if (input == "4")
    {
        t1.Tick();
    }
    else
    {
        Console.WriteLine("Fel input");
        Console.ReadLine();

    }
    Console.Clear();
}

Console.WriteLine($"{t1.name} dog");
Console.ReadLine();