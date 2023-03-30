using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Model
{
	public class IlacAmbalajDto : BaseModel
	{
		public string BARKOD { get; set; }
		public int ILAC_FORM_ID { get; set; }
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
	}
}
