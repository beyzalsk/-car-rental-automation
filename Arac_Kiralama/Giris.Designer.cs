
namespace Arac_Kiralama
{
    partial class Giris
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
            this.kayıt = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.kullanıcı = new System.Windows.Forms.Button();
            this.gyazı = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // kayıt
            // 
            this.kayıt.BackColor = System.Drawing.Color.White;
            this.kayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayıt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıt.Location = new System.Drawing.Point(551, 465);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(185, 60);
            this.kayıt.TabIndex = 2;
            this.kayıt.Text = "KAYIT OL ";
            this.kayıt.UseVisualStyleBackColor = false;
            this.kayıt.Click += new System.EventHandler(this.button3_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.White;
            this.admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin.Location = new System.Drawing.Point(12, 386);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(183, 83);
            this.admin.TabIndex = 0;
            this.admin.Text = "ADMİN";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanıcı
            // 
            this.kullanıcı.BackColor = System.Drawing.Color.White;
            this.kullanıcı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanıcı.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı.ForeColor = System.Drawing.Color.Black;
            this.kullanıcı.Location = new System.Drawing.Point(257, 434);
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(228, 63);
            this.kullanıcı.TabIndex = 3;
            this.kullanıcı.Text = "KULLANICI";
            this.toolTip1.SetToolTip(this.kullanıcı, "Kayıtlı Değilseniz Kayıt Olunuz");
            this.kullanıcı.UseVisualStyleBackColor = false;
            this.kullanıcı.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gyazı
            // 
            this.gyazı.AutoSize = true;
            this.gyazı.BackColor = System.Drawing.Color.White;
            this.gyazı.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gyazı.Location = new System.Drawing.Point(135, 23);
            this.gyazı.Name = "gyazı";
            this.gyazı.Size = new System.Drawing.Size(688, 69);
            this.gyazı.TabIndex = 4;
            this.gyazı.Text = "ORDU OTO KİRALAMA ";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arac_Kiralama.Properties.Resources.filo_arac_kiralama;
            this.ClientSize = new System.Drawing.Size(926, 537);
            this.Controls.Add(this.gyazı);
            this.Controls.Add(this.kullanıcı);
            this.Controls.Add(this.kayıt);
            this.Controls.Add(this.admin);
            this.MaximumSize = new System.Drawing.Size(944, 584);
            this.MinimumSize = new System.Drawing.Size(944, 584);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayıt;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button kullanıcı;
        private System.Windows.Forms.Label gyazı;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}