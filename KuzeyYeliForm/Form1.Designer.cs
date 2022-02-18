
namespace KuzeyYeliForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.nmdfiyat = new System.Windows.Forms.NumericUpDown();
            this.nmdstok = new System.Windows.Forms.NumericUpDown();
            this.cbkategoriler = new System.Windows.Forms.ComboBox();
            this.cbtedarikciler = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdstok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(752, 229);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(104, 32);
            this.btnkategori.TabIndex = 1;
            this.btnkategori.Text = "Kategoriler";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Urun Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategoriler :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tedarikçiler :";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(37, 64);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(100, 22);
            this.txturunad.TabIndex = 3;
            // 
            // nmdfiyat
            // 
            this.nmdfiyat.Location = new System.Drawing.Point(164, 64);
            this.nmdfiyat.Name = "nmdfiyat";
            this.nmdfiyat.Size = new System.Drawing.Size(120, 22);
            this.nmdfiyat.TabIndex = 4;
            // 
            // nmdstok
            // 
            this.nmdstok.Location = new System.Drawing.Point(319, 64);
            this.nmdstok.Name = "nmdstok";
            this.nmdstok.Size = new System.Drawing.Size(120, 22);
            this.nmdstok.TabIndex = 4;
            // 
            // cbkategoriler
            // 
            this.cbkategoriler.FormattingEnabled = true;
            this.cbkategoriler.Location = new System.Drawing.Point(465, 60);
            this.cbkategoriler.Name = "cbkategoriler";
            this.cbkategoriler.Size = new System.Drawing.Size(121, 24);
            this.cbkategoriler.TabIndex = 5;
            // 
            // cbtedarikciler
            // 
            this.cbtedarikciler.FormattingEnabled = true;
            this.cbtedarikciler.Location = new System.Drawing.Point(621, 60);
            this.cbtedarikciler.Name = "cbtedarikciler";
            this.cbtedarikciler.Size = new System.Drawing.Size(121, 24);
            this.cbtedarikciler.TabIndex = 5;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(752, 109);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(104, 32);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, -142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ekle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.cbtedarikciler);
            this.Controls.Add(this.cbkategoriler);
            this.Controls.Add(this.nmdstok);
            this.Controls.Add(this.nmdfiyat);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkategori);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.NumericUpDown nmdfiyat;
        private System.Windows.Forms.NumericUpDown nmdstok;
        private System.Windows.Forms.ComboBox cbkategoriler;
        private System.Windows.Forms.ComboBox cbtedarikciler;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label6;
    }
}

