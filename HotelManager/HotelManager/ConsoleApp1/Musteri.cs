using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Musteri
	{
		List<string> TurAgentSiyahisi = new List<string>();

		public List<string> TurAgentTap(Person[] _Arr)
		{
			List<string> agentler = new List<string>();

			for (int i = 0; i < _Arr.Length; i++)
			{
				if (_Arr[i] != null)
				{
					Console.WriteLine("Tur Agent: {0}", _Arr[i].TurAgenti);
					agentler.Add(_Arr[i].TurAgenti);
				}
			}
			TurAgentSiyahisi = agentler;
			return TurAgentSiyahisi;
		}

	}
}
