using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace RxMediaPharma
{
	public partial class FrmIlacBilgi : Form
	{
		private string _html;
		public FrmIlacBilgi(string html)
		{
			InitializeComponent();
			_html = html;
		}

		private void FrmIlacBilgi_Load(object sender, EventArgs e)
		{
			DisplayHtml();
		}

		private void DisplayHtml()
		{
			webBrowser1.Navigate("about:blank");
			try
			{
				if (webBrowser1.Document != null)
				{
					webBrowser1.Document.Write(string.Empty);
				}
			}
			catch (Exception e)
			{ 
			
			}

			//TODO: css de include edilmeli henüz elimizde css yok
			string css = @"
			<style>
				body { 
					font-family: Arial, Helvetica, sans-serif;
				}

				.tbap {
					font-weight: bold;
				}
			</style>
			";

			_html = _html.Replace("<head>\r\n</head>", $@"<head>{css}</head>");

			webBrowser1.DocumentText = _html;
		}
	}
}
