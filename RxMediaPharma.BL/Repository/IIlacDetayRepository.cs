using RxMediaPharma.BL.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxMediaPharma.BL
{
	public interface IIlacDetayRepository
	{
		IlacDetay GetIlacDetayById(int ilacId, int userLoginId);
		IEnumerable<IlacDetay> GetIlacDetayBySearchText(string searchText);
		IEnumerable<EtkinMaddeDetay> GetEtkinMaddeByFormId(int formId);
		void CreateFavoriteTable();
		bool UpdateIlacAsFavorite(Favori favori);
	}
}
