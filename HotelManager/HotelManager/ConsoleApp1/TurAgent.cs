using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class TurAgent
	{


		List<int> bosOtaqSiyahisi = new List<int>();
		List<Person> QeydeAlinanMusteriler = new List<Person>();

		public List<int> BosOtaqlariYoxla(Person[] _arr)
		{
			List<int> BosOtaqlar = new List<int>();

			for (var i = 0; i < _arr.Length; i++)
			{
				if (_arr[i] == null)
				{
					BosOtaqlar.Add(i);
				}
			}
			bosOtaqSiyahisi = BosOtaqlar;
			return bosOtaqSiyahisi;
		}

		public List<Person> QeydiyyataAl(int _BrounCount)
		{
			var QeydiyyatliInsan = new List<Person>();
			for (int i = 0; i < _BrounCount; i++)
			{
				Console.WriteLine("adi: ");
				string Ad = Console.ReadLine();

				Console.WriteLine("Id-si :");
				int Id = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Tur agentinin adi: ");
				string turAgent = Console.ReadLine();

				Person Pers = new Person(Ad, Id, turAgent);
				QeydiyyatliInsan.Add(Pers);
			}
			QeydeAlinanMusteriler = QeydiyyatliInsan;
			return QeydeAlinanMusteriler;
		}

		public void BrounEt(Person[] _arrray)
		{
			BosOtaqlariYoxla(_arrray);
			for (int x = 0; x < QeydeAlinanMusteriler.Count; x++)
			{
					_arrray[bosOtaqSiyahisi[x]] = QeydeAlinanMusteriler[x];	
			}
		}
	}
}

