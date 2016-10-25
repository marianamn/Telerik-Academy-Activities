namespace Strategy
{
    using System;

    public class DefensiveBehaviour : IBehaviour
    {
        public int MoveCommand()
        {
            Console.WriteLine("\tDefensive Behaviour: if find another robot run from it");
            return -1;
        }
    }
}
