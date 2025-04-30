namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("charges : $25 per small , $35 per large | Sales Tax = 6%" );
            Console.WriteLine("--------");

            Console.WriteLine("Estimage for carpet cleaning service");
            Console.WriteLine("Number of small carpets : ");
            int? smallCarp  = Convert.ToInt32(Console.ReadLine()) ;

            Console.WriteLine("Number of large carpets : ");
            int? largeCarp = Convert.ToInt32(Console.ReadLine());

            int totalSmall =Convert.ToInt32(smallCarp * 25) ;
            int totalLarge = Convert.ToInt32(largeCarp * 35);

            Console.WriteLine($"Cost of small carpet is {totalSmall}");
            Console.WriteLine($"Cost of large carpet is {totalLarge}");

            int costBeforeTax = totalSmall + totalLarge;

            Console.WriteLine($"total cost before tax : {costBeforeTax} ");

            decimal tax = costBeforeTax * 6 / 100m;
            Console.WriteLine($"Sales tax (6%) : {tax} ");
            Console.WriteLine($"total cost after tax : {costBeforeTax + tax } ");
        }
    }
}
