using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Configuration;
using Autofac;
using RxMediaPharma.BL;
using Autofac.Core;
using System.Data;
using RxMediaPharma.DAL;

namespace RxMediaPharma
{
	internal static class Program
	{
		public static IContainer Container;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (!ApplicationHelper.CheckRunningApp(Application.ProductName))
			{
				MessageBox.Show("Uygulama zaten açık durumda.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Container = Configure();
			Application.Run(new FrmIlacDetay(Container.Resolve<IIlacDetayService>()));
		}

		static IContainer Configure()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<IlacDetayService>().As<IIlacDetayService>();
			builder.RegisterType<FrmIlacDetay>();

			return builder.Build();
		}
	}

	static class ApplicationHelper
	{
		static Mutex mutex = null;
		public static bool CheckRunningApp(string appName)
		{
			Mutex.TryOpenExisting(appName, out mutex);
			if (mutex == null)
			{
				mutex = new Mutex(true, appName);
				return true;
			}
			else
			{
				mutex.Close();
				return false;
			}
		}
	}
}
