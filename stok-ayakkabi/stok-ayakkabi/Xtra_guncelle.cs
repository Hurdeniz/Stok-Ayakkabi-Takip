using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace stok_ayakkabi
{
    public partial class Xtra_guncelle : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_guncelle(DataGridView dataax)
        {
            InitializeComponent();
            dt = dataax;
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stok_takip.accdb");
        DataTable tablo = new DataTable();
        DataGridView dt = new DataGridView();
        private void Xtra_guncelle_Load(object sender, EventArgs e)
        {
            data();
        }

        public void data()
        {
            txt_id.Text = dt.CurrentRow.Cells[0].Value.ToString();
            txt_referans_no.Text=dt.CurrentRow.Cells[1].Value.ToString();
            txt_urun_kodu.Text = dt.CurrentRow.Cells[2].Value.ToString();
            txt_urun_adi.Text = dt.CurrentRow.Cells[3].Value.ToString();
            txt_urun_markasi.Text = dt.CurrentRow.Cells[4].Value.ToString();
            txt_urun_model.Text = dt.CurrentRow.Cells[5].Value.ToString();
            cmb_urun_no.Text = dt.CurrentRow.Cells[6].Value.ToString();
            cmb_urun_renk.Text = dt.CurrentRow.Cells[7].Value.ToString();
            txt_urun_adet.Text = dt.CurrentRow.Cells[8].Value.ToString();
            txt_alis_fiyat.Text = dt.CurrentRow.Cells[9].Value.ToString();
            txt_satis_fiyat.Text = dt.CurrentRow.Cells[10].Value.ToString();
            dateEdit1.Text = dt.CurrentRow.Cells[11].Value.ToString();
                                                      
        }
        

        private void simple_btn_kaydet_Click(object sender, EventArgs e)
        {

        }
    }
}