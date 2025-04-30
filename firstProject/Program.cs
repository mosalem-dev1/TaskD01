namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello Eraasoft 517");
            //
            //int[] arr = [0,0,0,0,0,0,0,0,0,0];
            //arr[0] = 100;
            //arr[^1] = 1000;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[^1]);
            //Console.WriteLine(arr[3]);


           //Console.WriteLine("Enter your favourit number between 1 and 100 :");
           //int? fnumber = Convert.ToInt32(Console.ReadLine()) ;
           //Console.WriteLine($"No really !! , {fnumber} is my favourite too" );

            Console.WriteLine("Enter your name");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter your salary");
            int? salary = Convert.ToInt32(Console.ReadLine()) ;

            salary = salary + 1000;

            // use concatenation
            Console.WriteLine("hello " + name);

            //or use string interpolation

            Console.WriteLine($"hello  {name} ");



        }
    }
}
