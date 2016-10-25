namespace Strategy
{
    using System;

    public class AgressiveBehaviour : IBehaviour
    {
        public int MoveCommand()
        {
            Console.WriteLine("\tAgressive Behaviour: if find another robot attack it");
            return 1;
        }
    }
}
