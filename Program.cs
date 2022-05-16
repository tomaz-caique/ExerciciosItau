using System;

namespace Cepom
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExecutarContasAPagar_ISS_CPOM(
                false, 
                false, 
                false, 
                false, 
                false);    
                
            ExecutarContasAPagar_ISS_CPOM(
                true, 
                false, 
                false, 
                false, 
                false);
                
            ExecutarContasAPagar_ISS_CPOM(
                true, 
                true, 
                true, 
                true, 
                false);
                
            ExecutarContasAPagar_ISS_CPOM(
                true, 
                false, 
                true, 
                true, 
                false);
        }
        
        static void ExecutarContasAPagar_ISS_CPOM(
            bool naturezaCalculaISS, 
            bool fornecedorRecolheISS, 
            bool fornecedorDeOutroMunicipio, 
            bool municipioDoTomadorExigeCPOM, 
            bool possuiCPOM)
        {
            Console.Write($"> naturezaCalculaISS: {naturezaCalculaISS} ");
            Console.Write($"fornecedorRecolheISS: {fornecedorRecolheISS} ");
            Console.Write($"fornecedorDeOutroMunicipio: {fornecedorDeOutroMunicipio} ");
            Console.Write($"municipioDoTomadorExigeCPOM: {municipioDoTomadorExigeCPOM} ");
            Console.WriteLine($"possuiCPOM: {possuiCPOM} ");      
            
            //Início do trecho para alteração

            Iniciar();
           IncluirContasAPagar();

            if (naturezaCalculaISS == true && fornecedorRecolheISS == false)
                TributarPrestadorDeServicos();
            if (naturezaCalculaISS == true && fornecedorRecolheISS == true) 
                TributarTomadorDeServicos();
            if (fornecedorRecolheISS == false && municipioDoTomadorExigeCPOM == true)
               TributarTomadorDeServicos();

            Finalizar();
            //Fim do trecho para alteração
            
            Console.WriteLine();
        }
        
        static void IncluirContasAPagar()
        {
            Console.WriteLine("IncluirContasAPagar");
        }
        
        static void TributarPrestadorDeServicos()
        {
            Console.WriteLine("TributarPrestadorDeServicos");
        }
        
        static void TributarTomadorDeServicos()
        {
            Console.WriteLine("TributarTomadorDeServicos");
        }    
        
        static void Iniciar()
        {
            Console.WriteLine("Iniciar");
        }
        
        static void Finalizar()
        {
            Console.WriteLine("Finalizar");
        }    
  
    }
}