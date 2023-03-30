using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Domain
{
	public class IlacForm : BaseEntity
	{
		public string OLCU { get; set; }
		public int ILAC_ID { get; set; }
		public string SGKETKINKODU { get; set; }
		public string KUB { get; set; }
	}
}
