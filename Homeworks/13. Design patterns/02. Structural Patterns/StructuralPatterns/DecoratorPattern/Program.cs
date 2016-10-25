namespace DecoratorPattern
{
    using System;

    public class EventsCostCalculatior
    {
        public static void Main(string[] args)
        {
            IEventService seminarService = new SeminarService();
            PhotographyService photographyService = new PhotographyService(seminarService);
            CateringService cateringService = new CateringService(photographyService);
            Console.WriteLine(cateringService.Cost);
        }
    }
}
