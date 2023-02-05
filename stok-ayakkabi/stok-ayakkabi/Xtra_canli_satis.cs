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
    public partial class Xtra_canli_satis : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_canli_satis()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stok_takip.accdb");
        DataTable tablo = new DataTable();

        private void Xtra_canli_satis_Load(object sender, EventArgs e)
        {
            grid_doldur();
            boyut();
            isim();
            

        }
        
        public void grid_doldur()
        {

            string sqltext = "select * from stok_satis ";
            OleDbDataAdapter da = new OleDbDataAdapter(sqltext, bag);
            DataSet ds = new DataSet();
            bag.Open();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            bag.Close();


        }
        public void isim()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "REFERANS NO";
            dataGridView1.Columns[2].HeaderText = "ÜRÜN KODU";
            dataGridView1.Columns[3].HeaderText = "ÜRÜN ADI";               
            dataGridView1.Columns[4].HeaderText = "ÜRÜN NUMARASI";
            dataGridView1.Columns[5].HeaderText = "RENK";
            dataGridView1.Columns[6].HeaderText = "ADET";         
            dataGridView1.Columns[7].HeaderText = "SATIŞ FİYATI";
            dataGridView1.Columns[8].HeaderText = "TARİH";


        }
        public void boyut()
        {
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 115;
            dataGridView1.Columns[5].Width = 75;
            dataGridView1.Columns[6].Width = 75;          
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].Width = 110;


        }

        private void txt_referans_no_TextChanged(object sender, EventArgs e)
        {
            if (txt_referans_no.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_satis", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_satis where referans_no like '%" + txt_referans_no.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
        }

        private void txt_urun_kodu_TextChanged(object sender, EventArgs e)
        {
            if (txt_urun_kodu.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_satis", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_satis where urun_kodu like '%" + txt_urun_kodu.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
        }

        private void txt_urun_adi_TextChanged(object sender, EventArgs e)
        {
            if (txt_urun_adi.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_satis", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_satis where urun_adi like '%" + txt_urun_adi.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            Xtra_satis satis = new Xtra_satis(dataGridView1);
            satis.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_stok_gir st = new Xtra_stok_gir();
            st.Owner = this;
            st.Show();
            this.Hide();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_satis_rapor rpr = new Xtra_satis_rapor();
            rpr.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_urunler urun = new Xtra_urunler();
            urun.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}