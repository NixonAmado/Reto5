internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sam daily: " );
        int SamDaily =  int.Parse( Console.ReadLine());
        Console.WriteLine("Kelly daily: " );
        int KellyDaily =  int.Parse( Console.ReadLine());
        Console.WriteLine("Difference: " );
        int Difference =  int.Parse( Console.ReadLine());
        
        int samSolved = Difference + SamDaily; 
        int KellySolved = KellyDaily; 
        int day = 1;
        //Return Int: the minimum number of days needed by Kelly to exceed Samm, or -1 if it is imposible
        
        if(SamDaily < KellyDaily )
        {
            do
            {
            samSolved += SamDaily;
            KellySolved += 5;
            day++;
            
            } while (KellySolved < samSolved);
            Console.WriteLine("The minimum number of days needed by Kelly  to execeed Samm are: " + day);
        }
        else{
            Console.WriteLine("-1");

        }

        
    }

}