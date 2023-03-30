using RxMediaPharma.BL.Domain;
using RxMediaPharma.BL.Model;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using AutoMapper;
using Dapper;
using RxMediaPharma.BL.Repository;
using RxMediaPharma.DAL;
using RxMediaPharma.BL.Service;
using System.Data;
using Microsoft.SqlServer.Server;

namespace RxMediaPharma.BL
{
	public class IlacDetayService : IIlacDetayService
	{
		private IMapper _mapper;
		private IIlacDetayRepository _repository;

		public IlacDetayService()
		{
			var repository = new IlacDetayRepository();

			_repository = repository;

			_mapper = new Mapper(new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<AutoMapperProfile>();
			}));

			_repository.CreateFavoriteTable();
		}

		public IlacDetayDto GetIlacDetayById(int ilacId, int userLoginId)
		{
			IlacDetayDto result = null;

			if (ilacId > 0)
			{
				var ilac = new IlacDetay();

				ilac = _repository.GetIlacDetayById(ilacId, userLoginId);

				if (ilac != null)
				{
					result = _mapper.Map<IlacDetay, IlacDetayDto>(ilac);
				}
			}

			return result;
		}

		public List<IlacDetayDto> GetIlacDetayBySearchText(string searchText)
		{
			var result = new List<IlacDetayDto>();

			var ilaclar = new List<IlacDetay>();

			ilaclar = _repository.GetIlacDetayBySearchText(searchText).ToList();

			if (ilaclar.Count() > 0)
			{
				result = _mapper.Map<IEnumerable<IlacDetay>, List<IlacDetayDto>>(ilaclar);
			}

			return result;
		}

		public List<EtkinMaddeDetayDto> GetEtkinMaddeByFormId(int formId)
		{
			var result = new List<EtkinMaddeDetayDto>();

			if (formId > 0)
			{
				var etkinMaddeler = new List<EtkinMaddeDetay>();

				etkinMaddeler = _repository.GetEtkinMaddeByFormId(formId).ToList();

				if (etkinMaddeler.Count() > 0)
				{
					result = _mapper.Map<IEnumerable<EtkinMaddeDetay>, List<EtkinMaddeDetayDto>>(etkinMaddeler);
				}
			}

			return result;
		}

		public bool UpdateIlacAsFavorite(FavoriDto favoriDto)
		{
			var favori = _mapper.Map<FavoriDto, Favori>(favoriDto);
			return _repository.UpdateIlacAsFavorite(favori);
		}
	}
}
