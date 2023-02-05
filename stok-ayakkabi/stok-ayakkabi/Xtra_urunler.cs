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
    public partial class Xtra_urunler : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_urunler()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stok_takip.accdb");
        DataTable tablo = new DataTable();
        private void Xtra_urunler_Load(object sender, EventArgs e)
        {
            grid_doldur();
            isim();
            boyut();
            data_toplama();
        }
        public void data_toplama()
        {


            double a = 0;
            double b = 0;
            double c = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                a += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                b += Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);
                c += Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);

                drop_toplam_stok.Text = Convert.ToString(a);
                drop_alis.Text = Convert.ToString(b);
                drop_satis.Text = Convert.ToString(c);


            }


        }
        public void grid_doldur()
        {

            string sqltext = "select * from stok_giris ";
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
            dataGridView1.Columns[4].HeaderText = "ÜRÜN MARKASI";
            dataGridView1.Columns[5].HeaderText = "ÜRÜN MODELİ";
            dataGridView1.Columns[6].HeaderText = "ÜRÜN NUMARASI";
            dataGridView1.Columns[7].HeaderText = "RENK";
            dataGridView1.Columns[8].HeaderText = "ADET";
            dataGridView1.Columns[9].HeaderText = "ALIŞ FİYATI";
            dataGridView1.Columns[10].HeaderText = "SATIŞ FİYATI";
            dataGridView1.Columns[11].HeaderText = "TARİH";


        }
        public void boyut()
        {
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 115;
            dataGridView1.Columns[5].Width = 105;
            dataGridView1.Columns[6].Width = 115;
            dataGridView1.Columns[7].Width = 75;
            dataGridView1.Columns[8].Width = 75;
            dataGridView1.Columns[9].Width = 110;
            dataGridView1.Columns[10].Width = 120;
            dataGridView1.Columns[11].Width = 110;


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult cevap;
            cevap = MessageBox.Show(" Kayıtı Silmek İstediğinizden Emin Misiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("delete from stok_giris where id=" + a + " ", bag);
                kmt.ExecuteNonQuery();
                bag.Close();
                XtraMessageBox.Show("KAYIT BAŞARIYLA SİLİNMİŞTİR :) ", "BAŞARILI", MessageBoxButtons.OK);
            }
            
           
           
            grid_doldur();
            data_toplama();
        }

        private void txt_referans_no_TextChanged(object sender, EventArgs e)
        {
            if (txt_referans_no.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_giris", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_giris where referans_no like '%" + txt_referans_no.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                


            }
        }

        private void txt_urun_kodu_TextChanged(object sender, EventArgs e)
        {
            if (txt_urun_kodu.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_giris", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_giris where urun_kodu like '%" + txt_urun_kodu.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
        }

        private void txt_urun_adi_TextChanged(object sender, EventArgs e)
        {
            if (txt_urun_adi.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_giris", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from stok_giris where urun_adi like '%" + txt_urun_adi.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_stok_gir stok = new Xtra_stok_gir();
            stok.Owner = this;
            stok.Show(); 
            this.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_canli_satis satis = new Xtra_canli_satis();
            satis.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_satis_rapor rapor = new Xtra_satis_rapor();
            rapor.Owner = this;
            rapor.Show();
            this.Hide();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_bilgi_Click(object sender, EventArgs e)
        {
            Xtra_guncelle bilgi = new Xtra_guncelle(dataGridView1);
            bilgi.Show();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook satis_rapor = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)satis_rapor.Sheets[1];
            Microsoft.Office.Interop.Excel.Range adi = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, 2];


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 3, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;

                }

            }
        }
    }
}