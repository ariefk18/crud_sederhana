
namespace crud
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.txHarga = new System.Windows.Forms.TextBox();
            this.txNamaBrg = new System.Windows.Forms.TextBox();
            this.txStok = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btBersih = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(153, 58);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 22);
            this.txID.TabIndex = 5;
            // 
            // txHarga
            // 
            this.txHarga.Location = new System.Drawing.Point(153, 126);
            this.txHarga.Name = "txHarga";
            this.txHarga.Size = new System.Drawing.Size(100, 22);
            this.txHarga.TabIndex = 6;
            // 
            // txNamaBrg
            // 
            this.txNamaBrg.Location = new System.Drawing.Point(153, 92);
            this.txNamaBrg.Name = "txNamaBrg";
            this.txNamaBrg.Size = new System.Drawing.Size(100, 22);
            this.txNamaBrg.TabIndex = 7;
            // 
            // txStok
            // 
            this.txStok.Location = new System.Drawing.Point(153, 161);
            this.txStok.Name = "txStok";
            this.txStok.Size = new System.Drawing.Size(100, 22);
            this.txStok.TabIndex = 8;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(332, 52);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(93, 34);
            this.btSimpan.TabIndex = 9;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(332, 92);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(93, 34);
            this.btHapus.TabIndex = 10;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(332, 131);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(93, 34);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btBersih
            // 
            this.btBersih.Location = new System.Drawing.Point(332, 171);
            this.btBersih.Name = "btBersih";
            this.btBersih.Size = new System.Drawing.Size(93, 34);
            this.btBersih.TabIndex = 12;
            this.btBersih.Text = "Bersih";
            this.btBersih.UseVisualStyleBackColor = true;
            this.btBersih.Click += new System.EventHandler(this.btBersih_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(58, 230);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(487, 150);
            this.dgvData.TabIndex = 13;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btBersih);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.txStok);
            this.Controls.Add(this.txNamaBrg);
            this.Controls.Add(this.txHarga);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txHarga;
        private System.Windows.Forms.TextBox txNamaBrg;
        private System.Windows.Forms.TextBox txStok;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btBersih;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

