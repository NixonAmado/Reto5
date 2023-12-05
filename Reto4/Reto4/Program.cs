using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading; 
using System.Threading.Tasks; 
internal class Program
{
    private static void Main(string[] args)
    {
        int opc = 0;
        while(opc != 1)
        {
            
            Console.WriteLine("2. Votar");
            Console.WriteLine("1. Salir");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 2:
                    Console.Write("Número de universidades: ");
                    int NUniversidades = int.Parse(Console.ReadLine());
                    int URechazan = 0;
                    int UEmpate = 0;
                    int UAceptan = 0;
                    int empate = 0;
                    for (int i = 0; i < NUniversidades; i++)
                    {
 
                        Console.Write("Universidad: ");
                        string NombreU = Console.ReadLine();
                        int  aceptar = 0;
                        int  recharzar = 0;
                        int  blanco = 0;
                        int  nulo = 0;  
                           
                        string voto = "";                                              
                        do
                        {
                            Console.Write("Voto: ");
                            voto = Console.ReadLine().ToUpper();                      

                            switch (voto)
                            {

                                case "A":
                                    aceptar ++;
                                    break;                            

                                case "R":
                                    recharzar ++;
                                    break;                            

                                case "N":
                                    blanco ++;
                                    break;                            

                                case "B":
                                    nulo ++;
                                    break;                            
                            }
                        } while (voto != "X");
                        if(aceptar > recharzar )
                        {
                            UAceptan++;
                                          
                        }
                        else if(aceptar == recharzar)
                                {
                                empate = aceptar;
                                UEmpate += 1;
                                }              
                        else
                        {
                            URechazan++;
                        }
                    }
                    Console.WriteLine("Universidades que aceptan: " + UAceptan);
                    Console.WriteLine("Universidades que rechazan: " + UAceptan);
                    Console.WriteLine("Universidades que empate: " + empate);
                    
                    break;
                default: 
                    break;
            }

        }
    }
}