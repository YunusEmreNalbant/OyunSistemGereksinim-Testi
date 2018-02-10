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

namespace OyunSistemGereksinim
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        int toplam, puan1, puan2, puan3, sistempuani;


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet7.Tbl_Bellekler' table. You can move, or remove it, as needed.
            this.tbl_BelleklerTableAdapter1.Fill(this.oyunSistemGereksinimDataSet7.Tbl_Bellekler);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet6.Tbl_EkranKartlari' table. You can move, or remove it, as needed.
            this.tbl_EkranKartlariTableAdapter1.Fill(this.oyunSistemGereksinimDataSet6.Tbl_EkranKartlari);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet5.Tbl_İslemciler' table. You can move, or remove it, as needed.
            this.tbl_İslemcilerTableAdapter1.Fill(this.oyunSistemGereksinimDataSet5.Tbl_İslemciler);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet4.Tbl_EkranKartlari' table. You can move, or remove it, as needed.
            this.tbl_EkranKartlariTableAdapter.Fill(this.oyunSistemGereksinimDataSet4.Tbl_EkranKartlari);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet3.Tbl_OyunListe' table. You can move, or remove it, as needed.
            this.tbl_OyunListeTableAdapter1.Fill(this.oyunSistemGereksinimDataSet3.Tbl_OyunListe);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet2.Tbl_Bellekler' table. You can move, or remove it, as needed.
            this.tbl_BelleklerTableAdapter.Fill(this.oyunSistemGereksinimDataSet2.Tbl_Bellekler);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet1.Tbl_İslemciler' table. You can move, or remove it, as needed.
            this.tbl_İslemcilerTableAdapter.Fill(this.oyunSistemGereksinimDataSet1.Tbl_İslemciler);
            // TODO: This line of code loads data into the 'oyunSistemGereksinimDataSet.Tbl_OyunListe' table. You can move, or remove it, as needed.
            this.tbl_OyunListeTableAdapter.Fill(this.oyunSistemGereksinimDataSet.Tbl_OyunListe);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {      
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtOyunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSistemPuan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen2 = dataGridView2.SelectedCells[0].RowIndex;
            Txtİslemciid.Text = dataGridView2.Rows[secilen2].Cells[0].Value.ToString();
            Txtİslemci.Text = dataGridView2.Rows[secilen2].Cells[1].Value.ToString();
            TxtİslemciSinif.Text= dataGridView2.Rows[secilen2].Cells[3].Value.ToString();
            TxtİslemciPuan.Text = dataGridView2.Rows[secilen2].Cells[2].Value.ToString();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen3 = dataGridView4.SelectedCells[0].RowIndex;
            TxtEkranİd.Text = dataGridView4.Rows[secilen3].Cells[0].Value.ToString();
            TxtEkran.Text = dataGridView4.Rows[secilen3].Cells[1].Value.ToString();
            TxtEkranSinif.Text= dataGridView4.Rows[secilen3].Cells[3].Value.ToString();
            TxtEkranPuan.Text= dataGridView4.Rows[secilen3].Cells[2].Value.ToString();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen4 = dataGridView3.SelectedCells[0].RowIndex;
            TxtRamİd.Text = dataGridView3.Rows[secilen4].Cells[0].Value.ToString();
            TxtRam.Text = dataGridView3.Rows[secilen4].Cells[1].Value.ToString();
            TxtRamSinif.Text= dataGridView3.Rows[secilen4].Cells[3].Value.ToString();
            TxtRamPuan.Text= dataGridView3.Rows[secilen4].Cells[2].Value.ToString();
        }

        private void BtnCalistir_Click(object sender, EventArgs e)
        {
            puan1 = Convert.ToInt16(TxtİslemciPuan.Text);
            puan2 = Convert.ToInt16(TxtEkranPuan.Text);
            puan3 = Convert.ToInt16(TxtRamPuan.Text);

            toplam = (puan1 + puan2 + puan3);
            sistempuani = Convert.ToInt32(TxtSistemPuan.Text);


            if (sistempuani <= toplam && (TxtİslemciSinif.Text == "4" || TxtİslemciSinif.Text == "3" || TxtİslemciSinif.Text == "2" || TxtİslemciSinif.Text == "1") && (TxtEkranSinif.Text=="3" || TxtEkranSinif.Text == "2" || TxtEkranSinif.Text == "1") && (TxtRamSinif.Text == "3" || TxtRamSinif.Text == "2" || TxtRamSinif.Text == "1"))
                 
            {
                pictureBox1.Visible = true;
           
                

                MessageBox.Show("Oyunu sisteminizde rahatlıkla oynayabilirsiniz. İyi Oyunlar!");

            }
            
            else if(sistempuani>toplam && (TxtİslemciSinif.Text == "4" || TxtİslemciSinif.Text == "3" || TxtİslemciSinif.Text == "2" || TxtİslemciSinif.Text == "1") && (TxtEkranSinif.Text == "3" || TxtEkranSinif.Text == "2" || TxtEkranSinif.Text == "1") && (TxtRamSinif.Text == "3" || TxtRamSinif.Text == "2" || TxtRamSinif.Text == "1"))
            {
                pictureBox4.Visible = true;
                MessageBox.Show("Oyunu sisteminizde orta grafik ayarlarında oynayabilirsiniz. İyi Oyunlar!");
            }

            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label19.Visible = true;

                MessageBox.Show("Oyun sisteminiz için yeterli değil.");
            }
        }
    }
}
