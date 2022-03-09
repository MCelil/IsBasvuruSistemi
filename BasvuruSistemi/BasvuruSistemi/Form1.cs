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

namespace BasvuruSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Data Source=MERTBAHSI;Initial Catalog=DbBasvuruSistemi;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=MERTBAHSI;Initial Catalog=DbBasvuruSistemi;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBasvuruSistemiDataSet.TBL_BASVURU' table. You can move, or remove it, as needed.
            this.tBL_BASVURUTableAdapter.Fill(this.dbBasvuruSistemiDataSet.TBL_BASVURU);

            



        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_BASVURU (BASVURULANPOZISYON,ADSOYAD,DOGUMYERI,DOGUMTARIHI,TCKIMLIKNO,CINSIYET,MEDENIDURUM,UYRUK,ADRES,EVTELEFONU,CEPTELEFONU,MAILADRESI,SURUCUBELGESI,SURUCUBELGESINIFI,ASKERLIKDURUMU,SIGARADURUMU,RAHATSIZLIKDURUMU,SABIKAKAYDI,SABIKAKAYDISEBEBI,UCRETTALEBI,EGITIMBILGILERI,BOLUM,ISTECRUBE1,ISTECRUBE2,ISTECRUBE3,REFERANS1,REFERANS2,REFERANS3,OZELDURUM1,OZELDURUM2,BASVURUTARIHI) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20,@P21,@P22,@P23,@P24,@P25,@P26,@P27,@P28,@P29,@P30,@P31)",baglanti);
            komut.Parameters.AddWithValue("@P1",basvurulanPozisyonText.Text);
            komut.Parameters.AddWithValue("@P2", adSoyadText.Text);
            komut.Parameters.AddWithValue("@P3", dogumYeriText.Text);
            komut.Parameters.AddWithValue("@P4", dogumTarihiText.Text);
            komut.Parameters.AddWithValue("@P5", tcNoText.Text);
            
            if (erkekButton.Checked)
            {
                komut.Parameters.AddWithValue("@P6", "True");
            }else
                komut.Parameters.AddWithValue("@P6", "False");
            
            komut.Parameters.AddWithValue("@P7", medeniDurumText.Text);
            komut.Parameters.AddWithValue("@P8", uyrukText.Text);
            komut.Parameters.AddWithValue("@P9", adresText.Text);
            komut.Parameters.AddWithValue("@P10", evTelText.Text);
            komut.Parameters.AddWithValue("@P11", cepTelText.Text);
            komut.Parameters.AddWithValue("@P12", mailText.Text);

            if (surucuEvetButton.Checked)
            {
                komut.Parameters.AddWithValue("@P13", "True");
            }else
                komut.Parameters.AddWithValue("@P13", "False");

            komut.Parameters.AddWithValue("@P14", surucuBelgeText.Text);
            komut.Parameters.AddWithValue("@P15", askerlikText.Text);
            
            if (sigaraVarButton.Checked)
            {
                komut.Parameters.AddWithValue("@P16", "True");
            }else
                komut.Parameters.AddWithValue("@P16", "False");
            
            komut.Parameters.AddWithValue("@P17", rahatsizlikText.Text);

            if (sabikaVarButton.Checked)
            {
                komut.Parameters.AddWithValue("@P18", "True");
            }else
                komut.Parameters.AddWithValue("@P18", "False");

            komut.Parameters.AddWithValue("@P19", sabikaText.Text);
            komut.Parameters.AddWithValue("@P20", ucretText.Text);
            komut.Parameters.AddWithValue("@P21", egitimText.Text);
            komut.Parameters.AddWithValue("@P22", egitimBolumText.Text);
            komut.Parameters.AddWithValue("@P23", isTecrube1Text.Text);
            komut.Parameters.AddWithValue("@P24", isTecrube2Text.Text);
            komut.Parameters.AddWithValue("@P25", isTecrube3Text.Text);
            komut.Parameters.AddWithValue("@P26", referans1Text.Text);
            komut.Parameters.AddWithValue("@P27", referans2Text.Text);
            komut.Parameters.AddWithValue("@P28", referans3Text.Text);
            
            if (ozelDurum1VarBtn.Checked)
            {
                komut.Parameters.AddWithValue("@P29", "True");
            }else
                komut.Parameters.AddWithValue("@P29", "False");

            if (ozelDurum2VarBtn.Checked)
            {
                komut.Parameters.AddWithValue("@P30", "True");
            }else
                komut.Parameters.AddWithValue("@P30", "False");

            komut.Parameters.AddWithValue("@P31", basvuruTarihText.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sisteme kayıt yapıldı");
            this.tBL_BASVURUTableAdapter.Fill(this.dbBasvuruSistemiDataSet.TBL_BASVURU);

            dogumTarihiText.Clear();
            ucretText.Clear();
            basvuruTarihText.Clear();
            clearTextbox();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            for (int i = 0; i < 32; i++)
            {
                if (dataGridView1.Rows[secilen].Cells[i].Value.ToString() == "")
                {
                    return;
                }
            }

            IDtext.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            basvurulanPozisyonText.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adSoyadText.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dogumYeriText.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dogumTarihiText.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tcNoText.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[6].Value.ToString() == "True")
            {
                erkekButton.Select();
            }
            else
            {
                kadinButton.Select();
            }
            medeniDurumText.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            uyrukText.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            adresText.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            evTelText.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            cepTelText.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            mailText.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[13].Value.ToString() == "True")
            {
                surucuEvetButton.Select();
            }
            else
            {
                surucuHayirText.Select();
            }
            surucuBelgeText.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            askerlikText.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[16].Value.ToString() == "True")
            {
                sigaraVarButton.Select();
            }
            else
            {
                sigaraYokText.Select();
            }
            rahatsizlikText.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[18].Value.ToString() == "True")
            {
                sabikaVarButton.Select();
            }
            else
            {
                sabikaYokButton.Select();
            }
            sabikaText.Text = dataGridView1.Rows[secilen].Cells[19].Value.ToString();
            ucretText.Text = dataGridView1.Rows[secilen].Cells[20].Value.ToString();
            egitimText.Text = dataGridView1.Rows[secilen].Cells[21].Value.ToString();
            egitimBolumText.Text = dataGridView1.Rows[secilen].Cells[22].Value.ToString();
            isTecrube1Text.Text = dataGridView1.Rows[secilen].Cells[23].Value.ToString();
            isTecrube2Text.Text = dataGridView1.Rows[secilen].Cells[24].Value.ToString();
            isTecrube3Text.Text = dataGridView1.Rows[secilen].Cells[25].Value.ToString();
            referans1Text.Text = dataGridView1.Rows[secilen].Cells[26].Value.ToString();
            referans2Text.Text = dataGridView1.Rows[secilen].Cells[27].Value.ToString();
            referans3Text.Text = dataGridView1.Rows[secilen].Cells[28].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[29].Value.ToString() == "True")
            {
                ozelDurum1VarBtn.Select();
            }
            else
            {
                ozelDurum1YokBtn.Select();
            }
            if (dataGridView1.Rows[secilen].Cells[30].Value.ToString()=="True")
            {
                ozelDurum2VarBtn.Select();
            }
            else
            {
                ozelDurum2YokBtn.Select();
            }
            basvuruTarihText.Text = dataGridView1.Rows[secilen].Cells[31].Value.ToString();

            
            
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            if (IDtext.Text == "")
            {
                MessageBox.Show("ID bulunamadı");
                return;
            }

            baglanti.Open();
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "update TBL_BASVURU set BASVURULANPOZISYON=@P1,ADSOYAD=@P2,DOGUMYERI=@P3,DOGUMTARIHI=@P4,TCKIMLIKNO=@P5,CINSIYET=@P6,MEDENIDURUM=@P7,UYRUK=@P8,ADRES=@P9,EVTELEFONU=@P10,CEPTELEFONU=@P11,MAILADRESI=@P12,SURUCUBELGESI=@P13,SURUCUBELGESINIFI=@P14,ASKERLIKDURUMU=@P15,SIGARADURUMU=@P16,RAHATSIZLIKDURUMU=@P17,SABIKAKAYDI=@P18,SABIKAKAYDISEBEBI=@P19,UCRETTALEBI=@P20,EGITIMBILGILERI=@P21,BOLUM=@P22,ISTECRUBE1=@P23,ISTECRUBE2=@P24,ISTECRUBE3=@P25,REFERANS1=@P26,REFERANS2=@P27,REFERANS3=@P28,OZELDURUM1=@P29,OZELDURUM2=@P30,BASVURUTARIHI=@P31 WHERE ID=@P32";
            komut.Parameters.AddWithValue("@P1", basvurulanPozisyonText.Text);
            komut.Parameters.AddWithValue("@P2", adSoyadText.Text);
            komut.Parameters.AddWithValue("@P3", dogumYeriText.Text);
            komut.Parameters.AddWithValue("@P4", dogumTarihiText.Text);
            komut.Parameters.AddWithValue("@P5", tcNoText.Text);

            if (erkekButton.Checked)
            {
                komut.Parameters.AddWithValue("@P6", "True");
            }
            else
                komut.Parameters.AddWithValue("@P6", "False");

            komut.Parameters.AddWithValue("@P7", medeniDurumText.Text);
            komut.Parameters.AddWithValue("@P8", uyrukText.Text);
            komut.Parameters.AddWithValue("@P9", adresText.Text);
            komut.Parameters.AddWithValue("@P10", evTelText.Text);
            komut.Parameters.AddWithValue("@P11", cepTelText.Text);
            komut.Parameters.AddWithValue("@P12", mailText.Text);

            if (surucuEvetButton.Checked)
            {
                komut.Parameters.AddWithValue("@P13", "True");
            }
            else
                komut.Parameters.AddWithValue("@P13", "False");

            komut.Parameters.AddWithValue("@P14", surucuBelgeText.Text);
            komut.Parameters.AddWithValue("@P15", askerlikText.Text);

            if (sigaraVarButton.Checked)
            {
                komut.Parameters.AddWithValue("@P16", "True");
            }
            else
                komut.Parameters.AddWithValue("@P16", "False");

            komut.Parameters.AddWithValue("@P17", rahatsizlikText.Text);

            if (sabikaVarButton.Checked)
            {
                komut.Parameters.AddWithValue("@P18", "True");
            }
            else
                komut.Parameters.AddWithValue("@P18", "False");

            komut.Parameters.AddWithValue("@P19", sabikaText.Text);
            komut.Parameters.AddWithValue("@P20", ucretText.Text);
            komut.Parameters.AddWithValue("@P21", egitimText.Text);
            komut.Parameters.AddWithValue("@P22", egitimBolumText.Text);
            komut.Parameters.AddWithValue("@P23", isTecrube1Text.Text);
            komut.Parameters.AddWithValue("@P24", isTecrube2Text.Text);
            komut.Parameters.AddWithValue("@P25", isTecrube3Text.Text);
            komut.Parameters.AddWithValue("@P26", referans1Text.Text);
            komut.Parameters.AddWithValue("@P27", referans2Text.Text);
            komut.Parameters.AddWithValue("@P28", referans3Text.Text);

            if (ozelDurum1VarBtn.Checked)
            {
                komut.Parameters.AddWithValue("@P29", "True");
            }
            else
                komut.Parameters.AddWithValue("@P29", "False");

            if (ozelDurum2VarBtn.Checked)
            {
                komut.Parameters.AddWithValue("@P30", "True");
            }
            else
                komut.Parameters.AddWithValue("@P30", "False");

            komut.Parameters.AddWithValue("@P31", basvuruTarihText.Text);
            komut.Parameters.AddWithValue("@P32", IDtext.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarılı");
           this.tBL_BASVURUTableAdapter.Fill(this.dbBasvuruSistemiDataSet.TBL_BASVURU);

            dogumTarihiText.Clear();
            ucretText.Clear();
            basvuruTarihText.Clear();
            clearTextbox();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (IDtext.Text == "")
            {
                MessageBox.Show("ID bulunamadı");
                return;
            }
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TBL_BASVURU WHERE ID = @P32",baglanti);
            komut.Parameters.AddWithValue("@P32", IDtext.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarılı");
            this.tBL_BASVURUTableAdapter.Fill(this.dbBasvuruSistemiDataSet.TBL_BASVURU);

            dogumTarihiText.Clear();
            ucretText.Clear();
            basvuruTarihText.Clear();
            clearTextbox();
        }

        private void textEdit18_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBL_BASVURU where ADSOYAD like '%" + textEdit18.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void clearTextbox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
                {
                    foreach (Control control in controls)
                    {
                        if (control is TextBox)
                        {
                            (control as TextBox).Clear();
                        }
                        else
                        {
                            func(control.Controls);
                        }
                    }
                };
            func(Controls);
        }
    }
}
