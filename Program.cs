internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //avarage of three numbers
        
        int fnum;
        int snum;
        int tnum;
        double avarage;
        Console.WriteLine("input three numers to get their avarage as follows");
         Console.WriteLine("Enter first number");
         fnum=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter second number");
         snum=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter third number");
         tnum=Convert.ToInt32(Console.ReadLine());
         avarage=(fnum+snum+tnum)/3;

         Console.WriteLine("The avarage of given: "+ fnum +", "+snum+" and "+tnum+" is: "+avarage);
         */
         //loops
         Random numbergen=new Random();
         int roll=0;
         int attempts=0;

         Console.WriteLine("Press enter to roll die.");
         while(roll != 6){
            Console.ReadKey();

            roll= numbergen.Next(1, 7);
            Console.WriteLine("Your rolled: "+ roll);
            attempts++;
         }
         Console.WriteLine("It take "+attempts+ "attempts to roll a six")

        Console.ReadKey();
    }
}
