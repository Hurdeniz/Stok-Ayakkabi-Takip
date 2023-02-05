namespace stok_ayakkabi
{
    partial class Xtra_ana_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xtra_ana_form));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_urunler = new DevExpress.XtraEditors.SimpleButton();
            this.btn_rapor = new DevExpress.XtraEditors.SimpleButton();
            this.btn_canli_satis = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barLargeButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.ShowCloseButton = true;
            this.barManager1.ShowFullMenus = true;
            this.barManager1.ShowFullMenusAfterDelay = false;
            this.barManager1.ShowScreenTipsInToolbars = false;
            this.barManager1.ShowShortcutInScreenTips = false;
            this.barManager1.StatusBar = this.bar3;
            this.barManager1.TransparentEditors = true;
            this.barManager1.CloseButtonClick += new System.EventHandler(this.barManager1_CloseButtonClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Stok Giriş";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Canlı Satış";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ürünler";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Günlük Rapor";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Çıkış";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(708, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 253);
            this.barDockControlBottom.Size = new System.Drawing.Size(708, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 229);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(708, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 229);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.ımageCollection1;
            this.simpleButton1.Location = new System.Drawing.Point(279, 43);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(187, 80);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "STOK GİRİŞ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(65, 65);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "1446500636_Generate-tables.png");
            this.ımageCollection1.Images.SetKeyName(1, "1446500332_palet02.png");
            this.ımageCollection1.Images.SetKeyName(2, "1446500622_Product-documentation.png");
            this.ımageCollection1.Images.SetKeyName(3, "1446500680_sales_performance.png");
            // 
            // btn_urunler
            // 
            this.btn_urunler.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunler.Appearance.Options.UseFont = true;
            this.btn_urunler.ImageIndex = 1;
            this.btn_urunler.ImageList = this.ımageCollection1;
            this.btn_urunler.Location = new System.Drawing.Point(501, 43);
            this.btn_urunler.Name = "btn_urunler";
            this.btn_urunler.Size = new System.Drawing.Size(187, 80);
            this.btn_urunler.TabIndex = 5;
            this.btn_urunler.Text = "ÜRÜNLER";
            this.btn_urunler.Click += new System.EventHandler(this.btn_urunler_Click);
            // 
            // btn_rapor
            // 
            this.btn_rapor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rapor.Appearance.Options.UseFont = true;
            this.btn_rapor.ImageIndex = 2;
            this.btn_rapor.ImageList = this.ımageCollection1;
            this.btn_rapor.Location = new System.Drawing.Point(279, 143);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(187, 80);
            this.btn_rapor.TabIndex = 6;
            this.btn_rapor.Text = "GÜNLÜK\r\nRAPOR";
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // btn_canli_satis
            // 
            this.btn_canli_satis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_canli_satis.Appearance.Options.UseFont = true;
            this.btn_canli_satis.ImageIndex = 3;
            this.btn_canli_satis.ImageList = this.ımageCollection1;
            this.btn_canli_satis.Location = new System.Drawing.Point(501, 143);
            this.btn_canli_satis.Name = "btn_canli_satis";
            this.btn_canli_satis.Size = new System.Drawing.Size(187, 80);
            this.btn_canli_satis.TabIndex = 7;
            this.btn_canli_satis.Text = "CANLI \r\nSATIŞ\r\n";
            this.btn_canli_satis.Click += new System.EventHandler(this.btn_canli_satis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "hurdenizyener@gmail.com";
            this.barLargeButtonItem1.Id = 6;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // Xtra_ana_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_canli_satis);
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.btn_urunler);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Xtra_ana_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÜR&STOK TAKİP PROGRAMI 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btn_canli_satis;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.SimpleButton btn_rapor;
        private DevExpress.XtraEditors.SimpleButton btn_urunler;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
    }
}