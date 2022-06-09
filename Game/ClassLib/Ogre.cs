namespace ClassLib;

public class Ogre : Fighter
{
    public string Name {get;} = "Ogre";

    public int OgreSmash(int swordsmanHealth)
    {
        return (swordsmanHealth-450);
    }
    

}