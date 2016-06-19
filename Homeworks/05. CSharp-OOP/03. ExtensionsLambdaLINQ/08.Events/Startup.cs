namespace _08.Events
{
    public class Startup
    {
        public static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber1 = new Subscriber("Subscriber 1", publisher);
            Subscriber subscriber2 = new Subscriber("Subscriber 2", publisher);

            publisher.MassageToCustomers();
        }
    }
}
