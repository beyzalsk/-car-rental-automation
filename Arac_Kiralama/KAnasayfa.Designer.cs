
namespace Arac_Kiralama
{
    partial class KAnasayfa
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
            this.arac = new System.Windows.Forms.Button();
            this.kira = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arac
            // 
            this.arac.BackColor = System.Drawing.Color.White;
            this.arac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arac.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arac.ForeColor = System.Drawing.Color.Black;
            this.arac.Location = new System.Drawing.Point(0, 244);
            this.arac.Name = "arac";
            this.arac.Size = new System.Drawing.Size(237, 97);
            this.arac.TabIndex = 0;
            this.arac.Text = "ARAÇLAR";
            this.arac.UseVisualStyleBackColor = false;
            this.arac.Click += new System.EventHandler(this.button1_Click);
            // 
            // kira
            // 
            this.kira.BackColor = System.Drawing.Color.White;
            this.kira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kira.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kira.ForeColor = System.Drawing.Color.Black;
            this.kira.Location = new System.Drawing.Point(0, 602);
            this.kira.Name = "kira";
            this.kira.Size = new System.Drawing.Size(220, 98);
            this.kira.TabIndex = 1;
            this.kira.Text = "KİRALA";
            this.kira.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.kira, "Kiralama İşleminizi Burdan Yapabilirsiniz");
            this.kira.UseVisualStyleBackColor = false;
            this.kira.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(679, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // KAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arac_Kiralama.Properties.Resources._650x344_alman_araba_markalari_alman_araba_otomobil_modelleri_siralamasi_ve_listesi_1597331062493;
            this.ClientSize = new System.Drawing.Size(808, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kira);
            this.Controls.Add(this.arac);
            this.MaximumSize = new System.Drawing.Size(826, 759);
            this.MinimumSize = new System.Drawing.Size(826, 759);
            this.Name = "KAnasayfa";
            this.Text = "AracListe";
            this.Load += new System.EventHandler(this.AracListe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arac;
        private System.Windows.Forms.Button kira;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}