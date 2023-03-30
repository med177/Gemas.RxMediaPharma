using RxMediaPharma.BL.Domain;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

using RxMediaPharma.DAL;


namespace RxMediaPharma.BL.Repository
{
	public class IlacRepository : IRepository<Ilac>
	{
		public IlacRepository()
		{
			
		}

		public IEnumerable<Ilac> GetAll()
		{
			string sql = "SELECT * FROM ILACLAR";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				var ilaclar = connection.Query<Ilac>(sql).ToList();

				return ilaclar;
			}
		}

		public Ilac GetById(int id)
		{
			string sql = "SELECT * FROM ILACLAR WHERE ID = @Id";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				var ilac = connection.QueryFirstOrDefault<Ilac>(sql, new { Id = id });

				return ilac;
			}
		}

		public int Add(Ilac ilac)
		{
			string sql = "INSERT INTO ILACLAR (ILAC_ADI, NFC, ATCKODU, RECETE, [ORDER], FARMASOTIKFORM, MUSTAHZAR1, KONTROLETABI, FIRMA) " +
						 "VALUES (@IlacAdi, @Nfc, @AtcKodu, @Recete, @Order, @FarmasotikForm, @Mustahzar1, @KontrolEtiketi, @Firma);" +
						 "SELECT last_insert_rowid();";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				int newId = connection.ExecuteScalar<int>(sql, ilac);

				return newId;
			}
		}

		public bool Update(Ilac ilac)
		{
			string sql = "UPDATE ILACLAR SET ILAC_ADI = @IlacAdi, NFC = @Nfc, ATCKODU = @AtcKodu, " +
						 "RECETE = @Recete, [ORDER] = @Order, FARMASOTIKFORM = @FarmasotikForm, " +
						 "MUSTAHZAR1 = @Mustahzar1, KONTROLETABI = @KontrolEtiketi, FIRMA = @Firma " +
						 "WHERE ID = @Id";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				int rowsAffected = connection.Execute(sql, ilac);

				return rowsAffected > 0;
			}
		}

		public bool Delete(int id)
		{
			string sql = "DELETE FROM ILACLAR WHERE ID = @Id";

			using (IDbConnection connection = ConnectionFactory.SQLiteDbConnection())
			{
				int rowsAffected = connection.Execute(sql, new { Id = id });

				return rowsAffected > 0;
			}
		}

	}
}
