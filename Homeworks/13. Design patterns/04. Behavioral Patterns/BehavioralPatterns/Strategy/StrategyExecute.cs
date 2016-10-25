namespace Strategy
{
    using System;

    public class StrategyExecute
    {
        public static void Main()
        {
            Robot r1 = new Robot("Big Robot");
            Robot r2 = new Robot("George v.2.1");
            Robot r3 = new Robot("R2");

            r1.SetBehaviour(new AgressiveBehaviour());
            r2.SetBehaviour(new DefensiveBehaviour());
            r3.SetBehaviour(new NormalBehaviour());

            r1.Move();
            r2.Move();
            r3.Move();

            Console.WriteLine("\r\nNew behaviours: " +
                    "\r\n\t'Big Robot' gets really scared" +
                    "\r\n\t, 'George v.2.1' becomes really mad because" +
                    "it's always attacked by other robots" +
                    "\r\n\t and R2 keeps its calm\r\n");

            r1.SetBehaviour(new DefensiveBehaviour());
            r2.SetBehaviour(new AgressiveBehaviour());

            r1.Move();
            r2.Move();
            r3.Move();
        }
    }
}
