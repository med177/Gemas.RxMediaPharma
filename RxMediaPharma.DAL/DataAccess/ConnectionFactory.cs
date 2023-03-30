using System.Data.SQLite;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RxMediaPharma.DAL
{
	public class ConnectionFactory
	{
		public static IDbConnection SQLiteDbConnection()
		{
			string _connectionString = ConfigurationManager.ConnectionStrings["SQLite"].ToString();
			try
			{
				var connection = new SQLiteConnection(_connectionString);
				connection.Open();
				return connection;
			}
			catch (Exception ex)
			{
				throw new FileNotFoundException($"Veritabanına bağlanamadı App.Config dosyasındaki ConnectionString alanını kontrol edin.\n {ex.Message}");
			}
		}
	}
}
