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
    public partial class Xtra_satis : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_satis(DataGridView dataax)
        {
            InitializeComponent();
            dt = dataax;
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stok_takip.accdb");
        DataTable tablo = new DataTable();
        DataGridView dt = new DataGridView();

        private void Xtra_satis_Load(object sender, EventArgs e)
        {
            textEdit1.Text = dt.CurrentRow.Cells[0].Value.ToString();
            drop_referans.Text = dt.CurrentRow.Cells[1].Value.ToString();
            drop_kod.Text = dt.CurrentRow.Cells[2].Value.ToString();
            drop_adi.Text = dt.CurrentRow.Cells[3].Value.ToString();
            drop_numara.Text = dt.CurrentRow.Cells[4].Value.ToString();
            drop_renk.Text = dt.CurrentRow.Cells[5].Value.ToString();            
            txt_satis_fiyat.Text = dt.CurrentRow.Cells[7].Value.ToString();
            txt_tutar.Text = dt.CurrentRow.Cells[7].Value.ToString();
            timer1.Start();
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateEdit1.Text = DateTime.Now.ToShortDateString();
        }
        public void kaydet()
        {
            satis_rapor();

            double a, b;
            a = double.Parse(dt.CurrentRow.Cells[6].Value.ToString());
            b = (a - Convert.ToDouble(spin_adet.Text));
            spin_adet.Text = b.ToString();

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update stok_satis Set urun_adet = @adet Where id=@id", bag);
            kmt.Parameters.Add("@adet", OleDbType.VarChar).Value = spin_adet.Text;
            kmt.Parameters.Add("@id", OleDbType.VarChar).Value = textEdit1.Text;
            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;
            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("SATIŞ İŞLEMİ GERÇEKLEŞMİŞTİR  ", "SATIŞ BAŞARILI", MessageBoxButtons.OK);
            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("Satış İşlemi Gerçekleştirilememiştir Lütfen Tekrar Deneyiniz veya Kontrol Ediniz ", "SATIŞ BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();

            }
            
            grid_doldur();
        
        
        
        
        }
        public void satis_rapor()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("insert into satis_rapor(referans_no,urun_kodu,urun_adi,urun_numarasi,urun_renk,urun_adet,satis_fiyat,toplam_tutar,tarih) values ('" + drop_referans.Text + "','" + drop_kod.Text + "','" + drop_adi.Text + "','" + drop_numara.Text + "', '" + drop_renk.Text + "','" + spin_adet.Text + "','" + txt_satis_fiyat.Text + "','"+txt_tutar.Text+"','" + dateEdit1.Text + "')", bag);

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
                

            }
            finally
            {
                bag.Close();

            }
            
        }
            



        public void grid_doldur()
        {

            string sqltext = "select * from stok_satis ";
            OleDbDataAdapter da = new OleDbDataAdapter(sqltext, bag);
            DataSet ds = new DataSet();
            bag.Open();

            da.Fill(ds);

            dt.DataSource = ds.Tables[0];

            bag.Close();


        }

        private void btn_satis_bitir_Click(object sender, EventArgs e)
        {
            kaydet();
            this.Close();
        }
        double a, b;
        double sonuc;
        private void btn_hesap_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(spin_adet.Text);
            b = Convert.ToDouble(txt_satis_fiyat.Text);
            sonuc = a * b;

            txt_tutar.Text = Convert.ToString(sonuc);
        }


    }
}