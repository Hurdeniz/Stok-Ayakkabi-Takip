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
    public partial class Xtra_stok_gir : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_stok_gir()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stok_takip.accdb");


        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Xtra_stok_gir_Load(object sender, EventArgs e)
        {
            timer1.Start();
            grid_doldur();
            isim();
            boyut();
            data_toplama();
           
            
        }

        public void temizle()
        {
            txt_referans_no.Text = "";
            txt_urun_kodu.Text = "";
            txt_urun_adi.Text = "";
            txt_urun_markasi.Text = "";
            txt_urun_model.Text = "";
            cmb_urun_no.Text = "";
            cmb_urun_renk.Text = "";
            txt_urun_adet.Text = "";
            txt_alis_fiyat.Text = "";
            txt_satis_fiyat.Text = "";
        
        
        
        
        }
        public void kaydet()
        {
            satis_kayit();
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("insert into stok_giris(referans_no,urun_kod,urun_adi,urun_markasi,urun_modeli,urun_numarasi,urun_renk,adet,alis_fiyati,satis_fiyati,tarih) values ('" + txt_referans_no.Text + "','" + txt_urun_kodu.Text + "','" + txt_urun_adi.Text + "','" + txt_urun_markasi.Text + "','" + txt_urun_model.Text + "','"+ cmb_urun_no.Text +"', '"+ cmb_urun_renk.Text +"','"+ txt_urun_adet.Text +"','"+txt_alis_fiyat.Text+"','"+txt_satis_fiyat.Text+"','"+dateEdit1.Text+"')", bag);

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;
            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("kayıt tmm");

            }
            catch
            {

                trans.Rollback();
                XtraMessageBox.Show("Kayıt İşleminiz Yapılmamıştır Lütfen Alanları Kontrol Ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();

            }
            temizle();
            grid_doldur();
            data_toplama();
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
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 135;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 140;
            dataGridView1.Columns[7].Width = 75;
            dataGridView1.Columns[8].Width = 75;
            dataGridView1.Columns[9].Width = 110;
            dataGridView1.Columns[10].Width = 120;
            dataGridView1.Columns[11].Width = 110;


        }
        public void data_toplama()
        {


            double a = 0;
            double b = 0;
            
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                a += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                b += Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);

                drop_toplam_stok.Text = Convert.ToString(a);
                drop_toplam_fiyat.Text = Convert.ToString(b);

                
            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateEdit1.Text = DateTime.Now.ToShortDateString();
        }

        private void simple_btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void txt_urun_markasi_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void satis_kayit()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("insert into stok_satis(referans_no,urun_kodu,urun_adi,urun_numarasi,urun_renk,urun_adet,satis_fiyat,tarih) values ('" + txt_referans_no.Text + "','" + txt_urun_kodu.Text + "','" + txt_urun_adi.Text + "','" + cmb_urun_no.Text + "', '" + cmb_urun_renk.Text + "','" + txt_urun_adet.Text + "','" + txt_satis_fiyat.Text + "','" + dateEdit1.Text + "')", bag);

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;
            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                

            }
            catch
            {

                trans.Rollback();
                XtraMessageBox.Show("Kayıt İşleminiz Yapılmamıştır Lütfen Alanları Kontrol Ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();

            }
            
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_canli_satis sat = new Xtra_canli_satis();
            sat.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_urunler urun = new Xtra_urunler();
            urun.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_satis_rapor rp = new Xtra_satis_rapor();
            rp.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


    }
}