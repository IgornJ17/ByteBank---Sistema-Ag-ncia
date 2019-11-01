using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ByteBank - O banco inteligente");

            ContaCorrente conta1 = new ContaCorrente(494, 124452, "Igor");

            string url = "pagina?argumento";
			string indice = url.IndexOf("?")
			
			string argumento = url.Substring(indice++);
			

            Console.ReadLine();


        }
		
		static void VerificadorUrl(string url)
		{
			
			try
			{	
				ExtratorArgumentoUrl extrator = new ExtratorArgumentoUrl(url);
			}
			catch(UrlVaziaOuNulaException e)
			{
				Console.WriteLine(e.StackTrace());
				Console.WriteLine(e.Menssage());
				
			}
		}			
    }
}
