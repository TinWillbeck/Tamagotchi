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
        hunger -= 40;
        Console.WriteLine($"Hunger = {hunger}");
    }
    public void GetAlive()
    {
        if (isAlive == true){
            Console.WriteLine("Den lever");
        }
        else{
            Console.WriteLine("Den död");
        }
    }
    private void ReduceBoredom()
    {
        boredom -= 40;
    }
    public void Tick()
    {
        boredom += 5;
        hunger += 8;
        if (boredom == 100 || hunger == 100)
        {
            isAlive = false;
        }
    }
    public void TeachWord(string word)
    {
       
    }
}
