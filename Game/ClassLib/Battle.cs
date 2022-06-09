namespace ClassLib;
public class Battle
{

//dealing damage, blocking the damage and calculating remaining HP of both fighters
public void StartFight()
{   Random rnd = new Random();
    Ogre ogre = new Ogre();
    Swordsman swordsman = new Swordsman();
    ogre.Health = 1000;
    swordsman.Health = 1000;
    
    
    Console.WriteLine("\n\nBoth fighters start with " + ogre.Health + " health. \n\n");
    while (true)
    {   
        if (swordsman.Health == 1000 && ogre.Health == 1000)
        {   
            //special attacks - look at Ogre.cs & Swordman.cs
            ogre.OgreSmash(swordsman.Health); 
            swordsman.SwordsmanSlash(ogre.Health);

            Console.WriteLine(ogre.Name + " used his Super Power: OGRE SMASH! " + swordsman.Name +
             "'s health drops to " 
            + ogre.OgreSmash(swordsman.Health) + "\n\n");

            Console.WriteLine(swordsman.Name + " used his Super Power: SWORDSMAN'S SLASH! " + ogre.Name +
             "'s health drops to " 
            + swordsman.SwordsmanSlash(ogre.Health) + "\n\n");

            //health = full health(1000)- special attack damage
            swordsman.Health = ogre.OgreSmash(swordsman.Health);
            ogre.Health = swordsman.SwordsmanSlash(ogre.Health);
            
        }
        
        ogre.Attack=rnd.Next(200,300); // random attack between 200 and 300
        swordsman.Health = swordsman.Health - ogre.Attack;
        swordsman.Block=rnd.Next(100,200); // random block between 100 and 200
        swordsman.Health = swordsman.Health + swordsman.Block;
        

        //print battle output
        Console.WriteLine(ogre.Name + " attacked with " + ogre.Attack + " damage. " + swordsman.Name +
         " blocked with " + swordsman.Block + " and has " + swordsman.Health + " health left. \n" );
         

        if (swordsman.Health<=0)
        {
            Console.WriteLine(ogre.Name + " won!");
            break;
        }
         swordsman.Attack=rnd.Next(200,300); //random attack between 200 and 300
    	 ogre.Health = ogre.Health - swordsman.Attack;
          ogre.Block=rnd.Next(100,200); //random block between 100 and 200
         ogre.Health =ogre.Health + ogre.Block;

        //print battle output
        Console.WriteLine(swordsman.Name + " attacked with " + swordsman.Attack + " damage and " 
        + ogre.Name +" blocked with "+ ogre.Block + " and has " + ogre.Health + " health left. \n" );
        
        if (ogre.Health<=0)
        {
            Console.WriteLine(swordsman.Name + " won!");
            break;
        }
       
      
    }

}







}
