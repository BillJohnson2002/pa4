using pa4game.Interfaces;

namespace pa4game
{
    public class Sword : IAttack
    {
        public void PrimaryAttack()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Will Turner used sword");
            System.Console.WriteLine(" ");
        }
    }
}