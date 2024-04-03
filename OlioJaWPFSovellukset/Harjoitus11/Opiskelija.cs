using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11
{
	public class Opiskelija
	{
		public string Etunimi { get; set; }
		public string Sukunimi { get; set; }
		public string Ryhmätunnus { get; set; }
		public string OpiskelijaID {  get; set; }
		
		public Opiskelija(string _Etunimi, string _Sukunimi,string _Ryhmätunnus, string _OpiskelijaID)
		{
			// Katsotaan onko ID unique
			Etunimi = _Etunimi;
			Sukunimi = _Sukunimi;
			Ryhmätunnus = _Ryhmätunnus;
			OpiskelijaID = _OpiskelijaID;
		}
	}
}
