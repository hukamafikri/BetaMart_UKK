namespace BetaMart
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.lbcari = new System.Windows.Forms.Label();
            this.tbcari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.btntampilkan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbharga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnedit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnedit.Location = new System.Drawing.Point(347, 487);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 30);
            this.btnedit.TabIndex = 16;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhapus.Location = new System.Drawing.Point(559, 487);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(106, 30);
            this.btnhapus.TabIndex = 15;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.MidnightBlue;
            this.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntambah.Location = new System.Drawing.Point(236, 487);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(105, 30);
            this.btntambah.TabIndex = 14;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // lbcari
            // 
            this.lbcari.AutoSize = true;
            this.lbcari.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcari.ForeColor = System.Drawing.Color.White;
            this.lbcari.Location = new System.Drawing.Point(280, 227);
            this.lbcari.Name = "lbcari";
            this.lbcari.Size = new System.Drawing.Size(88, 23);
            this.lbcari.TabIndex = 17;
            this.lbcari.Text = "Cari Data";
            this.lbcari.Click += new System.EventHandler(this.lbcari_Click);
            // 
            // tbcari
            // 
            this.tbcari.Location = new System.Drawing.Point(374, 225);
            this.tbcari.Multiline = true;
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(292, 24);
            this.tbcari.TabIndex = 18;
            this.tbcari.TextChanged += new System.EventHandler(this.tbcari_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(643, 215);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Jumlah Produk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbstok
            // 
            this.tbstok.Location = new System.Drawing.Point(161, 225);
            this.tbstok.Multiline = true;
            this.tbstok.Name = "tbstok";
            this.tbstok.Size = new System.Drawing.Size(113, 24);
            this.tbstok.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Harga Produk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kode Produk";
            // 
            // tbkode
            // 
            this.tbkode.Location = new System.Drawing.Point(157, 142);
            this.tbkode.Multiline = true;
            this.tbkode.Name = "tbkode";
            this.tbkode.Size = new System.Drawing.Size(282, 23);
            this.tbkode.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nama Produk";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(157, 103);
            this.tbnama.Multiline = true;
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(282, 23);
            this.tbnama.TabIndex = 21;
            this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID Produk";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(157, 64);
            this.tbid.Multiline = true;
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(282, 24);
            this.tbid.TabIndex = 31;
            // 
            // btntampilkan
            // 
            this.btntampilkan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btntampilkan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntampilkan.Location = new System.Drawing.Point(453, 487);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Size = new System.Drawing.Size(100, 30);
            this.btntampilkan.TabIndex = 34;
            this.btntampilkan.Text = "Tampilkan";
            this.btntampilkan.UseVisualStyleBackColor = false;
            this.btntampilkan.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 35;
            this.label2.Text = "BETA MART";
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(157, 179);
            this.tbharga.Multiline = true;
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(282, 22);
            this.tbharga.TabIndex = 25;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntampilkan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbkode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbcari);
            this.Controls.Add(this.lbcari);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btntambah);
            this.Name = "FormUtama";
            this.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From1";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Label lbcari;
        private System.Windows.Forms.TextBox tbcari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbkode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Button btntampilkan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbharga;
    }
}