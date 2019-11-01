using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.SistemaAgencia
{
        class UrlVaziaOuNulaException : Exception
        {

        public UrlVaziaOuNulaException() { }

        public UrlVaziaOuNulaException(string msg)
            : base(msg) { }
        }
}
