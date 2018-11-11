using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] hotel = new Person[10];

			TurAgent agent = new TurAgent();
			Musteri Costumer = new Musteri();
			Adminstrator admin = new Adminstrator();

			hotel[1] = new Person("Elnur", 5, "Tural");
			hotel[5] = new Person("Nura", 5, "Zakir");
			hotel[6] = new Person("Roza", 5, "Fazil");


			string emrler;
			void emrleriGoster()
			{
				Console.WriteLine(" 1) Agentem ");
				Console.WriteLine(" 2) Musteriyem ");
				Console.WriteLine(" 3) Adminstrator ");
				Console.WriteLine("emri sec:");
				emrler = Console.ReadLine();
			}
			string agentEmri;
			void AgentEmrleri()
			{
				Console.WriteLine("1) Musteri qeydiyyata al");
				Console.WriteLine("2) Oteldeki bos otaqlari gor");
				Console.WriteLine("3) Musterileri bron et ");
				Console.WriteLine("emri sec:");
				agentEmri = Console.ReadLine();
			}

			string musteriEmri;
			void MusteriEmrleri()
			{
				Console.WriteLine("1) Tur agent siyahisini gor");
				Console.WriteLine("2) Oteldeki bos otaq sayini gor");
				Console.WriteLine("emri sec:");
				musteriEmri = Console.ReadLine();
			}


			string adminEmri;
			void AdminEmrleri()
			{
				Console.WriteLine("1) Bos otaglara bax");
				Console.WriteLine("2) Dolu otaqlardaki musterilerin melumatlarini gor");
				Console.WriteLine("3) Agentlerin melumatlarini gor");
				Console.WriteLine("4) Hansi musterinin hansi agent terefinden otele getirildiyi yoxla");
				Console.WriteLine("5) Agentin nece musterinin otelde galdigini yoxla");
				Console.WriteLine("emri sec:");
				adminEmri = Console.ReadLine();
			}

			void agentKod()
			{
				Console.WriteLine("username yazin: ");
				string username = Console.ReadLine();

				Console.WriteLine("kodu yazin: ");
				string kod = Console.ReadLine();
				if (kod == "123456" && username == "admin")
				{
					agentIsleri();
				}
			}

			void musteriKod()
			{
				Console.WriteLine("username yazin: ");
				string username = Console.ReadLine();

				Console.WriteLine("kodu yazin: ");
				string kod = Console.ReadLine();
				if (kod == "123456" && username == "admin")
				{
					musteriIsleri();
				}
			}

			void adminKod()
			{
				Console.WriteLine("::::::Otel melumatlarina baxmaq ucun sisteme giris edin:::::");

				Console.WriteLine("USERNAME YAZIN::: ");
				string username = Console.ReadLine();

				Console.WriteLine("KODU YAZIN:::: ");
				string kod = Console.ReadLine();
				if (kod == "12345" && username == "admin")
				{
					adminIsleri();
				}
			}

			void agentIsleri()
			{
				AgentEmrleri();
				switch (agentEmri)
				{
					case "1":
						Console.WriteLine("Nece nefer qeydiyyat olacaq?");
							var qeydInsan = agent.QeydiyyataAl(Convert.ToInt32(Console.ReadLine()));
							foreach (var it in qeydInsan)
							{
								Console.WriteLine("name: {0},Id: {1} , Tur Agenti: {2}", it.name, it.ID, it.TurAgenti);
							}
							Console.WriteLine("Qeydiyyatiniz tamamlandi.");
							Console.WriteLine("-----------------------");
							emrleriGoster();		
						break;
					case "2":
						Console.WriteLine("Bos otaqlarin siyahsi:");
						var bosOtaq = agent.BosOtaqlariYoxla(hotel);
						foreach (var item in bosOtaq)
							Console.Write(item + "-ci otaq" + ",");
						   Console.WriteLine("");
						emrleriGoster();
						break;
					case "3":
						agent.BrounEt(hotel);
						for (int i = 0; i < hotel.Length; i++)
						{
							if (hotel[i] != null)
							{
								Console.WriteLine(i + "-ci otaqda qalan musteri " + hotel[i].name + "-dir");
							}
						}
						emrleriGoster();
						break;
					default:
						break;
				}

			}

			void musteriIsleri()
			{
				MusteriEmrleri();
				switch (musteriEmri)
				{
					case "1":
						Costumer.TurAgentTap(hotel);
						Console.WriteLine("-----------------------");
						emrleriGoster();
						break;
					case "2":
						Console.WriteLine("Bos otaqlarin siyahsi:");
						var bosOtaq = agent.BosOtaqlariYoxla(hotel);
						foreach (var item in bosOtaq)
						{
							Console.WriteLine(item);
						}
						Console.WriteLine("-----------------------");
						emrleriGoster();
						break;
					default:
						break;
				}

			}


			void adminIsleri()
			{
				AdminEmrleri();
				switch (adminEmri)
				{
					case "1":
						Console.WriteLine("Bos otaqlarin siyahsi:");
						var bosOtaq = agent.BosOtaqlariYoxla(hotel);
						foreach (var item in bosOtaq)
						{
							Console.WriteLine(item);
						}
						Console.WriteLine("-----------------------");
						emrleriGoster();
						break;
					case "2":
						admin.MusterininMelumatlariniGor(hotel);
						emrleriGoster();
						break;
					case "3":
						Costumer.TurAgentTap(hotel);
						emrleriGoster();
						break;

					case "4":
						admin.MusteriAgentiniYoxla(hotel);
						emrleriGoster();
						break;
					case "5":
						admin.AgentMusterisiSayi(hotel);
						emrleriGoster();
						break;
					case "":
						break;

					default:
						break;
				}

			}


			emrleriGoster();
			while (emrler != "exit")
			{
				switch (emrler)
				{
					case "1":
						agentKod();
						continue;
					case "2":
						musteriKod();
						continue;
					case "3":
						adminKod();
						continue;
					default:
						break;
				}
				break;
			}


			Console.ReadKey();
			}

	}
	}