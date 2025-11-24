namespace WinFormsApp13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btexit = new Button();
            btshearch = new Button();
            boxsearch = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            bt_fotoktp = new Button();
            total_harga = new TextBox();
            btsave = new Button();
            btedit = new Button();
            btclear = new Button();
            ambil_sim = new CheckBox();
            perempuan = new RadioButton();
            laki_laki = new RadioButton();
            label6 = new Label();
            alamat = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tanggal = new DateTimePicker();
            jenis_kedaraan = new ComboBox();
            nama = new TextBox();
            dataGridView1 = new DataGridView();
            btdelete = new Button();
            tanggal_praktek = new DateTimePicker();
            Jam = new ComboBox();
            label2 = new Label();
            label13 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btexit
            // 
            btexit.BackColor = Color.Red;
            btexit.ForeColor = SystemColors.ButtonHighlight;
            btexit.Location = new Point(588, 691);
            btexit.Name = "btexit";
            btexit.Size = new Size(75, 23);
            btexit.TabIndex = 144;
            btexit.Text = "Exit";
            btexit.UseVisualStyleBackColor = false;
            btexit.Click += btexit_Click;
            // 
            // btshearch
            // 
            btshearch.BackColor = Color.ForestGreen;
            btshearch.ForeColor = SystemColors.ButtonHighlight;
            btshearch.Location = new Point(1074, 143);
            btshearch.Name = "btshearch";
            btshearch.Size = new Size(75, 23);
            btshearch.TabIndex = 143;
            btshearch.TabStop = false;
            btshearch.Text = "Search";
            btshearch.UseVisualStyleBackColor = false;
            btshearch.Click += btshearch_Click;
            // 
            // boxsearch
            // 
            boxsearch.Location = new Point(845, 143);
            boxsearch.Name = "boxsearch";
            boxsearch.PlaceholderText = " search";
            boxsearch.Size = new Size(223, 23);
            boxsearch.TabIndex = 142;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(538, 339);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(287, 193);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 141;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(389, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 111);
            pictureBox1.TabIndex = 140;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(507, 88);
            label12.Name = "label12";
            label12.Size = new Size(494, 32);
            label12.TabIndex = 139;
            label12.Text = "Driving Education and Training Institution";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(496, 9);
            label11.Name = "label11";
            label11.Size = new Size(565, 86);
            label11.TabIndex = 138;
            label11.Text = "PRIMA ACADEMY";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 616);
            label10.Name = "label10";
            label10.Size = new Size(156, 21);
            label10.TabIndex = 137;
            label10.Text = "Syarat Pendaftaran";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(38, 661);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(334, 15);
            textBox9.TabIndex = 136;
            textBox9.Text = "2. Mengisi Formulir Pendaftaran Yang Telah Di Sediakan";
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(38, 640);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(334, 15);
            textBox10.TabIndex = 135;
            textBox10.Text = "1. Menyerahkan Fotocopy KTP ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 521);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 134;
            label9.Text = "Fasilitas";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(38, 566);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(334, 15);
            textBox8.TabIndex = 133;
            textBox8.Text = "2. Instruktur Berpengalaman";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(38, 587);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(334, 15);
            textBox7.TabIndex = 132;
            textBox7.Text = "3. Sertifikat Pelatihan";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(38, 545);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(334, 15);
            textBox6.TabIndex = 131;
            textBox6.Text = "1. Mobil Avanza";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(38, 310);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(334, 205);
            textBox5.TabIndex = 130;
            textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 137);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 129;
            label8.Text = "Keterangan";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(38, 165);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(334, 139);
            textBox4.TabIndex = 128;
            textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold);
            label7.Location = new Point(406, 658);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 127;
            label7.Text = "Total Harga";
            // 
            // bt_fotoktp
            // 
            bt_fotoktp.AllowDrop = true;
            bt_fotoktp.BackColor = Color.Gray;
            bt_fotoktp.ForeColor = SystemColors.ButtonHighlight;
            bt_fotoktp.Location = new Point(538, 537);
            bt_fotoktp.Name = "bt_fotoktp";
            bt_fotoktp.Size = new Size(72, 23);
            bt_fotoktp.TabIndex = 126;
            bt_fotoktp.Text = "Choose";
            bt_fotoktp.UseVisualStyleBackColor = false;
            bt_fotoktp.Click += bt_fotoktp_Click;
            // 
            // total_harga
            // 
            total_harga.Location = new Point(538, 653);
            total_harga.Name = "total_harga";
            total_harga.ReadOnly = true;
            total_harga.Size = new Size(287, 23);
            total_harga.TabIndex = 125;
            total_harga.TextChanged += total_harga_TextChanged;
            // 
            // btsave
            // 
            btsave.BackColor = Color.ForestGreen;
            btsave.ForeColor = SystemColors.ButtonHighlight;
            btsave.Location = new Point(750, 691);
            btsave.Name = "btsave";
            btsave.Size = new Size(75, 23);
            btsave.TabIndex = 124;
            btsave.Text = "Save";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // btedit
            // 
            btedit.BackColor = Color.Gray;
            btedit.ForeColor = SystemColors.ButtonHighlight;
            btedit.Location = new Point(1155, 144);
            btedit.Name = "btedit";
            btedit.Size = new Size(75, 23);
            btedit.TabIndex = 123;
            btedit.Text = "Edit";
            btedit.UseVisualStyleBackColor = false;
            btedit.Click += btedit_Click;
            // 
            // btclear
            // 
            btclear.BackColor = Color.Gray;
            btclear.ForeColor = SystemColors.ButtonHighlight;
            btclear.Location = new Point(669, 691);
            btclear.Name = "btclear";
            btclear.Size = new Size(75, 23);
            btclear.TabIndex = 122;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = false;
            btclear.Click += btclear_Click;
            // 
            // ambil_sim
            // 
            ambil_sim.AutoSize = true;
            ambil_sim.Location = new Point(538, 626);
            ambil_sim.Name = "ambil_sim";
            ambil_sim.Size = new Size(81, 19);
            ambil_sim.TabIndex = 121;
            ambil_sim.Text = "Ambil SIM";
            ambil_sim.UseVisualStyleBackColor = true;
            ambil_sim.CheckedChanged += ambil_sim_CheckedChanged;
            // 
            // perempuan
            // 
            perempuan.AutoSize = true;
            perempuan.Location = new Point(638, 207);
            perempuan.Name = "perempuan";
            perempuan.Size = new Size(86, 19);
            perempuan.TabIndex = 120;
            perempuan.TabStop = true;
            perempuan.Text = "Perempuan";
            perempuan.UseVisualStyleBackColor = true;
            perempuan.CheckedChanged += perempuan_CheckedChanged;
            // 
            // laki_laki
            // 
            laki_laki.AutoSize = true;
            laki_laki.Location = new Point(538, 207);
            laki_laki.Name = "laki_laki";
            laki_laki.Size = new Size(72, 19);
            laki_laki.TabIndex = 119;
            laki_laki.TabStop = true;
            laki_laki.Text = "Laki-Laki";
            laki_laki.UseVisualStyleBackColor = true;
            laki_laki.CheckedChanged += laki_laki_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold);
            label6.Location = new Point(407, 339);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 118;
            label6.Text = "Foto KTP";
            // 
            // alamat
            // 
            alamat.Location = new Point(538, 237);
            alamat.Multiline = true;
            alamat.Name = "alamat";
            alamat.Size = new Size(287, 89);
            alamat.TabIndex = 117;
            alamat.TextChanged += alamat_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.Location = new Point(406, 234);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 116;
            label5.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.Location = new Point(406, 206);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 115;
            label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(407, 174);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 114;
            label3.Text = "Tanggal Lahir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            label1.Location = new Point(407, 143);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 112;
            label1.Text = "Nama";
            // 
            // tanggal
            // 
            tanggal.Location = new Point(538, 173);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(287, 23);
            tanggal.TabIndex = 111;
            tanggal.ValueChanged += tanggal_ValueChanged;
            // 
            // jenis_kedaraan
            // 
            jenis_kedaraan.DisplayMember = "ads";
            jenis_kedaraan.DropDownStyle = ComboBoxStyle.DropDownList;
            jenis_kedaraan.FormattingEnabled = true;
            jenis_kedaraan.Items.AddRange(new object[] { "SIM A", "SIM A Umum", "SIM B1", "SIM B1 Umum", "SIM B2", "SIM B2 Umum" });
            jenis_kedaraan.Location = new Point(538, 566);
            jenis_kedaraan.Name = "jenis_kedaraan";
            jenis_kedaraan.Size = new Size(287, 23);
            jenis_kedaraan.TabIndex = 110;
            jenis_kedaraan.Tag = "sd";
            jenis_kedaraan.ValueMember = "ads";
            jenis_kedaraan.SelectedIndexChanged += jenis_kedaraan_SelectedIndexChanged;
            // 
            // nama
            // 
            nama.Location = new Point(538, 143);
            nama.Name = "nama";
            nama.Size = new Size(287, 23);
            nama.TabIndex = 109;
            nama.TextChanged += nama_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(845, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 541);
            dataGridView1.TabIndex = 108;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btdelete
            // 
            btdelete.BackColor = Color.Red;
            btdelete.ForeColor = SystemColors.ButtonHighlight;
            btdelete.Location = new Point(1236, 144);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(75, 23);
            btdelete.TabIndex = 145;
            btdelete.Text = "Delete";
            btdelete.UseVisualStyleBackColor = false;
            btdelete.Click += btdelete_Click;
            // 
            // tanggal_praktek
            // 
            tanggal_praktek.DropDownAlign = LeftRightAlignment.Right;
            tanggal_praktek.Location = new Point(538, 597);
            tanggal_praktek.MinDate = new DateTime(2025, 1, 8, 0, 0, 0, 0);
            tanggal_praktek.Name = "tanggal_praktek";
            tanggal_praktek.Size = new Size(206, 23);
            tanggal_praktek.TabIndex = 146;
            tanggal_praktek.ValueChanged += tanggal_praktek_ValueChanged;
            // 
            // Jam
            // 
            Jam.DisplayMember = "ads";
            Jam.DropDownStyle = ComboBoxStyle.DropDownList;
            Jam.FormattingEnabled = true;
            Jam.Items.AddRange(new object[] { "Pagi", "Siang", "Sore" });
            Jam.Location = new Point(750, 597);
            Jam.Name = "Jam";
            Jam.Size = new Size(75, 23);
            Jam.TabIndex = 147;
            Jam.Tag = "sd";
            Jam.ValueMember = "ads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(406, 571);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 113;
            label2.Text = "Jenis SIM Kendaraan";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Bold);
            label13.Location = new Point(407, 600);
            label13.Name = "label13";
            label13.Size = new Size(92, 15);
            label13.TabIndex = 148;
            label13.Text = "Waktu Praktek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            CausesValidation = false;
            ClientSize = new Size(1356, 749);
            Controls.Add(label13);
            Controls.Add(Jam);
            Controls.Add(tanggal_praktek);
            Controls.Add(btdelete);
            Controls.Add(btexit);
            Controls.Add(btshearch);
            Controls.Add(boxsearch);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(bt_fotoktp);
            Controls.Add(total_harga);
            Controls.Add(btsave);
            Controls.Add(btedit);
            Controls.Add(btclear);
            Controls.Add(ambil_sim);
            Controls.Add(perempuan);
            Controls.Add(laki_laki);
            Controls.Add(label6);
            Controls.Add(alamat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tanggal);
            Controls.Add(jenis_kedaraan);
            Controls.Add(nama);
            Controls.Add(dataGridView1);
            ForeColor = Color.Navy;
            MaximizeBox = false;
            Name = "Form1";
            Text = "PRIMA ACADEMY";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btexit;
        private Button btshearch;
        private TextBox boxsearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private Button bt_fotoktp;
        private TextBox total_harga;
        private Button btsave;
        private Button btedit;
        private Button btclear;
        private CheckBox ambil_sim;
        private RadioButton perempuan;
        private RadioButton laki_laki;
        private Label label6;
        private TextBox alamat;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker tanggal;
        private ComboBox jenis_kedaraan;
        private TextBox nama;
        private DataGridView dataGridView1;
        private Button btdelete;
        private DateTimePicker tanggal_praktek;
        private ComboBox Jam;
        private Label label2;
        private Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
