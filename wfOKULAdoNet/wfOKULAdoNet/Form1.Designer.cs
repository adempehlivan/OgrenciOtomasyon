namespace wfOKULAdoNet
{
    partial class Form1
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
            this.cbSiniflar = new System.Windows.Forms.ComboBox();
            this.lvOgrenciler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Seçiniz";
            // 
            // cbSiniflar
            // 
            this.cbSiniflar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiniflar.FormattingEnabled = true;
            this.cbSiniflar.Location = new System.Drawing.Point(15, 25);
            this.cbSiniflar.Name = "cbSiniflar";
            this.cbSiniflar.Size = new System.Drawing.Size(121, 21);
            this.cbSiniflar.TabIndex = 1;
            this.cbSiniflar.SelectedIndexChanged += new System.EventHandler(this.cbSiniflar_SelectedIndexChanged);
            // 
            // lvOgrenciler
            // 
            this.lvOgrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvOgrenciler.Location = new System.Drawing.Point(15, 52);
            this.lvOgrenciler.Name = "lvOgrenciler";
            this.lvOgrenciler.Size = new System.Drawing.Size(468, 349);
            this.lvOgrenciler.TabIndex = 2;
            this.lvOgrenciler.UseCompatibleStateImageBehavior = false;
            this.lvOgrenciler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adres";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SinifAd";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 413);
            this.Controls.Add(this.lvOgrenciler);
            this.Controls.Add(this.cbSiniflar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ado.net Tekrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSiniflar;
        private System.Windows.Forms.ListView lvOgrenciler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

