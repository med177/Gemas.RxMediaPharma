using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RxMediaPharma.BL;
using RxMediaPharma.BL.Model;
using RxMediaPharma.BL.Repository;
using RxMediaPharma.DAL;
using RxMediaPharma.Properties;

namespace RxMediaPharma
{
	public partial class FrmIlacDetay : Form
	{
		private readonly IIlacDetayService _ilacService;

		private string _searchPalceHolder = "URUN ARA ...";
		private List<int> _ilacHistory = new List<int>();
		private int _historyIndex = -1;
		private IlacDetayDto _currentIlac = null;
		private int _userLoginId = 1;

		public FrmIlacDetay(IIlacDetayService service)
		{
			InitializeComponent();
			_ilacService = service;
		}

		private void FrmIlacDetay_Load(object sender, EventArgs e)
		{
			txtSearch.Text = _searchPalceHolder;

			PrepareGrid();
			SearchIlac("");
		}

		private void PrepareGrid()
		{
			grdEtkinMadde.ReadOnly = true;
			grdEtkinMadde.ColumnHeadersVisible = false;
			grdEtkinMadde.RowHeadersVisible = false;
			grdEtkinMadde.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			grdEtkinMadde.ScrollBars = ScrollBars.Vertical;
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SearchIlac(txtSearch.Text);
			}
		}

		private void SearchIlac(string searchText)
		{
			var ilaclar = _ilacService.GetIlacDetayBySearchText(searchText.Trim());
			lstIlac.DataSource = ilaclar;
			lstIlac.DisplayMember = "ILAC_TANIM";
			lstIlac.ValueMember = "ILAC_AMBALAJ_ID";
		}

		private void txtSearch_Click(object sender, EventArgs e)
		{
			if (txtSearch.Text == _searchPalceHolder)
			{
				txtSearch.Text = "";
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtSearch.Text == _searchPalceHolder) txtSearch.Text = "";
			SearchIlac(txtSearch.Text);
		}

		private void lstIlac_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstIlac.SelectedItem is IlacDetayDto ilac)
			{
				ShowIlacDetay(ilac.ILAC_AMBALAJ_ID);
			}
		}

		private void ShowIlacDetay(int ilacId, bool normal = true)
		{
			_currentIlac = _ilacService.GetIlacDetayById(ilacId, _userLoginId);
			lblIlacAdi.Text = _currentIlac.ILAC_ADI;
			lblIlacOlcu.Text = _currentIlac.OLCU;
			lblAmbalaj.Text = _currentIlac.AMBALAJ;

			ShowFav(_currentIlac.IS_FAVORI == 1);

			lblBarkod.Text = _currentIlac.BARKOD;
			lblPicBarcode.Text = _currentIlac.BARKOD;
			ShowBarcode(_currentIlac.BARKOD);

			lblFirma.Text = _currentIlac.FIRMA;
			lblFiyat.Text = _currentIlac.FIYAT.To<decimal>().ToString("c2");
			lblFiyatTarih.Text = $"({_currentIlac.FIYATTARIH:dd/MM/yyyy})";
			lblKamuFiyat.Text = _currentIlac.KAMUFIYATI.To<decimal>().ToString("c2"); ;
			lblKamuOdenen.Text = _currentIlac.KAMUODENEN.To<decimal>().ToString("c2");
			lblKamuOdenenFark.Text = $"({(_currentIlac.KAMUFIYATI - _currentIlac.KAMUODENEN).To<decimal>().ToString("c2")} FİYAT FARKI)";
			lblDepocuFiyat.Text = _currentIlac.DEPOCU.To<decimal>().ToString("c2") + " + KDV";
			lblImalatciFiyat.Text = _currentIlac.IMALATCI.To<decimal>().ToString("c2") + " + KDV";
			lblKdv.Text = "%8";
			lblOrijin.Text = _currentIlac.JENERIKORIJINAL;
			lblSgkKod.Text = _currentIlac.SGKETKINKODU;
			lblAtcKod.Text = _currentIlac.ATCKODU;
			lblRecete.Text = _currentIlac.RECETE;
			picIlacKutu.Image = ByteToImage(_currentIlac.AMBALAJRESIM);

			var etkinMaddeler = _ilacService.GetEtkinMaddeByFormId(_currentIlac.ILAC_FORM_ID);


			var grdItems = new List<object>();
			foreach (var item in etkinMaddeler)
			{
				grdItems.Add(new { col1 = item.ETKINMADDE, col2 = $"{item.MIKTAR} {item.BIRIM}" });
			}
			grdEtkinMadde.DataSource = grdItems;
			grdEtkinMadde.Columns[0].Width = 150;
			grdEtkinMadde.Columns[1].Width = 50;
			grdEtkinMadde.ClearSelection();

			if (normal)
			{
				_ilacHistory.Add(_currentIlac.ILAC_AMBALAJ_ID);
				_historyIndex++;
			}

			btnPrevious.Enabled = false;
			btnNext.Enabled = false;
			if (_ilacHistory.Count > 0 && _historyIndex != 0)
			{
				btnPrevious.Enabled = true;
			}

			if (_ilacHistory.Count-1 > _historyIndex)
			{
				btnNext.Enabled = true;
			}

		}

		private void ShowFav(bool isFavorite)
		{
			if (isFavorite)
			{
				btnFav.Image = Resources.FontAwesome_heart_solid_svg;
			}
			else
			{
				btnFav.Image = Resources.FontAwesome_heart_svg;
			}
		}

		private void ShowBarcode(string barcode)
		{
			lblBarkodView.Font = new Font("EAN-13", 48);
			if(lblBarkodView.Font.Name!="EAN-13"){
				picBarcode.Visible = true;
				picBarcode.Top = lblBarkodView.Top;
				picBarcode.Left = lblBarkodView.Left;
			}
			else
			{
				picBarcode.Visible = false;
			}
			lblBarkodView.Text = barcode;
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (_historyIndex > 0 && _historyIndex < _ilacHistory.Count())
			{
				_historyIndex--;
				ShowIlacDetay(_ilacHistory[_historyIndex], false);
			}				
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (_historyIndex < _ilacHistory.Count()-1)
			{
				_historyIndex++;
				ShowIlacDetay(_ilacHistory[_historyIndex], false);
			}				
		}

		private void btnFav_Click(object sender, EventArgs e)
		{
			var favori = new FavoriDto
			{
				ILAC_AMBALAJ_ID = _currentIlac.ILAC_AMBALAJ_ID,
				KULLANICI_ID = _userLoginId,
				IS_FAVORI = _currentIlac.IS_FAVORI == 0 ? 1 : 0,
			};
			if (_ilacService.UpdateIlacAsFavorite(favori))
			{
				ShowFav(_currentIlac.IS_FAVORI == 0);
			}
		}

		private void btnKub_Click(object sender, EventArgs e)
		{
			FrmIlacBilgi frmIlacBilgi = new FrmIlacBilgi(_currentIlac.KUB);
			frmIlacBilgi.ShowDialog();
		}

		private void btnBarcodeCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblBarkod.Text);
		}

		public Image ByteToImage(byte[] imageBytes)
		{
			if (imageBytes.Length > 0)
			{
				var stream = new MemoryStream(imageBytes, 0, imageBytes.Length);
				stream.Write(imageBytes, 0, imageBytes.Length);
				Image image = new Bitmap(stream);
				return image;
			}
			else
			{
				return null;
			}
		}

	}
}
