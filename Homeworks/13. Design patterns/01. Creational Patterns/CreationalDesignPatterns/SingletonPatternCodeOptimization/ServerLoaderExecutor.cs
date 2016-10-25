namespace SingletonPatternCodeOptimization
{
    using System;

    public class ServerLoaderExecutor
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            ServerLoader b1 = ServerLoader.GetServer();
            ServerLoader b2 = ServerLoader.GetServer();
            ServerLoader b3 = ServerLoader.GetServer();
            ServerLoader b4 = ServerLoader.GetServer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            ServerLoader balancer = ServerLoader.GetServer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
        }
    }
}
