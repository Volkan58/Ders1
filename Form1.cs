﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db=new DbEntityUrunEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TblKategori.ToList();
            dataGridView1.DataSource=kategoriler;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblKategori t=new TblKategori();
            t.KategoriAd=textBox2.Text;
            db.TblKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("kategori Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(textBox1.Text);
            var ktg = db.TblKategori.Find(x);
            db.TblKategori.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Silindi");




        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktg = db.TblKategori.Find(x);
            ktg.KategoriAd=textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Tamam");


        }
    }
}
