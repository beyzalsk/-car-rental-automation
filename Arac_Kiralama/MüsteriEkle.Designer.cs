
namespace Arac_Kiralama
{
    partial class MüsteriEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriEkle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iptal = new System.Windows.Forms.Button();
            this.isim = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.ehliyet = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.ttc = new System.Windows.Forms.TextBox();
            this.dtt = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.ehlyt = new System.Windows.Forms.Label();
            this.ctel = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.sisim = new System.Windows.Forms.Label();
            this.ism = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EKLEME = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EKLEME.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle1.jpg");
            this.ımageList1.Images.SetKeyName(1, "unnamed.png");
            this.ımageList1.Images.SetKeyName(2, "delete-1432400-1211078.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Transparent;
            this.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.ImageKey = "unnamed.png";
            this.iptal.ImageList = this.ımageList1;
            this.iptal.Location = new System.Drawing.Point(557, 475);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(121, 134);
            this.iptal.TabIndex = 16;
            this.iptal.Text = "İPTAL";
            this.iptal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // isim
            // 
            this.isim.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.Location = new System.Drawing.Point(238, 45);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(115, 29);
            this.isim.TabIndex = 13;
            // 
            // ekle
            // 
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ImageKey = "ekle1.jpg";
            this.ekle.ImageList = this.ımageList1;
            this.ekle.Location = new System.Drawing.Point(382, 475);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(115, 134);
            this.ekle.TabIndex = 12;
            this.ekle.Text = "EKLE";
            this.ekle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // ehliyet
            // 
            this.ehliyet.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ehliyet.Location = new System.Drawing.Point(238, 417);
            this.ehliyet.Name = "ehliyet";
            this.ehliyet.Size = new System.Drawing.Size(115, 29);
            this.ehliyet.TabIndex = 11;
            // 
            // soyisim
            // 
            this.soyisim.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisim.Location = new System.Drawing.Point(238, 121);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(115, 29);
            this.soyisim.TabIndex = 10;
            // 
            // ttc
            // 
            this.ttc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ttc.Location = new System.Drawing.Point(238, 191);
            this.ttc.Name = "ttc";
            this.ttc.Size = new System.Drawing.Size(115, 29);
            this.ttc.TabIndex = 9;
            // 
            // dtt
            // 
            this.dtt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtt.Location = new System.Drawing.Point(238, 272);
            this.dtt.Name = "dtt";
            this.dtt.Size = new System.Drawing.Size(115, 29);
            this.dtt.TabIndex = 8;
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tel.Location = new System.Drawing.Point(238, 346);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(115, 29);
            this.tel.TabIndex = 7;
            // 
            // ehlyt
            // 
            this.ehlyt.AutoSize = true;
            this.ehlyt.BackColor = System.Drawing.Color.Black;
            this.ehlyt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehlyt.ForeColor = System.Drawing.Color.White;
            this.ehlyt.Location = new System.Drawing.Point(3, 415);
            this.ehlyt.Name = "ehlyt";
            this.ehlyt.Size = new System.Drawing.Size(169, 29);
            this.ehlyt.TabIndex = 5;
            this.ehlyt.Text = "EHLİYET NO ";
            // 
            // ctel
            // 
            this.ctel.AutoSize = true;
            this.ctel.BackColor = System.Drawing.Color.Black;
            this.ctel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctel.ForeColor = System.Drawing.Color.White;
            this.ctel.Location = new System.Drawing.Point(-5, 344);
            this.ctel.Name = "ctel";
            this.ctel.Size = new System.Drawing.Size(195, 29);
            this.ctel.TabIndex = 4;
            this.ctel.Text = "CEP TELEFONU";
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.BackColor = System.Drawing.Color.Black;
            this.dt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.ForeColor = System.Drawing.Color.White;
            this.dt.Location = new System.Drawing.Point(-4, 270);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(203, 29);
            this.dt.TabIndex = 3;
            this.dt.Text = "DOĞUM TARİHİ";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.BackColor = System.Drawing.Color.Black;
            this.tc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.ForeColor = System.Drawing.Color.White;
            this.tc.Location = new System.Drawing.Point(-4, 191);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(44, 29);
            this.tc.TabIndex = 2;
            this.tc.Text = "TC";
            // 
            // sisim
            // 
            this.sisim.AutoSize = true;
            this.sisim.BackColor = System.Drawing.Color.Black;
            this.sisim.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sisim.ForeColor = System.Drawing.Color.White;
            this.sisim.Location = new System.Drawing.Point(-4, 121);
            this.sisim.Name = "sisim";
            this.sisim.Size = new System.Drawing.Size(122, 29);
            this.sisim.TabIndex = 1;
            this.sisim.Text = "SOYİSİM";
            // 
            // ism
            // 
            this.ism.AutoSize = true;
            this.ism.BackColor = System.Drawing.Color.Black;
            this.ism.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ism.ForeColor = System.Drawing.Color.White;
            this.ism.Location = new System.Drawing.Point(6, 43);
            this.ism.Name = "ism";
            this.ism.Size = new System.Drawing.Size(73, 29);
            this.ism.TabIndex = 0;
            this.ism.Text = "İSİM";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageKey = "delete-1432400-1211078.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(405, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 111);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EKLEME
            // 
            this.EKLEME.Controls.Add(this.tabPage1);
            this.EKLEME.Controls.Add(this.tabPage2);
            this.EKLEME.Location = new System.Drawing.Point(12, 12);
            this.EKLEME.Name = "EKLEME";
            this.EKLEME.SelectedIndex = 0;
            this.EKLEME.Size = new System.Drawing.Size(773, 644);
            this.EKLEME.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Arac_Kiralama.Properties.Resources.duvar_resimleri_beyaz_arka_plan_geometrik_doku_jpg;
            this.tabPage1.Controls.Add(this.tc);
            this.tabPage1.Controls.Add(this.sisim);
            this.tabPage1.Controls.Add(this.ekle);
            this.tabPage1.Controls.Add(this.iptal);
            this.tabPage1.Controls.Add(this.isim);
            this.tabPage1.Controls.Add(this.dt);
            this.tabPage1.Controls.Add(this.ehliyet);
            this.tabPage1.Controls.Add(this.ism);
            this.tabPage1.Controls.Add(this.soyisim);
            this.tabPage1.Controls.Add(this.ehlyt);
            this.tabPage1.Controls.Add(this.ctel);
            this.tabPage1.Controls.Add(this.tel);
            this.tabPage1.Controls.Add(this.ttc);
            this.tabPage1.Controls.Add(this.dtt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EKLEME";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Arac_Kiralama.Properties.Resources.duvar_resimleri_beyaz_arka_plan_geometrik_doku_jpg;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " SİLME";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(124, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 97);
            this.button2.TabIndex = 4;
            this.button2.Text = "MÜŞTERİLERİ LİSTELE ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MüsteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Arac_Kiralama.Properties.Resources.duvar_resimleri_beyaz_arka_plan_geometrik_doku_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 649);
            this.Controls.Add(this.EKLEME);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "MüsteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüsteriEkle";
            this.Load += new System.EventHandler(this.MüsteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EKLEME.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox ehliyet;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.TextBox ttc;
        private System.Windows.Forms.TextBox dtt;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label ehlyt;
        private System.Windows.Forms.Label ctel;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label sisim;
        private System.Windows.Forms.Label ism;
        private System.Windows.Forms.TabControl EKLEME;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
    }
}