using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        // ===== Variabel global =====
        int hjnSim = 300000;
        int hjnSimA;
        string jampraktek;
        string fotoPath = "";

        public Form1()
        {
            InitializeComponent();

            // Hubungkan event real-time
            jenis_kedaraan.SelectedIndexChanged += new EventHandler(jenis_kedaraan_SelectedIndexChanged);
            ambil_sim.CheckedChanged += new EventHandler(ambil_sim_CheckedChanged);

            tanggal_praktek.MinDate = DateTime.Today;
            tanggal_praktek.Value = DateTime.Today;

        }

        // ===== HITUNG TOTAL REAL-TIME =====
        private void HitungTotal()
        {
            hjnSimA = hjnSim;

            switch (jenis_kedaraan.Text)
            {
                case "SIM A": hjnSimA += 150000; break;
                case "SIM A Umum": hjnSimA += 200000; break;
                case "SIM B1": hjnSimA += 250000; break;
                case "SIM B1 Umum": hjnSimA += 300000; break;
                case "SIM B2": hjnSimA += 350000; break;
                case "SIM B2 Umum": hjnSimA += 400000; break;
            }

            // --- Tambahkan biaya jam praktek jika perlu ---

            if (ambil_sim.Checked)
                hjnSimA += 100000;

            total_harga.Text = hjnSimA.ToString("N0");
        }


        // ===== LOAD FORM =====
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

            // Hapus kolom yang sudah ada (jika ada)
            dataGridView1.Columns.Clear();

            // Tambahkan kolom dengan Name unik
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNama", HeaderText = "Nama" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTanggal", HeaderText = "Tanggal Lahir" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGender", HeaderText = "Jenis Kelamin" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAlamat", HeaderText = "Alamat" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKendaraan", HeaderText = "Jenis Kendaraan" });

            DataGridViewImageColumn fotoColumn = new DataGridViewImageColumn
            {
                Name = "colFoto",
                HeaderText = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(fotoColumn);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total Harga" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "coltanggal", HeaderText = "Tanggal praktek" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "coljam", HeaderText = "jam praktek" });

            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Columns["colNama"].Width = 120;
            dataGridView1.Columns["colTanggal"].Width = 120;
            dataGridView1.Columns["colGender"].Width = 120;
            dataGridView1.Columns["colAlamat"].Width = 180;
            dataGridView1.Columns["colKendaraan"].Width = 110;
            dataGridView1.Columns["colFoto"].Width = 150;
            dataGridView1.Columns["colTotal"].Width = 100;
            dataGridView1.Columns["coltanggal"].Width = 140;
            dataGridView1.Columns["coljam"].Width = 100;

            //dataGridView1.ColumnTemplate.Widt = 100;
            hjnSimA = hjnSim;
        }

        // ===== PILIH FOTO =====
        private void bt_fotoktp_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pilih Gambar |*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                fotoPath = opf.FileName;
                pictureBox2.Image = Image.FromFile(fotoPath);
            }
        }

        // ===== SAVE DATA =====
        private void btsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nama.Text) || string.IsNullOrEmpty(alamat.Text) ||
                jenis_kedaraan.SelectedIndex == -1 || Jam.SelectedIndex == -1)
            {
                MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Foto belum dipilih!");
                return;
            }

            HitungTotal();

            string Nama = nama.Text;
            string Tanggal = tanggal.Value.ToShortDateString();
            string Gender = laki_laki.Checked ? "Laki-laki" :
                            (perempuan.Checked ? "Perempuan" : "");
            string Alamat = alamat.Text;
            string Kendaraan = jenis_kedaraan.Text;
            string Total = hjnSimA.ToString("N0");
            string tanggal_prak = tanggal_praktek.Value.ToShortDateString();
            string jam = Jam.Text;

            Image foto = pictureBox2.Image != null ? new Bitmap(pictureBox2.Image) : null;

            dataGridView1.Rows.Add(Nama, Tanggal, Gender, Alamat, Kendaraan, foto, Total, tanggal_prak, jam);

            riset();
        }

        // ===== CLEAR FORM =====
        private void btclear_Click(object sender, EventArgs e)
        {
            riset();
        }

        // ===== RESET INPUT =====
        private void riset()
        {
            nama.Clear();
            alamat.Clear();
            laki_laki.Checked = false;
            perempuan.Checked = false;
            jenis_kedaraan.SelectedIndex = -1;
            pictureBox2.Image = null;
            tanggal.Value = DateTime.Now;
            total_harga.Clear();
            fotoPath = "";
            tanggal_praktek.Value = DateTime.Now;
            Jam.SelectedIndex = -1;
        }

        // ===== EXIT =====
        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                Close();
        }

        // ===== EVENT REAL-TIME =====
        private void jenis_kedaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void ambil_sim_CheckedChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        // ===== SEARCH =====
        private void btshearch_Click(object sender, EventArgs e)
        {
            string keyword = boxsearch.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Abaikan baris baru (baris kosong di akhir)
                if (row.IsNewRow)
                    continue;

                // Jika kolom Nama ada isinya, cek keyword
                if (row.Cells["colNama"].Value != null)
                {
                    row.Visible = row.Cells["colNama"].Value.ToString().ToLower().Contains(keyword);
                }
                else
                {
                    row.Visible = false;
                }
            }
        }


        // ===== EDIT DATA =====
        private void btedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diedit.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Ambil data ke textbox
            nama.Text = row.Cells["colNama"].Value?.ToString();
            alamat.Text = row.Cells["colAlamat"].Value?.ToString();
            jenis_kedaraan.Text = row.Cells["colKendaraan"].Value?.ToString();

            string gender = row.Cells["colGender"].Value?.ToString();
            laki_laki.Checked = (gender == "Laki-laki");
            perempuan.Checked = (gender == "Perempuan");

            if (DateTime.TryParse(row.Cells["colTanggal"].Value?.ToString(), out DateTime tgl))
                tanggal.Value = tgl;

            if (DateTime.TryParse(row.Cells["coltanggal"].Value?.ToString(), out DateTime tglPrak))
                tanggal_praktek.Value = tglPrak;

            Jam.Text = row.Cells["coljam"].Value?.ToString();

            // Ambil foto
            pictureBox2.Image = row.Cells["colFoto"].Value as Image;

            // Total harga
            total_harga.Text = row.Cells["colTotal"].Value?.ToString();

            // Hapus baris lama
            dataGridView1.Rows.Remove(row);
        }


        // ===== DELETE DATA =====
        private void btdelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(row);
        }

        // ===== UNUSED EVENTS =====
        private void boxsearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void nama_TextChanged(object sender, EventArgs e)
        {

        }
        private void tanggal_ValueChanged(object sender, EventArgs e)
        {

        }
        private void laki_laki_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void perempuan_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void alamat_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
        private void total_harga_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tanggal_praktek_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Jam_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void Jam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HitungTotal();
        }
    }
}