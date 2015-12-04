﻿namespace QLBIDA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntGoiMon = new System.Windows.Forms.Button();
            this.bntThucDon = new System.Windows.Forms.Button();
            this.bntTinhTien = new System.Windows.Forms.Button();
            this.bntInHoaDon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmBànMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịBànCóKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịBànChưaCóKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // bntGoiMon
            // 
            this.bntGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("bntGoiMon.Image")));
            this.bntGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGoiMon.Location = new System.Drawing.Point(525, 271);
            this.bntGoiMon.Name = "bntGoiMon";
            this.bntGoiMon.Size = new System.Drawing.Size(120, 58);
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
            this.bntThucDon.Location = new System.Drawing.Point(525, 335);
            this.bntThucDon.Name = "bntThucDon";
            this.bntThucDon.Size = new System.Drawing.Size(120, 58);
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
            this.bntTinhTien.Location = new System.Drawing.Point(525, 399);
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
            this.bntInHoaDon.Location = new System.Drawing.Point(525, 463);
            this.bntInHoaDon.Name = "bntInHoaDon";
            this.bntInHoaDon.Size = new System.Drawing.Size(120, 58);
            this.bntInHoaDon.TabIndex = 5;
            this.bntInHoaDon.Text = "In hóa đơn";
            this.bntInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntInHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(651, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 596);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBànMớiToolStripMenuItem,
            this.hiểnThịBànCóKháchToolStripMenuItem,
            this.hiểnThịBànChưaCóKháchToolStripMenuItem,
            this.hiểnThịTấtCảToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 92);
            // 
            // thêmBànMớiToolStripMenuItem
            // 
            this.thêmBànMớiToolStripMenuItem.Name = "thêmBànMớiToolStripMenuItem";
            this.thêmBànMớiToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thêmBànMớiToolStripMenuItem.Text = "Thêm bàn mới";
            // 
            // hiểnThịBànCóKháchToolStripMenuItem
            // 
            this.hiểnThịBànCóKháchToolStripMenuItem.Name = "hiểnThịBànCóKháchToolStripMenuItem";
            this.hiểnThịBànCóKháchToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hiểnThịBànCóKháchToolStripMenuItem.Text = "Hiển thị bàn có khách";
            // 
            // hiểnThịBànChưaCóKháchToolStripMenuItem
            // 
            this.hiểnThịBànChưaCóKháchToolStripMenuItem.Name = "hiểnThịBànChưaCóKháchToolStripMenuItem";
            this.hiểnThịBànChưaCóKháchToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hiểnThịBànChưaCóKháchToolStripMenuItem.Text = "Hiển thị bàn chưa có khách";
            // 
            // hiểnThịTấtCảToolStripMenuItem
            // 
            this.hiểnThịTấtCảToolStripMenuItem.Name = "hiểnThịTấtCảToolStripMenuItem";
            this.hiểnThịTấtCảToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hiểnThịTấtCảToolStripMenuItem.Text = "Hiển thị tất cả";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntInHoaDon);
            this.Controls.Add(this.bntTinhTien);
            this.Controls.Add(this.bntThucDon);
            this.Controls.Add(this.bntGoiMon);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán bida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntGoiMon;
        private System.Windows.Forms.Button bntThucDon;
        private System.Windows.Forms.Button bntTinhTien;
        private System.Windows.Forms.Button bntInHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmBànMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànCóKháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànChưaCóKháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịTấtCảToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}
