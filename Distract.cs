using pa4game.Interfaces;

namespace pa4game
{
    public class Distract : IAttack
    {
        public void PrimaryAttack()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Jack Sparrow used distract.");
            System.Console.WriteLine(" ");
        }
    }
}