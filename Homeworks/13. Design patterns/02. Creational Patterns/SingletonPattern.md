# Creational Patterns Homework #

## Singleton Pattern ##

----------

### Описание ###

Singleton е design pattern, който ни позволява един клас да има единствена инстнанция на даден обект и предоставя глобален достъп да нея. Този шаблон се използва обикновено в моделирането на обекти, които трябва да бъдат глобално достъпни за обектите на приложението (например обекта съдържащ структурите с настройките на програмата) или обекти, които се нуждаят от максимално късна инициализация за пестенето на ресурси от паметта.

### Цел ###

Използва се за неща, които са глобални и единствени за приложението.

### Употреба ###

* Window manager
* File system
* Console


### Структура на design pattern-a ###

![](/Images/SingletonStructure.png)

### Участници ###
* Singleton - дефинира инстационен оператор, който позволява на клиента да достъпи неговата уникална инстанция.

### Свързани Design patterns ###

Шаблоните: The Abstract Factory, Builder, и Prototype могат да използват Singleton при тяхното изпълнение.

### Недостатъци ###

Singleton шаблонът често е критикуван, поради наличието на редица проблеми:

* дефолтната имплементация не може да се ползва в многонишкова среда
* нарушава се един от основните SOLID принципи - Single responsisbility principle
* tight coupling
* кодът е трудно тестваем 

### Имплементация ###

Singleton шаблонът се изпълнява, като се прави клас с метод, който прави нова инстанция на класа, ако не съществува. Ако инстанцията съществува, връща референцията на този обект. За да е сигурно, че обектът не може да бъде инстанциран по друг начин, конструкторът се прави private. Забелязва се, че разликата между простата статична инстанция на класа и шаблона, въпреки че шаблона може да представи статичната инстанция, също може  да бъде и мързеливо конструиран (lazy loading), не се изисква памет или ресурси, докато не са нужни.

Singleton шаблонът трябва да бъде внимателно конструиран в multi-threaded апликации. Ако два треда изпълнят направения метод по едно и също време, когато шаблона вече не съществува, и двата трябва да се проверят за инстанция на шаблона и само тогава да се създаде нов. Класическото решение на този проблем е взаимоизключващия клас, който показва на обекта, че е представен.


### Пример за използване на Singleton Pattern:###

* Създаване на ServerLoader - може да бъде създадена една единствена инстанция на класа. Сърварите могат да бъдат on- или off-line и всеки request трябва да бъде направен през единединствен обект, който има знанието за състоянието на web.

**Code:**

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

    ----------------------------------------
    
    public class ServerLoaderExecutor
    {
        public static void Main(string[] args)
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
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
        }
    }

**Code optimization**

The Singleton pattern simply uses a private constructor and a static readonly instance variable that is lazily initialized. Thread safety is guaranteed by the compiler.

    /// <summary>
    /// Represents a server machine
    /// </summary>
    public class Server
    {
        // Gets or sets server name
        public string Name { get; set; }

        // Gets or sets server IP address
        public string IP { get; set; }
    }

    ----------------------------------------

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
    ----------------------------------------

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
