using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Model
{
	public class IlacDto : BaseModel
	{
		public string ILAC_ADI { get; set; }
		public string NFC { get; set; }
		public string ATCKODU { get; set; }
		public string RECETE { get; set; }
		public int ORDER { get; set; }
		public int FARMASOTIKFORM { get; set; }
		public int MUSTAHZAR1 { get; set; }
		public int KONTROLETABI { get; set; }
		public string FIRMA { get; set; }
	}
}
