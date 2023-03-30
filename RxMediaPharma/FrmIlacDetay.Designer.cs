namespace RxMediaPharma
{
	partial class FrmIlacDetay
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIlacDetay));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstIlac = new System.Windows.Forms.ListBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblKamuOdenenFark = new System.Windows.Forms.Label();
			this.lblFiyatTarih = new System.Windows.Forms.Label();
			this.btnBarcodeCopy = new System.Windows.Forms.Button();
			this.label30 = new System.Windows.Forms.Label();
			this.lblRecete = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.lblAtcKod = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.lblSgkKod = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.lblOrijin = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.lblKdv = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.lblImalatciFiyat = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.lblDepocuFiyat = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblKamuOdenen = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblKamuFiyat = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblFiyat = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblFirma = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblBarkod = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.lblAmbalaj = new System.Windows.Forms.Label();
			this.lblIlacOlcu = new System.Windows.Forms.Label();
			this.lblIlacAdi = new System.Windows.Forms.Label();
			this.btnFav = new System.Windows.Forms.Button();
			this.btnKub = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.grdEtkinMadde = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.picBarcode = new System.Windows.Forms.PictureBox();
			this.picIlacKutu = new System.Windows.Forms.PictureBox();
			this.lblPicBarcode = new System.Windows.Forms.Label();
			this.lblBarkodView = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdEtkinMadde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picIlacKutu)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lstIlac);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(275, 533);
			this.panel1.TabIndex = 0;
			// 
			// lstIlac
			// 
			this.lstIlac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lstIlac.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstIlac.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstIlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstIlac.FormattingEnabled = true;
			this.lstIlac.ItemHeight = 16;
			this.lstIlac.Location = new System.Drawing.Point(3, 40);
			this.lstIlac.Name = "lstIlac";
			this.lstIlac.Size = new System.Drawing.Size(269, 480);
			this.lstIlac.TabIndex = 2;
			this.lstIlac.SelectedIndexChanged += new System.EventHandler(this.lstIlac_SelectedIndexChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Image = global::RxMediaPharma.Properties.Resources.search_black;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(244, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(28, 28);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSearch.Location = new System.Drawing.Point(3, 6);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(241, 24);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Location = new System.Drawing.Point(293, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(393, 548);
			this.panel2.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.lblKamuOdenenFark);
			this.panel5.Controls.Add(this.lblFiyatTarih);
			this.panel5.Controls.Add(this.btnBarcodeCopy);
			this.panel5.Controls.Add(this.label30);
			this.panel5.Controls.Add(this.lblRecete);
			this.panel5.Controls.Add(this.label28);
			this.panel5.Controls.Add(this.lblAtcKod);
			this.panel5.Controls.Add(this.label26);
			this.panel5.Controls.Add(this.lblSgkKod);
			this.panel5.Controls.Add(this.label24);
			this.panel5.Controls.Add(this.lblOrijin);
			this.panel5.Controls.Add(this.label22);
			this.panel5.Controls.Add(this.lblKdv);
			this.panel5.Controls.Add(this.label20);
			this.panel5.Controls.Add(this.lblImalatciFiyat);
			this.panel5.Controls.Add(this.label18);
			this.panel5.Controls.Add(this.lblDepocuFiyat);
			this.panel5.Controls.Add(this.label16);
			this.panel5.Controls.Add(this.lblKamuOdenen);
			this.panel5.Controls.Add(this.label14);
			this.panel5.Controls.Add(this.lblKamuFiyat);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.lblFiyat);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.lblFirma);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.lblBarkod);
			this.panel5.Location = new System.Drawing.Point(3, 141);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(379, 392);
			this.panel5.TabIndex = 3;
			// 
			// lblKamuOdenenFark
			// 
			this.lblKamuOdenenFark.ForeColor = System.Drawing.Color.Tomato;
			this.lblKamuOdenenFark.Location = new System.Drawing.Point(139, 164);
			this.lblKamuOdenenFark.Name = "lblKamuOdenenFark";
			this.lblKamuOdenenFark.Size = new System.Drawing.Size(231, 13);
			this.lblKamuOdenenFark.TabIndex = 0;
			this.lblKamuOdenenFark.Text = "...";
			// 
			// lblFiyatTarih
			// 
			this.lblFiyatTarih.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lblFiyatTarih.Location = new System.Drawing.Point(139, 95);
			this.lblFiyatTarih.Name = "lblFiyatTarih";
			this.lblFiyatTarih.Size = new System.Drawing.Size(231, 13);
			this.lblFiyatTarih.TabIndex = 0;
			this.lblFiyatTarih.Text = "...";
			// 
			// btnBarcodeCopy
			// 
			this.btnBarcodeCopy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBarcodeCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnBarcodeCopy.Image")));
			this.btnBarcodeCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBarcodeCopy.Location = new System.Drawing.Point(278, 11);
			this.btnBarcodeCopy.Name = "btnBarcodeCopy";
			this.btnBarcodeCopy.Size = new System.Drawing.Size(23, 24);
			this.btnBarcodeCopy.TabIndex = 7;
			this.btnBarcodeCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBarcodeCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBarcodeCopy.UseVisualStyleBackColor = true;
			this.btnBarcodeCopy.Click += new System.EventHandler(this.btnBarcodeCopy_Click);
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label30.Location = new System.Drawing.Point(8, 355);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(125, 18);
			this.label30.TabIndex = 0;
			this.label30.Text = "REÇETE :";
			// 
			// lblRecete
			// 
			this.lblRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblRecete.Location = new System.Drawing.Point(139, 355);
			this.lblRecete.Name = "lblRecete";
			this.lblRecete.Size = new System.Drawing.Size(231, 18);
			this.lblRecete.TabIndex = 0;
			this.lblRecete.Text = "...";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label28.Location = new System.Drawing.Point(8, 326);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(125, 18);
			this.label28.TabIndex = 0;
			this.label28.Text = "ATC KODU :";
			// 
			// lblAtcKod
			// 
			this.lblAtcKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAtcKod.Location = new System.Drawing.Point(139, 326);
			this.lblAtcKod.Name = "lblAtcKod";
			this.lblAtcKod.Size = new System.Drawing.Size(231, 18);
			this.lblAtcKod.TabIndex = 0;
			this.lblAtcKod.Text = "...";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label26.Location = new System.Drawing.Point(8, 297);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(125, 18);
			this.label26.TabIndex = 0;
			this.label26.Text = "SGK KODU:";
			// 
			// lblSgkKod
			// 
			this.lblSgkKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSgkKod.Location = new System.Drawing.Point(139, 297);
			this.lblSgkKod.Name = "lblSgkKod";
			this.lblSgkKod.Size = new System.Drawing.Size(231, 18);
			this.lblSgkKod.TabIndex = 0;
			this.lblSgkKod.Text = "...";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label24.Location = new System.Drawing.Point(8, 268);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(125, 18);
			this.label24.TabIndex = 0;
			this.label24.Text = "J/O ORIJIN :";
			// 
			// lblOrijin
			// 
			this.lblOrijin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOrijin.Location = new System.Drawing.Point(139, 268);
			this.lblOrijin.Name = "lblOrijin";
			this.lblOrijin.Size = new System.Drawing.Size(231, 18);
			this.lblOrijin.TabIndex = 0;
			this.lblOrijin.Text = "...";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label22.Location = new System.Drawing.Point(8, 241);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(125, 18);
			this.label22.TabIndex = 0;
			this.label22.Text = "KDV :";
			// 
			// lblKdv
			// 
			this.lblKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKdv.Location = new System.Drawing.Point(139, 241);
			this.lblKdv.Name = "lblKdv";
			this.lblKdv.Size = new System.Drawing.Size(231, 18);
			this.lblKdv.TabIndex = 0;
			this.lblKdv.Text = "...";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label20.Location = new System.Drawing.Point(8, 214);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(125, 18);
			this.label20.TabIndex = 0;
			this.label20.Text = "İMALATÇI FİYATI :";
			// 
			// lblImalatciFiyat
			// 
			this.lblImalatciFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblImalatciFiyat.Location = new System.Drawing.Point(139, 214);
			this.lblImalatciFiyat.Name = "lblImalatciFiyat";
			this.lblImalatciFiyat.Size = new System.Drawing.Size(231, 18);
			this.lblImalatciFiyat.TabIndex = 0;
			this.lblImalatciFiyat.Text = "...";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label18.Location = new System.Drawing.Point(8, 186);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(125, 18);
			this.label18.TabIndex = 0;
			this.label18.Text = "DEPOCU FİYATI :";
			// 
			// lblDepocuFiyat
			// 
			this.lblDepocuFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepocuFiyat.Location = new System.Drawing.Point(139, 186);
			this.lblDepocuFiyat.Name = "lblDepocuFiyat";
			this.lblDepocuFiyat.Size = new System.Drawing.Size(231, 18);
			this.lblDepocuFiyat.TabIndex = 0;
			this.lblDepocuFiyat.Text = "...";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label16.Location = new System.Drawing.Point(8, 142);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(125, 18);
			this.label16.TabIndex = 0;
			this.label16.Text = "KAMU ÖDENEN :";
			// 
			// lblKamuOdenen
			// 
			this.lblKamuOdenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKamuOdenen.Location = new System.Drawing.Point(139, 142);
			this.lblKamuOdenen.Name = "lblKamuOdenen";
			this.lblKamuOdenen.Size = new System.Drawing.Size(231, 18);
			this.lblKamuOdenen.TabIndex = 0;
			this.lblKamuOdenen.Text = "...";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label14.Location = new System.Drawing.Point(8, 115);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(125, 18);
			this.label14.TabIndex = 0;
			this.label14.Text = "KAMU FİYATI :";
			// 
			// lblKamuFiyat
			// 
			this.lblKamuFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKamuFiyat.Location = new System.Drawing.Point(139, 115);
			this.lblKamuFiyat.Name = "lblKamuFiyat";
			this.lblKamuFiyat.Size = new System.Drawing.Size(231, 18);
			this.lblKamuFiyat.TabIndex = 0;
			this.lblKamuFiyat.Text = "...";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(8, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(125, 18);
			this.label10.TabIndex = 0;
			this.label10.Text = "FİYAT:";
			// 
			// lblFiyat
			// 
			this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblFiyat.Location = new System.Drawing.Point(139, 70);
			this.lblFiyat.Name = "lblFiyat";
			this.lblFiyat.Size = new System.Drawing.Size(231, 22);
			this.lblFiyat.TabIndex = 0;
			this.lblFiyat.Text = "...";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(8, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 18);
			this.label8.TabIndex = 0;
			this.label8.Text = "FİRMA :";
			// 
			// lblFirma
			// 
			this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblFirma.Location = new System.Drawing.Point(139, 42);
			this.lblFirma.Name = "lblFirma";
			this.lblFirma.Size = new System.Drawing.Size(231, 18);
			this.lblFirma.TabIndex = 0;
			this.lblFirma.Text = "...";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.Location = new System.Drawing.Point(8, 14);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(125, 18);
			this.label11.TabIndex = 0;
			this.label11.Text = "BARKOD :";
			// 
			// lblBarkod
			// 
			this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBarkod.Location = new System.Drawing.Point(139, 14);
			this.lblBarkod.Name = "lblBarkod";
			this.lblBarkod.Size = new System.Drawing.Size(133, 18);
			this.lblBarkod.TabIndex = 0;
			this.lblBarkod.Text = "...";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnPrevious);
			this.panel4.Controls.Add(this.btnNext);
			this.panel4.Controls.Add(this.lblAmbalaj);
			this.panel4.Controls.Add(this.lblIlacOlcu);
			this.panel4.Controls.Add(this.lblIlacAdi);
			this.panel4.Controls.Add(this.btnFav);
			this.panel4.Controls.Add(this.btnKub);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(393, 136);
			this.panel4.TabIndex = 2;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrevious.Image = global::RxMediaPharma.Properties.Resources.Arrows_Back_icon;
			this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrevious.Location = new System.Drawing.Point(12, 5);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(28, 28);
			this.btnPrevious.TabIndex = 3;
			this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNext.Image = global::RxMediaPharma.Properties.Resources.Arrows_Forward_icon;
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNext.Location = new System.Drawing.Point(46, 5);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(28, 28);
			this.btnNext.TabIndex = 4;
			this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lblAmbalaj
			// 
			this.lblAmbalaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAmbalaj.Location = new System.Drawing.Point(12, 109);
			this.lblAmbalaj.Name = "lblAmbalaj";
			this.lblAmbalaj.Size = new System.Drawing.Size(367, 18);
			this.lblAmbalaj.TabIndex = 0;
			this.lblAmbalaj.Text = "...";
			// 
			// lblIlacOlcu
			// 
			this.lblIlacOlcu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIlacOlcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIlacOlcu.Location = new System.Drawing.Point(11, 86);
			this.lblIlacOlcu.Name = "lblIlacOlcu";
			this.lblIlacOlcu.Size = new System.Drawing.Size(368, 23);
			this.lblIlacOlcu.TabIndex = 0;
			this.lblIlacOlcu.Text = "...";
			// 
			// lblIlacAdi
			// 
			this.lblIlacAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIlacAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIlacAdi.Location = new System.Drawing.Point(11, 63);
			this.lblIlacAdi.Name = "lblIlacAdi";
			this.lblIlacAdi.Size = new System.Drawing.Size(368, 23);
			this.lblIlacAdi.TabIndex = 0;
			this.lblIlacAdi.Text = "...";
			// 
			// btnFav
			// 
			this.btnFav.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFav.Image = ((System.Drawing.Image)(resources.GetObject("btnFav.Image")));
			this.btnFav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFav.Location = new System.Drawing.Point(80, 5);
			this.btnFav.Name = "btnFav";
			this.btnFav.Size = new System.Drawing.Size(28, 28);
			this.btnFav.TabIndex = 5;
			this.btnFav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFav.UseVisualStyleBackColor = true;
			this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
			// 
			// btnKub
			// 
			this.btnKub.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKub.Location = new System.Drawing.Point(114, 5);
			this.btnKub.Name = "btnKub";
			this.btnKub.Size = new System.Drawing.Size(52, 28);
			this.btnKub.TabIndex = 6;
			this.btnKub.Text = "KÜB";
			this.btnKub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKub.UseVisualStyleBackColor = true;
			this.btnKub.Click += new System.EventHandler(this.btnKub_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.lblPicBarcode);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.picBarcode);
			this.panel3.Controls.Add(this.picIlacKutu);
			this.panel3.Controls.Add(this.lblBarkodView);
			this.panel3.Location = new System.Drawing.Point(695, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(233, 548);
			this.panel3.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.grdEtkinMadde);
			this.panel6.Controls.Add(this.label6);
			this.panel6.Location = new System.Drawing.Point(3, 289);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(226, 125);
			this.panel6.TabIndex = 2;
			// 
			// grdEtkinMadde
			// 
			this.grdEtkinMadde.BackgroundColor = System.Drawing.Color.White;
			this.grdEtkinMadde.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.grdEtkinMadde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdEtkinMadde.Location = new System.Drawing.Point(4, 33);
			this.grdEtkinMadde.Name = "grdEtkinMadde";
			this.grdEtkinMadde.Size = new System.Drawing.Size(217, 83);
			this.grdEtkinMadde.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(4, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(217, 22);
			this.label6.TabIndex = 0;
			this.label6.Text = "ETKİN MADDE";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picBarcode
			// 
			this.picBarcode.Image = global::RxMediaPharma.Properties.Resources.barcode;
			this.picBarcode.Location = new System.Drawing.Point(3, 454);
			this.picBarcode.Name = "picBarcode";
			this.picBarcode.Size = new System.Drawing.Size(226, 61);
			this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBarcode.TabIndex = 1;
			this.picBarcode.TabStop = false;
			// 
			// picIlacKutu
			// 
			this.picIlacKutu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIlacKutu.Location = new System.Drawing.Point(3, 28);
			this.picIlacKutu.Name = "picIlacKutu";
			this.picIlacKutu.Size = new System.Drawing.Size(226, 173);
			this.picIlacKutu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picIlacKutu.TabIndex = 0;
			this.picIlacKutu.TabStop = false;
			// 
			// lblPicBarcode
			// 
			this.lblPicBarcode.Location = new System.Drawing.Point(14, 264);
			this.lblPicBarcode.Name = "lblPicBarcode";
			this.lblPicBarcode.Size = new System.Drawing.Size(205, 22);
			this.lblPicBarcode.TabIndex = 0;
			this.lblPicBarcode.Text = "...";
			this.lblPicBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBarkodView
			// 
			this.lblBarkodView.Location = new System.Drawing.Point(3, 206);
			this.lblBarkodView.Name = "lblBarkodView";
			this.lblBarkodView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblBarkodView.Size = new System.Drawing.Size(226, 71);
			this.lblBarkodView.TabIndex = 0;
			this.lblBarkodView.Text = "...";
			this.lblBarkodView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmIlacDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(940, 583);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FrmIlacDetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RxMediaPharma - İlaç Detay";
			this.Load += new System.EventHandler(this.FrmIlacDetay_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdEtkinMadde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picIlacKutu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ListBox lstIlac;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblIlacAdi;
		private System.Windows.Forms.Button btnKub;
		private System.Windows.Forms.Button btnFav;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnBarcodeCopy;
		private System.Windows.Forms.PictureBox picBarcode;
		private System.Windows.Forms.PictureBox picIlacKutu;
		private System.Windows.Forms.Label lblPicBarcode;
		private System.Windows.Forms.Label lblAmbalaj;
		private System.Windows.Forms.Label lblIlacOlcu;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label lblRecete;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lblAtcKod;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label lblSgkKod;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label lblOrijin;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label lblKdv;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label lblImalatciFiyat;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label lblDepocuFiyat;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblKamuOdenen;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblKamuFiyat;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblFiyat;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblFirma;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblBarkod;
		private System.Windows.Forms.Label lblKamuOdenenFark;
		private System.Windows.Forms.Label lblFiyatTarih;
		private System.Windows.Forms.DataGridView grdEtkinMadde;
		private System.Windows.Forms.Label lblBarkodView;
	}
}

