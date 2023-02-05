using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace stok_ayakkabi
{
    public partial class Xtra_ana_form : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_ana_form()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Xtra_stok_gir stok = new Xtra_stok_gir();
            stok.Show();
        }

        private void barManager1_CloseButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
            Xtra_urunler urun = new Xtra_urunler();
            urun.Show();
        }

        private void btn_canli_satis_Click(object sender, EventArgs e)
        {
            Xtra_canli_satis satis = new Xtra_canli_satis();
            satis.Show();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            Xtra_satis_rapor rapor = new Xtra_satis_rapor();
            rapor.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_stok_gir gir = new Xtra_stok_gir();
            gir.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_canli_satis canli = new Xtra_canli_satis();
            canli.Show();

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_urunler urun = new Xtra_urunler();
            urun.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_satis_rapor rapor = new Xtra_satis_rapor();
            rapor.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}