using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Adminstrator
	{
				public int say = 0;

		List<Person> MusteriMelumatlari = new List<Person>();
		List<string> MusterininAgenti = new List<string>();

		public List<Person> MusterininMelumatlariniGor(Person[] _arrInfo)
		{
			List<Person> MelumatMusteri = new List<Person>();

			for (int i = 0; i < _arrInfo.Length; i++)
			{
				if (_arrInfo[i] != null)
				{
               MelumatMusteri.Add(_arrInfo[i]);
					Console.WriteLine("Musterinin Adi: {0} , Musterinin ID nomresi: {1} , Musterini getiren Tur Agent: {2} , Otaq nomresi: {3}", _arrInfo[i].name, _arrInfo[i].ID, _arrInfo[i].TurAgenti, i );
				}
			}

			MusteriMelumatlari = MelumatMusteri;

			return MusteriMelumatlari;
		}

        public List<string> MusteriAgentiniYoxla(Person[] _arrAgent)
		{
			List<string> MusteriAgenti = new List<string>();

			Console.WriteLine("Musterinin Adi:   ");
			string MusterininAdi = Console.ReadLine();

			for (int i = 0; i < _arrAgent.Length; i++)
			{
				if(_arrAgent[i] != null)
				{
					if (_arrAgent[i].name == MusterininAdi)
					{
						MusteriAgenti.Add(_arrAgent[i].TurAgenti);
						Console.WriteLine(MusterininAdi + "adli musterinin TUR AGENTI " + _arrAgent[i].TurAgenti + "-dir");
						break;
					}
				}
			}
			MusterininAgenti = MusteriAgenti;
			return MusterininAgenti;
		}

		public void AgentMusterisiSayi(Person[] _arraySay)
		{
			Console.WriteLine("Agent adi: ");
			var agentAdi = Console.ReadLine();
			for (int i = 0; i < _arraySay.Length; i++)
			{
				if(_arraySay[i] != null)
				{
					if (_arraySay[i].TurAgenti == agentAdi)
					{
						say++;
						continue;
					}
					else if (_arraySay[i].TurAgenti != agentAdi)
					{
						break;
					}
				}
			}

			if (say > 0)
			{
				Console.WriteLine(agentAdi + " adli tur agentin " + say + "  musterisi var ");
			}
			else
			{
				Console.WriteLine("----"+ agentAdi + "----" + " adli tur agent yoxdur!!!!");
			}

		}

	}
}
