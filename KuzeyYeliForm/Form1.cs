using KuzeyYeliEntity;
using KuzeyYeliORM;
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

namespace KuzeyYeliForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kategori k = new Kategori();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =Urunler.Listele();
            cbkategoriler.DataSource = Kategoriler.KategoriListele();
            cbkategoriler.DisplayMember = "KategoriAdi";
            cbkategoriler.ValueMember = "KategoriID";

            cbtedarikciler.DataSource = Tedarikciler.TedarikciListele();
            cbtedarikciler.DisplayMember = "TedarikçiAdi";
            cbtedarikciler.ValueMember = "TedarikciID";
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            k.Show();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAdi = txturunad.Text;
            u.Stok = (int)nmdstok.Value;
            u.Fiyat =nmdfiyat.Value;
            u.KategoriID = (int)cbkategoriler.SelectedValue;
            u.TedarikciID = (int)cbtedarikciler.SelectedValue;
            bool sonuc=Urunler.Ekle(u);
            if (sonuc==true)
            {
                MessageBox.Show("Kayıt Eklendi!!");
                dataGridView1.DataSource = Urunler.Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi!!");
            }
        }
    }
}
