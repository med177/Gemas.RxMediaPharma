using AutoMapper;

using RxMediaPharma.BL.Domain;
using RxMediaPharma.BL.Model;

using System;
using System.Collections.Generic;

namespace RxMediaPharma.BL
{
	public interface IIlacDetayService
	{
		IlacDetayDto GetIlacDetayById(int ilacId, int userLoginId);
		List<IlacDetayDto> GetIlacDetayBySearchText(string searchText);
		List<EtkinMaddeDetayDto> GetEtkinMaddeByFormId(int formId);
		bool UpdateIlacAsFavorite(FavoriDto favori);
	}
}