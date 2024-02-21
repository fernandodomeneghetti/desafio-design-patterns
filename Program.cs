namespace abstractfactoryproblem;

class Program
{
    static void Main(string[] args)
    {
        CharacterCreator creator = new CharacterCreator();

        // Cria um herói
        Character hero = creator.CreateCharacter("hero");
        hero.DisplayInfo();

        // Cria um vilão
        Character villain = creator.CreateCharacter("villain");
        villain.DisplayInfo();

        Console.ReadKey();
    }
}
