using System;
using System.Globalization;
namespace NF
{
    class Begin
    {
        static void Main(string[] args)
        {
            decimal valor = 0m;

            Console.WriteLine("Digite o valor da NF:");
            valor = decimal.Parse(Console.ReadLine());
            
            decimal pis = Math.Round(valor * 0.0065m, 2, MidpointRounding.AwayFromZero);
            decimal cofins = Math.Round(valor * 0.03m, 2, MidpointRounding.AwayFromZero);
            decimal csll = Math.Round(valor * 0.01m, 2, MidpointRounding.AwayFromZero);
            decimal ir = Math.Round(valor * 0.015m, 2, MidpointRounding.AwayFromZero);
            decimal totalImpostos = pis + cofins + csll;
            
            Console.WriteLine("\n=== VALORES PARA PREENCHIMENTO ===");
            Console.WriteLine("PIS (0,65%):      {0:C2}", pis);
            Console.WriteLine("COFINS (3%):      {0:C2}", cofins);
            Console.WriteLine("CSLL (1%):        {0:C2}", csll);
            Console.WriteLine("IR (1,5%):        {0:C2}", ir);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Contribuições Sociais retidas (PIS+COFINS+CSLL): {0:C2}", totalImpostos);
            Console.WriteLine("===================================");

            Console.WriteLine("\nPressione qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}