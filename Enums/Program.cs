namespace Enums
{
    public class Program
    {
        static void Main()
        {
            Weapon myWeapon = new Weapon(BulletType.mm_762, 5);
            myWeapon.Fill();

            myWeapon.PullTrigger(); 
            myWeapon.Fire();       
            myWeapon.Fire();        

            myWeapon.PullTrigger(); 


            
        }
    }
}