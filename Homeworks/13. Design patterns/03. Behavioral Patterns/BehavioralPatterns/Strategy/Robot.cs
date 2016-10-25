namespace Strategy
{
    using System;

    public class Robot
    {
        private IBehaviour behaviour;
        private string name;

        public Robot(string name)
        {
            this.name = name;
        }

        public void SetBehaviour(IBehaviour behaviour)
        {
            this.behaviour = behaviour;
        }

        public IBehaviour GetBehaviour()
        {
            return this.behaviour;
        }

        public void Move()
        {
            Console.WriteLine(this.name + ": Based on current position" +
                         "the behaviour object decide the next move:");
            int command = this.behaviour.MoveCommand();

            // ... send the command to mechanisms
            Console.WriteLine("\tThe result returned by behaviour object " +
                        "is sent to the movement mechanisms " +
                        " for the robot '" + this.name + "'");
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
