using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfOKULAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=WISSEN46\\MSSQLYAZ8;Initial Catalog=OKUL;user id=sa;pwd=123458");

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SiniflariGetir(cbSiniflar);
        }

        private void SiniflariGetir(ComboBox siniflar)
        {
            SqlCommand comm = new SqlCommand("Select * from Siniflar",conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();                              
                    while (dr.Read())
                    {
                        siniflar.Items.Add(dr[1].ToString());                      
                    }
                    dr.Close();
                
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }                      
        }

        private void cbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrecileriGetir(cbSiniflar, lvOgrenciler);
        }

        private void OgrecileriGetir(ComboBox siniflar, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select Ad,Soyad,Telefon,Adres,SinifAd,Ogrenciler.ID from Ogrenciler inner join Siniflar on Ogrenciler.sinifID=Siniflar.ID where SinifAd=@SinifAd", conn);
            comm.Parameters.Add("@SinifAd", SqlDbType.VarChar).Value = siniflar.SelectedItem.ToString();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());

                    i++;

                }
                dr.Close();

            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }                      
        }
    }
}
