namespace test.Services
{
    public interface ICalculation
    {
        public int sum(int a, int b);
        public int subtraction(int a, int b);
    }
    public class Calculation : ICalculation
    {
        private readonly IHelloWorldService _helloWorldService;
        public Calculation(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }
        public int subtraction(int a, int b)
        {
            
            Console.WriteLine(_helloWorldService.GreetGoodMorning);
            Console.WriteLine($"a:{a} - b:{b}");
            return a - b;
        }

        public int sum(int a, int b)
        {
            Console.WriteLine(_helloWorldService.GreetGoodMorning);
            Console.WriteLine($"a:{a} + b:{b}");
            return a + b;
        }
      

    }
}
