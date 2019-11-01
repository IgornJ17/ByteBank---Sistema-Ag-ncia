using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorArgumentoUrl
    {
		private readonly _argumento;
        public string Url { get; }
        public ExtratorArgumentoUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new UrlVaziaOuNulaException("A url está vazia ou tem uma referencia a uma constante null");
            }
			
			_argumento = url.SubString(url.IndexOf('?') + 1); 
            
			Url = url;
			string indiceArg = (url.IndexOf('?')) + 1;
			string argumento = url.SubString(indiceArg);
			_argumento = argumento.ToLower();	
        }
		
		
		//Método utilizado para retornar o valor de um parametro em uma URL. Este método realiza o corte da string 
		//que é recolida da URL e pega o valor dos argumentos setados nela.
		public string GetValor(string parametro)
		{
			string termoLower = parametro.ToLower();
			string termo = termoLower + '=';
			
			int indiceTermo = _argumento.IndexOf(termo);
			n
			string resultado = _argumento.SubString(indiceTermo + termo.Length);
			int IndiceEComercial = resultado.IndexOf('&');
			
			if (IndiceEComercial == -1)
			{
				return resultado;
			}
			
			return resultado.Remove(IndiceEComercial);
			
			
		}
    }
}
