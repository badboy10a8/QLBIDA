﻿namespace QLBIDA
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being use
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.bntGoiMon = new System.Windows.Forms.Button();
            this.bntThucDon = new System.Windows.Forms.Button();
            this.bntTinhTien = new System.Windows.Forms.Button();
            this.bntInHoaDon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_themban = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_banconguoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_banchuaconguoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_allban = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.thongtin = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(633, 239);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_Click);
            // 
            // luoi
            // 
            this.luoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(16, 14);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(462, 304);
            this.luoi.TabIndex = 1;
            // 
            // bntGoiMon
            // 
            this.bntGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("bntGoiMon.Image")));
            this.bntGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGoiMon.Location = new System.Drawing.Point(525, 271);
            this.bntGoiMon.Name = "bntGoiMon";
            this.bntGoiMon.Size = new System.Drawing.Size(120, 42);
            this.bntGoiMon.TabIndex = 2;
            this.bntGoiMon.Text = "Gọi món";
            this.bntGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGoiMon.UseVisualStyleBackColor = true;
            this.bntGoiMon.Click += new System.EventHandler(this.bntGoiMon_Click);
            // 
            // bntThucDon
            // 
            this.bntThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThucDon.Image = ((System.Drawing.Image)(resources.GetObject("bntThucDon.Image")));
            this.bntThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThucDon.Location = new System.Drawing.Point(525, 319);
            this.bntThucDon.Name = "bntThucDon";
            this.bntThucDon.Size = new System.Drawing.Size(120, 42);
            this.bntThucDon.TabIndex = 3;
            this.bntThucDon.Text = "Thực đơn";
            this.bntThucDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntThucDon.UseVisualStyleBackColor = true;
            this.bntThucDon.Click += new System.EventHandler(this.bntThucDon_Click);
            // 
            // bntTinhTien
            // 
            this.bntTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTinhTien.Image = ((System.Drawing.Image)(resources.GetObject("bntTinhTien.Image")));
            this.bntTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTinhTien.Location = new System.Drawing.Point(525, 367);
            this.bntTinhTien.Name = "bntTinhTien";
            this.bntTinhTien.Size = new System.Drawing.Size(120, 42);
            this.bntTinhTien.TabIndex = 4;
            this.bntTinhTien.Text = "Tính tiền";
            this.bntTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTinhTien.UseVisualStyleBackColor = true;
            this.bntTinhTien.Click += new System.EventHandler(this.bntTinhTien_Click);
            // 
            // bntInHoaDon
            // 
            this.bntInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("bntInHoaDon.Image")));
            this.bntInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInHoaDon.Location = new System.Drawing.Point(525, 415);
            this.bntInHoaDon.Name = "bntInHoaDon";
            this.bntInHoaDon.Size = new System.Drawing.Size(120, 42);
            this.bntInHoaDon.TabIndex = 5;
            this.bntInHoaDon.Text = "In hóa đơn";
            this.bntInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntInHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(651, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 596);
            this.panel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thongtin);
            this.groupBox1.Controls.Add(this.luoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 351);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_themban,
            this.menu_banconguoi,
            this.menu_banchuaconguoi,
            this.menu_allban});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 92);
            // 
            // menu_themban
            // 
            this.menu_themban.Name = "menu_themban";
            this.menu_themban.Size = new System.Drawing.Size(219, 22);
            this.menu_themban.Text = "Thêm bàn mới";
            // 
            // menu_banconguoi
            // 
            this.menu_banconguoi.Name = "menu_banconguoi";
            this.menu_banconguoi.Size = new System.Drawing.Size(219, 22);
            this.menu_banconguoi.Text = "Hiển thị bàn có khách";
            // 
            // menu_banchuaconguoi
            // 
            this.menu_banchuaconguoi.Name = "menu_banchuaconguoi";
            this.menu_banchuaconguoi.Size = new System.Drawing.Size(219, 22);
            this.menu_banchuaconguoi.Text = "Hiển thị bàn chưa có khách";
            // 
            // menu_allban
            // 
            this.menu_allban.Name = "menu_allban";
            this.menu_allban.Size = new System.Drawing.Size(219, 22);
            this.menu_allban.Text = "Hiển thị tất cả";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThựcĐơnToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(157, 26);
            // 
            // thêmThựcĐơnToolStripMenuItem
            // 
            this.thêmThựcĐơnToolStripMenuItem.Name = "thêmThựcĐơnToolStripMenuItem";
            this.thêmThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thêmThựcĐơnToolStripMenuItem.Text = "Thêm thực đơn";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "controng.jpg");
            this.imageList1.Images.SetKeyName(1, "hettrong.jpg");
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(525, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nhân viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thongtin
            // 
            this.thongtin.AutoSize = true;
            this.thongtin.Location = new System.Drawing.Point(386, 335);
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(0, 13);
            this.thongtin.TabIndex = 2;
            // 
            // txttongtien
            // 
            this.txttongtien.AutoSize = true;
            this.txttongtien.Location = new System.Drawing.Point(522, 580);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(0, 13);
            this.txttongtien.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bntInHoaDon);
            this.Controls.Add(this.bntTinhTien);
            this.Controls.Add(this.bntThucDon);
            this.Controls.Add(this.bntGoiMon);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán bida";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Button bntGoiMon;
        private System.Windows.Forms.Button bntThucDon;
        private System.Windows.Forms.Button bntTinhTien;
        private System.Windows.Forms.Button bntInHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_themban;
        private System.Windows.Forms.ToolStripMenuItem menu_banconguoi;
        private System.Windows.Forms.ToolStripMenuItem menu_banchuaconguoi;
        private System.Windows.Forms.ToolStripMenuItem menu_allban;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label thongtin;
        private System.Windows.Forms.Label txttongtien;
    }
}

