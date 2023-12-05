internal class Program
{
    public static int longitudMax = 0;
    private static void Main(string[] args)
    {
        Console.Write("Tamaño del array:");
        int n = int.Parse(Console.ReadLine());
        List<int> numeros = [];

        for (int i = 1; i < n + 1; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }
        var numerosOrdenados = numeros.OrderBy(p => p).ToList(); 
        var tamañoSub = 0;
        while(longitudMax == 0 )
        {
            for (var i = 0; i < 2; i++)
            {
                foreach (var item in numerosOrdenados)
                {

                }    
                tamañoSub++;
            }
            
        }
        DeterminarPar(numerosOrdenados);
    
        Console.WriteLine(String.Join("",numerosOrdenados));
    }
        
        
        private static bool DeterminarPar(List<int> numeros)
        {
            int diferencia = 0;

            for (var i = 0; i < numeros.Count - 1; i++)
            {
                diferencia +=  numeros[i] - numeros[i + 1];
            }

            diferencia *= - 1;
            if (diferencia * (- 1) % 2 == 0)
            {
                longitudMax = numeros.Count;
                Console.WriteLine(string.Join(" ", numeros) + " Length: " + numeros.Count );
                return true;
            }else{
                return false;
            }

        } 
        

    
}