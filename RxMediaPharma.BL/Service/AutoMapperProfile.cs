using AutoMapper;

using RxMediaPharma.BL.Domain;
using RxMediaPharma.BL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL.Service
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			//Base
			CreateMap<EtkinMadde, EtkinMaddeDto>();

			CreateMap<Ilac, IlacDto>();

			CreateMap<IlacAmbalaj, IlacAmbalajDto>();

			CreateMap<IlacEtkinMadde, IlacEtkinMaddeDto>();

			CreateMap<IlacForm, IlacFormDto>();

			//Combine
			CreateMap<IlacDetay, IlacDetayDto>();

			CreateMap<EtkinMaddeDetay, EtkinMaddeDetayDto>();

			CreateMap<FavoriDto, Favori>();
		}

	}
}
