using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Model
{
	public class IlacDetayDto
	{
		public int ILAC_ID { get; set; }
		public string ILAC_TANIM { get; set; }
		public string ILAC_ADI { get; set; }
		public string NFC { get; set; }
		public string ATCKODU { get; set; }
		public string RECETE { get; set; }
		public int ORDER { get; set; }
		public int FARMASOTIKFORM { get; set; }
		public int MUSTAHZAR1 { get; set; }
		public int KONTROLETABI { get; set; }
		public string FIRMA { get; set; }

		public int ILAC_FORM_ID { get; set; }
		public string OLCU { get; set; }
		public string SGKETKINKODU { get; set; }
		public string KUB { get; set; }

		public int ILAC_AMBALAJ_ID { get; set; }
		public string BARKOD { get; set; }
		public string AMBALAJ { get; set; }
		public string FIYATTARIH { get; set; }
		public float FIYAT { get; set; }
		public float DEPOCU { get; set; }
		public float IMALATCI { get; set; }
		public float KAMUFIYATI { get; set; }
		public float KAMUODENEN { get; set; }
		public string JENERIKORIJINAL { get; set; }
		public string ESDEGERGRUP { get; set; }
		public string DURUM { get; set; }
		public byte[] AMBALAJRESIM { get; set; }

		public int IS_FAVORI { get; set; }
		public int KULLANICI_ID { get; set; }
	}
}
