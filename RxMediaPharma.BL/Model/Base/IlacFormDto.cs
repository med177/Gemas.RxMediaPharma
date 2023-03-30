using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Model
{
	public class IlacFormDto : BaseModel
	{
		public string OLCU { get; set; }
		public int ILAC_ID { get; set; }
		public string SGKETKINKODU { get; set; }
		public string KUB { get; set; }
	}
}
