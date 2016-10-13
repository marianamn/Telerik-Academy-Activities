namespace SingletonPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class ServerLoader
    {
        // Lock synchronization object
        private static object syncLock = new object();

        private static ServerLoader instance;
        private List<string> servers = new List<string>();
        private Random random = new Random();

        protected ServerLoader()
        {
            // List of available servers
            this.servers.Add("ServerI");
            this.servers.Add("ServerII");
            this.servers.Add("ServerIII");
            this.servers.Add("ServerIV");
            this.servers.Add("ServerV");
        }

        // random server loader
        public string Server
        {
            get
            {
                int randomServer = this.random.Next(this.servers.Count);
                return this.servers[randomServer].ToString();
            }
        }

        public static ServerLoader GetServer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new ServerLoader();
                    }
                }
            }

            return instance;
        }
    }
}
