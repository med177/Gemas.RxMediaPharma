﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Domain
{
	public class Favori : BaseEntity
	{
		public int KULLANICI_ID { get; set; }
		public int ILAC_AMBALAJ_ID { get; set; }
		public int IS_FAVORI { get; set; }
	}
}
