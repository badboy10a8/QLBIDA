namespace QLBIDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntGoiMon = new System.Windows.Forms.Button();
            this.bntThucDon = new System.Windows.Forms.Button();
            this.bntTinhTien = new System.Windows.Forms.Button();
            this.bntInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(633, 239);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // bntGoiMon
            // 
            this.bntGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("bntGoiMon.Image")));
            this.bntGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGoiMon.Location = new System.Drawing.Point(525, 257);
            this.bntGoiMon.Name = "bntGoiMon";
            this.bntGoiMon.Size = new System.Drawing.Size(120, 58);
            this.bntGoiMon.TabIndex = 2;
            this.bntGoiMon.Text = "Gọi món";
            this.bntGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGoiMon.UseVisualStyleBackColor = true;
            // 
            // bntThucDon
            // 
            this.bntThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThucDon.Image = ((System.Drawing.Image)(resources.GetObject("bntThucDon.Image")));
            this.bntThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThucDon.Location = new System.Drawing.Point(525, 321);
            this.bntThucDon.Name = "bntThucDon";
            this.bntThucDon.Size = new System.Drawing.Size(120, 58);
            this.bntThucDon.TabIndex = 3;
            this.bntThucDon.Text = "Thực đơn";
            this.bntThucDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntThucDon.UseVisualStyleBackColor = true;
            // 
            // bntTinhTien
            // 
            this.bntTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTinhTien.Image = ((System.Drawing.Image)(resources.GetObject("bntTinhTien.Image")));
            this.bntTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTinhTien.Location = new System.Drawing.Point(525, 385);
            this.bntTinhTien.Name = "bntTinhTien";
            this.bntTinhTien.Size = new System.Drawing.Size(120, 58);
            this.bntTinhTien.TabIndex = 4;
            this.bntTinhTien.Text = "Tính tiền";
            this.bntTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTinhTien.UseVisualStyleBackColor = true;
            // 
            // bntInHoaDon
            // 
            this.bntInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("bntInHoaDon.Image")));
            this.bntInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInHoaDon.Location = new System.Drawing.Point(525, 449);
            this.bntInHoaDon.Name = "bntInHoaDon";
            this.bntInHoaDon.Size = new System.Drawing.Size(120, 58);
            this.bntInHoaDon.TabIndex = 5;
            this.bntInHoaDon.Text = "In hóa đơn";
            this.bntInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntInHoaDon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 524);
            this.Controls.Add(this.bntInHoaDon);
            this.Controls.Add(this.bntTinhTien);
            this.Controls.Add(this.bntThucDon);
            this.Controls.Add(this.bntGoiMon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Quản lý quán bida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntGoiMon;
        private System.Windows.Forms.Button bntThucDon;
        private System.Windows.Forms.Button bntTinhTien;
        private System.Windows.Forms.Button bntInHoaDon;
    }
}

