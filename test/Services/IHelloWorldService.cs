namespace test.Services
{
    public interface IHelloWorldService
    {
        public string GreetGoodMorning();
        public string GreetGoodEvening();
        public string GreetGoodNoon();
        
    }
    public class HelloWorldService : IHelloWorldService
    {
        public string GreetGoodEvening()
        {
            return "GoodEvening";
        }

        public string GreetGoodMorning()
        {
            return "GoodMorning";
        }

        public string GreetGoodNoon()
        {
            return "GoodNoon";
        }
    }
}
