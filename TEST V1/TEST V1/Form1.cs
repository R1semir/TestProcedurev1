using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.SqlClient;

namespace TEST_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJO2DGU\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
     
      

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Execute HAREKETLER",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //   CREATE PROCEDURE Hareketler
            //      AS
            //         BEGIN
            //  SELECT HAREKETID, URUNAD as 'ÜRÜN ADI',(AD + ' ' + SOYAD) as'MÜŞTERİ', ADSOYAD as'Personel Adı Soyadı', TBLHAREKET.FIYAT as 'ÜRÜN FİYATI'
            //from TBLHAREKET
            // inner join TBLURUNLER on TBLHAREKET.URUN = TBLURUNLER.URUNID
            //inner join TBLMUSTERI on TBLHAREKET.MUSTERI = TBLMUSTERI.ID
            // inner join TBLPERSONEL on TBLHAREKET.PERSONEL = TBLPERSONEL.ID
              // END;

        }
    }
}
