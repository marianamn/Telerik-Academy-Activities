namespace Strategy
{
    using System;

    public class NormalBehaviour : IBehaviour
    {
        public int MoveCommand()
        {
            Console.WriteLine("\tNormal Behaviour: if find another robot ignore it");
            return 0;
        }
    }
}
