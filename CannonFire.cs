using pa4game.Interfaces;

namespace pa4game
{
    public class CannonFire : IAttack
    {
        public void PrimaryAttack()
        {
            System.Console.WriteLine("  " );
            System.Console.WriteLine("Davy Jones used cannon fire.");
            System.Console.WriteLine("  ");
        }
    }
}