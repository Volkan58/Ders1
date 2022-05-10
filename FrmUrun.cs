using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var Urn = db.TblUrun.ToList();
            dataGridView1.DataSource=Urn;



        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblUrun t = new TblUrun();
            t.UrunAd=TxtUrun.Text;
            t.UrunMarka=TxtUrun.Text;
            t.UrunStok=short.Parse(TxtStok.Text);
            t.Kategori=int.Parse(CmbKategori.SelectedValue.ToString());
            t.UrunFiyat=decimal.Parse(TxtFiyat.Text);
            t.Durum=true;
            db.TblUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Eklendi");


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtİd.Text);

            var urun = db.TblUrun.Find(x);
            db.TblUrun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");



        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtİd.Text);

            var urun = db.TblUrun.Find(x);
            urun.UrunAd=TxtUrun.Text;
            urun.UrunStok=short.Parse(TxtStok.Text);
            urun.UrunMarka=TxtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");




        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TblKategori select new { x.Kategoriİd, x.KategoriAd }).ToList();
            CmbKategori.ValueMember="Kategoriİd";
            CmbKategori.DisplayMember="KategoriAd";
            CmbKategori.DataSource=kategoriler;



        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
