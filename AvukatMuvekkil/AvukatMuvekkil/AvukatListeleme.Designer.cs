namespace AvukatMuvekkil
{
    partial class AvukatListeleme
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dgwAvukatlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCKNO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvukatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.icons8_left_100;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(47, 38);
            this.btnGeri.TabIndex = 29;
            this.btnGeri.UseVisualStyleBackColor = false;
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.Transparent;
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnKucult.Location = new System.Drawing.Point(930, 12);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(26, 23);
            this.btnKucult.TabIndex = 30;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnKapat.Location = new System.Drawing.Point(962, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(26, 23);
            this.btnKapat.TabIndex = 31;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dgwAvukatlar
            // 
            this.dgwAvukatlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.dgwAvukatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAvukatlar.Location = new System.Drawing.Point(13, 128);
            this.dgwAvukatlar.Name = "dgwAvukatlar";
            this.dgwAvukatlar.Size = new System.Drawing.Size(975, 510);
            this.dgwAvukatlar.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ara : ";
            // 
            // txtTCKNO
            // 
            this.txtTCKNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.txtTCKNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTCKNO.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCKNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(76)))), ((int)(((byte)(75)))));
            this.txtTCKNO.Location = new System.Drawing.Point(104, 68);
            this.txtTCKNO.Multiline = true;
            this.txtTCKNO.Name = "txtTCKNO";
            this.txtTCKNO.Size = new System.Drawing.Size(248, 30);
            this.txtTCKNO.TabIndex = 34;
            // 
            // AvukatListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.txtTCKNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAvukatlar);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvukatListeleme";
            this.Text = "AvukatListeleme";
            this.Load += new System.EventHandler(this.AvukatListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvukatlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgwAvukatlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCKNO;
    }
}