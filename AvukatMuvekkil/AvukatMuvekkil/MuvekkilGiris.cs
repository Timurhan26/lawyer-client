using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class MuvekkilGiris : Form
    {
        public MuvekkilGiris()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MuvekkilGiris_Load(object sender, EventArgs e)
        {
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtEposta.Text.Trim() == "" && txtSifre.Text.Trim() == "")
            {
                MessageBox.Show("Alanları Boş bırakmayınız");
            }

            else
            {
                string query = "SELECT * FROM MuvekkilBilgileri WHERE MuvekkilEposta=@ad AND MuvekkilSifre=@sifre";

                Baglan.con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);
                cmd.Parameters.AddWithValue("@ad", txtEposta.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MuvekkilAnaSayfa fr = new MuvekkilAnaSayfa();
                    fr.kulAd = txtEposta.Text;
                    fr.ePosta = txtSifre.Text;
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Eposta veya Şifre hatalı");
                }
                Baglan.con.Close();
            }
        }
    }
}
