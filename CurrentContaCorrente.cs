using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;


namespace ByteBank.SistemaInterno
{
	//Classe utilizada para criação e exclusão de Contas Correntes cadastradas.
	public class CurrentContaCorrente
	{
		private ContaCorrente[] _contas;
		private int _nextPosition;
		private int _qttDefault = 5;
		
		//Construtor da Classe
		public CurrentContaCorrente()
		{
			_contas = new ContaCorrente[_qttDefault];
			
		}
		
		//metodo publico para adicionar uma lista ou valores unitários de Contas Correntes.
		public void AdicionarConta(ContaCorrente conta)
		{
			_contas[_nextPosition] = conta;
			if(_contas[_nextPosition].Cc == conta.Cc )
			{
				Console.WriteLine($"Conta {_contas[_nextPosition].Cc} adicionada com sucesso...");
			}
			else
			{

				Console.WriteLine($"Conta {_contas[_nextPosition].Cc} não pode ser adicionada...");
				if(_contas.Length < _nextPosition)
				{
					bool checagem = CheckDeCapacidade(_contas.Length);
					if(checagem == true){return;}
					throw new IndexOutOfRangeException("A capacidade da lista/memória foi ultrapassada.");
				}
			}
			_nextPosition++;
			
		}
		//Método de verificação do tamanho do array. Se a capacidade do Array for ultrapassada esse método irá criar um novo array com mais 10 -
		//Celulas de memória e irá transferir as referencias de objetos para o outro array.
		private bool CheckDeCapacidade(int tamanhoAlmejado)
		{
			
			bool valorDeRetorno = false;
			
			if(_contas.Length < tamanhoAlmejado)
			{
				try
				{
					tamanhoEstruturado = _contas.Length + 10;
					ContaCorrente[] newContas = new ContaCorrente[tamanhoEstruturado];
					for(int i = 0; i < _contas.Length; i++)
					{
						newContas[i] = _contas[i];
					}
					valorDeRetorno = true;
					return valorDeRetorno;
				}
				catch(OutOfMemoryException)
				{
					return valorDeRetorno;
				}
			}
			else
			{
				return valorDeRetorno;
			}
			_contas = newContas;
		}
	}
	
	
}
































