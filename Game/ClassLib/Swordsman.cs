namespace ClassLib;

public class Swordsman : Fighter
{
    public string Name {get;} = "Swordsman";
    public int SwordsmanSlash(int ogreHealth)
    {
        return (ogreHealth-400);
    }

}