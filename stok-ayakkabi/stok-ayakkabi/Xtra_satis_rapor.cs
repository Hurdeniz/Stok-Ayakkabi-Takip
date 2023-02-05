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
    public partial class Xtra_satis_rapor : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_satis_rapor()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stok_takip.accdb");
        DataTable tablo = new DataTable();


        private void Xtra_satis_rapor_Load(object sender, EventArgs e)
        {
            grid_doldur();
            boyut();
            isim();
            date_tarih_1.Text = DateTime.Now.ToShortDateString();
            data_toplama();
          
        }

        public void data_toplama()
        {


            double a = 0;
            double b = 0;
           

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                a += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                b += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                

                drop_top_urun.Text = Convert.ToString(a);
                drop_tutar.Text = Convert.ToString(b);
                


            }


        }
        public void grid_doldur()
        {

            string sqltext = "select * from satis_rapor ";
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
            dataGridView1.Columns[8].HeaderText = "TOPLAM TUTAR";
            dataGridView1.Columns[9].HeaderText = "TARİH";


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
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[9].Width = 110;


        }

        private void date_tarih_1_TextChanged(object sender, EventArgs e)
        {
            if (date_tarih_1.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from satis_rapor", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from satis_rapor where tarih like '%" + date_tarih_1.Text + "%' ", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                data_toplama();


            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            date_tarih_1.Text = "";
            data_toplama();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}