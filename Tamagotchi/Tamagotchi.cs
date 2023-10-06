public class Tamagotchi
{
    int hunger = 0;
    int boredom = 0;
    List<string> words = new() {"Tjockis"};
    bool isAlive = true;
    Random generator = new Random();
    public string name;


    public void PrintStats()
    {
        Console.WriteLine($"Hunger = {hunger} || Boredom = {boredom} || Vocabulary: {words.Count} words");
    }
    public void Feed()
    {
        hunger -= 10;
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        boredom -= 4;
    }
    public void Tick()
    {
        boredom += 3;
        hunger += 8;
        if (boredom >= 100 || hunger >= 100)
        {
            isAlive = false;
        }
    }
    public void TeachWord(string word)
    {
        words.Add (word);
        if (boredom > 3)
        {
            ReduceBoredom();

        }
        return;
    }
    public void Hi()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($"{name} säger: {words[wordNum]}");
        if (boredom > 3)
        {
            ReduceBoredom();
        }
    }
}
