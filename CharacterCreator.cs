namespace abstractfactoryproblem;

// Classe para criar personagens

class CharacterCreator
{
    public Character CreateCharacter(string type)
    {
        Character character = new Character();

        if (type == "hero")
        {
            character.Name = "Hero";
            character.Type = "Good";
            character.Weapon = "Sword";
        }
        else if (type == "villain")
        {
            character.Name = "Villain";
            character.Type = "Evil";
            character.Weapon = "Axe";
        }
        else
        {
            throw new Exception("Invalid character type.");
        }

        return character;
    }
}