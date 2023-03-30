using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Domain
{
	public class IlacEtkinMadde : BaseEntity
	{
		public int ETKIN_MADDE { get; set; }
		public int ILAC_FORM_ID { get; set; }
		public float MIKTAR { get; set; }
		public string BIRIM { get; set; }
	}
}
