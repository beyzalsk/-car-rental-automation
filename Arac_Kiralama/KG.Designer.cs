
namespace Arac_Kiralama
{
    partial class KG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.grs = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAİL ADRESİ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(287, 286);
            this.mail.Multiline = true;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(139, 35);
            this.mail.TabIndex = 2;
            // 
            // grs
            // 
            this.grs.BackColor = System.Drawing.Color.Transparent;
            this.grs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grs.ForeColor = System.Drawing.Color.White;
            this.grs.Location = new System.Drawing.Point(492, 388);
            this.grs.Name = "grs";
            this.grs.Size = new System.Drawing.Size(106, 61);
            this.grs.TabIndex = 4;
            this.grs.Text = "GİRİŞ";
            this.grs.UseVisualStyleBackColor = false;
            this.grs.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(287, 352);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(139, 32);
            this.sifre.TabIndex = 3;
            // 
            // KG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arac_Kiralama.Properties.Resources._20120623124636_68f8310b_me;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.grs);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(628, 508);
            this.MinimumSize = new System.Drawing.Size(628, 508);
            this.Name = "KG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KG";
            this.Load += new System.EventHandler(this.KG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button grs;
        private System.Windows.Forms.TextBox sifre;
    }
}