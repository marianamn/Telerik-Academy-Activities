namespace SingletonPatternCodeOptimization
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public sealed class ServerLoader
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly ServerLoader Instance = new ServerLoader();
        private List<Server> servers;
        private Random random = new Random();

        private ServerLoader()
        {
            // Load list of available servers
            this.servers = new List<Server> 
                      { 
                       new Server { Name = "ServerI", IP = "120.14.220.18" },
                       new Server { Name = "ServerII", IP = "120.14.220.19" },
                       new Server { Name = "ServerIII", IP = "120.14.220.20" },
                       new Server { Name = "ServerIV", IP = "120.14.220.21" },
                       new Server { Name = "ServerV", IP = "120.14.220.22" },
                      };
        }

        // Simple, but effective load balancer
        public Server NextServer
        {
            get
            {
                int randomServer = this.random.Next(this.servers.Count);
                return this.servers[randomServer];
            }
        }

        public static ServerLoader GetServer()
        {
            return Instance;
        }
    }
}
