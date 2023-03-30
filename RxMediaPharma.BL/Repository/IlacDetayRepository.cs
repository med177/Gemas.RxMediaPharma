using RxMediaPharma.BL.Domain;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

using RxMediaPharma.DAL;
using System.Data.Common;
using Microsoft.SqlServer.Server;


namespace RxMediaPharma.BL.Repository
{
	public class IlacDetayRepository : IIlacDetayRepository
	{
		public IlacDetayRepository()
		{

		}

		public IlacDetay GetIlacDetayById(int ilacId, int userLoginId)
		{
			string sql = $@"
				SELECT 
					i.ILAC_ADI || ' ' || f.OLCU AS ILAC_TANIM,
					i.ILAC_ADI, i.NFC, i.ATCKODU, i.RECETE, i.[ORDER], i.FARMASOTIKFORM, i.MUSTAHZAR1, i.KONTROLETABI, i.FIRMA,
					f.OLCU, f.ILAC_ID, f.SGKETKINKODU, f.KUB,
					a.ID AS ILAC_AMBALAJ_ID, a.BARKOD, a.ILAC_FORM_ID, a.AMBALAJ, a.FIYATTARIH, a.FIYAT, a.DEPOCU, a.IMALATCI,
					a.KAMUFIYATI, a.KAMUODENEN, a.JENERIKORIJINAL, a.ESDEGERGRUP, a.DURUM, a.AMBALAJRESIM,
					fav.IS_FAVORI, fav.KULLANICI_ID
				FROM ILACLAR AS i 
					INNER JOIN ILAC_FORM AS f ON f.ILAC_ID = i.ID  
					INNER JOIN ILAC_AMBALAJ AS a ON a.ILAC_FORM_ID = f.ID 
					LEFT JOIN FAVORI AS fav ON fav.ILAC_AMBALAJ_ID = a.ID AND fav.KULLANICI_ID=@userLoginId
				WHERE a.ID=@ilacId 
				";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				var result = connection.QueryFirst<IlacDetay>(sql, new { ilacId = ilacId, userLoginId = userLoginId });

				return result;
			}
		}

		public IEnumerable<IlacDetay> GetIlacDetayBySearchText(string searchText)
		{
			string cond = " i.ILAC_ADI LIKE @ilacAdi ";
			object prm = new { ilacAdi = $"%{searchText}%" };

			if (searchText.IsNumeric() && searchText.Length == 13)
			{
				cond = " a.BARKOD = @barkod ";
				prm = new { barkod = searchText };
			}
			else if (searchText.Length == 0)
			{
				cond = " 1=1 ";
				prm = new { };
			}

			string sql = $@"
				SELECT 
					i.ILAC_ADI || ' ' || f.OLCU AS ILAC_TANIM,
					i.ILAC_ADI, i.NFC, i.ATCKODU, i.RECETE, i.[ORDER], i.FARMASOTIKFORM, i.MUSTAHZAR1, i.KONTROLETABI, i.FIRMA,
					f.OLCU, f.ILAC_ID, f.SGKETKINKODU, f.KUB,
					a.ID AS ILAC_AMBALAJ_ID, a.BARKOD, a.ILAC_FORM_ID, a.AMBALAJ, a.FIYATTARIH, a.FIYAT, a.DEPOCU, a.IMALATCI,
					a.KAMUFIYATI, a.KAMUODENEN, a.JENERIKORIJINAL, a.ESDEGERGRUP, a.DURUM, a.AMBALAJRESIM
				FROM ILACLAR AS i 
					INNER JOIN ILAC_FORM AS f ON f.ILAC_ID = i.ID  
					INNER JOIN ILAC_AMBALAJ AS a ON a.ILAC_FORM_ID = f.ID 
				WHERE {cond} LIMIT 100
				";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				var result = connection.Query<IlacDetay>(sql, prm).ToList();
				return result;
			}
		}

		public IEnumerable<EtkinMaddeDetay> GetEtkinMaddeByFormId(int formId)
		{
			string sql = $@"
				SELECT
					iem.ID AS ETKIN_MADDE_ID, iem.ETKIN_MADDE, iem.ILAC_FORM_ID, iem.MIKTAR, iem.BIRIM,
					em.ETKINMADDE
				FROM ILAC_ETKIN_MADDELER AS iem 
				INNER JOIN ETKIN_MADDELER AS em ON em.ID = iem.ETKIN_MADDE
				WHERE iem.ILAC_FORM_ID = @formId
				";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				var result = connection.Query<EtkinMaddeDetay>(sql, new { formId = formId }).ToList();

				return result;
			}
		}

		public void CreateFavoriteTable()
		{
			string sql = $@"
				CREATE TABLE IF NOT EXISTS [FAVORI] (
					ID INTEGER PRIMARY KEY AUTOINCREMENT,
					KULLANICI_ID INTEGER NOT NULL,
					ILAC_AMBALAJ_ID INTEGER NOT NULL,
					IS_FAVORI BOOL INTEGER DEFAULT 0 NOT NULL
				);
				";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				connection.ExecuteScalar(sql);
			}
		}

		public bool UpdateIlacAsFavorite(Favori favori)
		{
			string sql = $@"
				INSERT OR REPLACE INTO FAVORI (ID, KULLANICI_ID, ILAC_AMBALAJ_ID, IS_FAVORI)
				VALUES ((SELECT ID FROM FAVORI WHERE KULLANICI_ID = @KULLANICI_ID AND ILAC_AMBALAJ_ID = @ILAC_AMBALAJ_ID),
						@KULLANICI_ID, @ILAC_AMBALAJ_ID, @IS_FAVORI);
				";
			try
			{
				using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
				{
					connection.ExecuteScalar(sql, favori);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
