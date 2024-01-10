namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient}");
            Console.WriteLine($"{a} & {b} is {remainder}");

            var i = 3;
            var j = 4;
            var k = 0;
            Console.WriteLine(k = ++i * j++);
            Console.WriteLine(k);
            Console.WriteLine(j);
            j++;
            Console.WriteLine(j);
 

            Console.WriteLine("Give me a number for your chosen radius: ");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            AreaOfCircle(radius);

            Console.WriteLine(AreaOfCircle(radius));
        }
        
        
        public static double AreaOfCircle(double radius)
        {
            
            double area = (Math.PI * radius * radius);

           // Console.WriteLine(area);

            return area;
        }
    }
}
