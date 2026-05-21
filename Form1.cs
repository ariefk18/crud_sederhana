using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace crud
{
    public partial class Form1 : Form
    {
        Koneksi konek = new Koneksi();
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            TampilData();
        }

        void TampilData() //fungsi menampilkan data ke DGV
        {
            using (MySqlConnection conn = konek.GetConn())
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("Select * from barang", conn);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvData.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal : " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void Bersih()
        {
            txID.Clear();
            txNamaBrg.Clear();
            txHarga.Clear();
            txStok.Clear();
        }
      
        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txID.Text == "" || txNamaBrg.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!");
                return;
            }

            using (MySqlConnection conn = konek.GetConn())
            {
                conn.Open();
                cmd = new MySqlCommand("insert into barang (id_barang,nama_barang,harga,stok)values(@id_barang,@nama_barang,@harga,@stok)", conn);
                cmd.Parameters.AddWithValue("@id_barang", txID.Text);
                cmd.Parameters.AddWithValue("@nama_barang", txNamaBrg.Text);
                cmd.Parameters.AddWithValue("@harga", txHarga.Text);
                cmd.Parameters.AddWithValue("@stok", txStok.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan");
                TampilData();
                Bersih();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = konek.GetConn())
            {
                conn.Open();
                cmd = new MySqlCommand("Update barang set id_barang=@id_barang, nama_barang=@nama_barang, harga=@harga, stok=@stok where id_barang=@id_barang", conn);
                cmd.Parameters.AddWithValue("@id_barang", txID.Text);
                cmd.Parameters.AddWithValue("@nama_barang", txNamaBrg.Text);
                cmd.Parameters.AddWithValue("@harga", txHarga.Text);
                cmd.Parameters.AddWithValue("@stok", txStok.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diperbarui");
                TampilData();
                Bersih();
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = konek.GetConn())
                {
                    conn.Open();
                    cmd = new MySqlCommand("delete from barang where id_barang=@id_barang", conn);
                    cmd.Parameters.AddWithValue("@id_barang", txID.Text);
                    cmd.ExecuteNonQuery();
                    TampilData();
                    Bersih();
                }
            }
        }

        private void btBersih_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txID.Text = row.Cells["id_barang"].Value.ToString();
                txNamaBrg.Text = row.Cells["nama_barang"].Value.ToString();
                txHarga.Text = row.Cells["harga"].Value.ToString();
                txStok.Text = row.Cells["stok"].Value.ToString();

            }
        }
    }
}
