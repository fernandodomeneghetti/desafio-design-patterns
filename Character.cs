namespace abstractfactoryproblem;

// Classe base para personagem
class Character
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Weapon { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}, Weapon: {Weapon}");
    }
}