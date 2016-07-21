using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webEntityOkul
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OKULEntities ent = new OKULEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllSiniflar();
                GetAllOgrencilerBySinifID(Convert.ToInt32(ddlSinifler.SelectedValue));
            }
        }

        private void GetAllSiniflar()
        {
            var Siniflar = (from s in ent.Siniflar
                            select s).ToList();
            ddlSinifler.DataSource = Siniflar;
            ddlSinifler.DataBind();
        }

        protected void ddlSinifler_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllOgrencilerBySinifID(Convert.ToInt32(ddlSinifler.SelectedValue));
        }

        private void GetAllOgrencilerBySinifID(int id)
        {
            var ogrenciler = (from o in ent.Ogrenciler
                              where o.SinifID == id
                              select o).ToList();
            gvOgrenciler.DataSource = ogrenciler;
            gvOgrenciler.DataBind();
        }

        protected void lbEkle_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            btnDegistir.Enabled = true;
            Temizle();

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (OgrenciKontrol())
            {
                lblMesaj.Text = "Öğrenci zaten kayıtlı";
                txtAd.Focus();
            }
            else
            {
                Ogrenciler ogr = new Ogrenciler();
                ogr.Ad = txtAd.Text;
                ogr.Soyad = txtSoyad.Text;
                ogr.Telefon = txtTelefon.Text;
                ogr.Adres = txtAdres.Text;
                ogr.TCKimlikNo = txtTcNo.Text;
                ogr.TaksitSayisi = Convert.ToByte(txtTaksit.Text);
                ogr.TaksitTutari = Convert.ToDecimal(txtTutar.Text);
                ogr.SinifID = Convert.ToInt32(ddlSinifler.SelectedValue);
                ent.Ogrenciler.Add(ogr);
                try
                {
                    ent.SaveChanges();
                    GetAllOgrencilerBySinifID(Convert.ToInt32(ddlSinifler.SelectedValue));
                    btnKaydet.Enabled = false;
                    Temizle();

                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
        }

        private bool OgrenciKontrol()
        {      
            int sayisi = (from o in ent.Ogrenciler
                          where o.Ad == txtAd.Text && o.Soyad == txtSoyad.Text
                          select o).Count();
            return Convert.ToBoolean(sayisi);       
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtAd.Text = "";
            txtTcNo.Text = "";
            txtTaksit.Text = "1";
            txtTutar.Text = "0";
            txtAd.Focus();
            txtAdres.Text = "";
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            int degisenID = Convert.ToInt32(lblOgrenciID.Text);
            var degisen = (from d in ent.Ogrenciler  
                           where d.ID == degisenID
                           select d).FirstOrDefault();
            degisen.Ad = txtAd.Text;
            degisen.Soyad = txtSoyad.Text;
            degisen.Telefon = txtTelefon.Text;
            degisen.Adres = txtAdres.Text;
            degisen.TaksitSayisi = Convert.ToByte(txtTaksit.Text);
            degisen.TaksitTutari = Convert.ToDecimal(txtTutar.Text);
            degisen.TCKimlikNo = txtTcNo.Text;
            try
            {
                ent.SaveChanges();
                GetAllOgrencilerBySinifID(Convert.ToInt32(ddlSinifler.SelectedValue));
                btnKaydet.Enabled = false;
                btnDegistir.Enabled = false;
                btnDegistir.Enabled = false;
                lblMesaj.Text = "Ogrenci Değiştirildi";
                Temizle();

            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int silinenID = Convert.ToInt32(lblOgrenciID.Text);
            var silinen = (from s in ent.Ogrenciler
                           where s.ID == silinenID
                           select s).FirstOrDefault();
            ent.Ogrenciler.Remove(silinen);
            try
            {
                ent.SaveChanges();
                GetAllOgrencilerBySinifID(Convert.ToInt32(ddlSinifler.SelectedValue));
                lblMesaj.Text = "Ogrenci Silindi";
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
                Temizle();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }

        protected void gvOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            lblOgrenciID.Text = gvOgrenciler.SelectedValue.ToString();
            txtAd.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[2].Text);
            txtSoyad.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[3].Text);
            txtTelefon.Text = gvOgrenciler.SelectedRow.Cells[4].Text;
            txtAdres.Text = HttpUtility.HtmlDecode(gvOgrenciler.SelectedRow.Cells[5].Text);
            txtTcNo.Text = gvOgrenciler.SelectedRow.Cells[7].Text;
            txtTaksit.Text = gvOgrenciler.SelectedRow.Cells[8].Text;
            txtTutar.Text = gvOgrenciler.SelectedRow.Cells[9].Text;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
        }
    }
}