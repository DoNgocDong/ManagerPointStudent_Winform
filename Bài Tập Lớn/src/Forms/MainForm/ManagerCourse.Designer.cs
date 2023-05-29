﻿namespace BaiTapLon_CSharp.src.Forms.MainForm
{
    partial class ManagerCourse
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(145, 89);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(141, 56);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(335, 89);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(141, 56);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(525, 89);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(141, 56);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(38, 187);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(161, 32);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm kiếm Tên Môn";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMon,
            this.tenMon,
            this.soTinChi});
            this.DGV.Location = new System.Drawing.Point(2, 266);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(797, 182);
            this.DGV.TabIndex = 5;
            // 
            // maMon
            // 
            this.maMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maMon.DataPropertyName = "maMon";
            this.maMon.HeaderText = "Mã Môn";
            this.maMon.MinimumWidth = 8;
            this.maMon.Name = "maMon";
            // 
            // tenMon
            // 
            this.tenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMon.DataPropertyName = "tenMon";
            this.tenMon.HeaderText = "Tên Môn";
            this.tenMon.MinimumWidth = 8;
            this.tenMon.Name = "tenMon";
            // 
            // soTinChi
            // 
            this.soTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soTinChi.DataPropertyName = "soTinChi";
            this.soTinChi.HeaderText = "Số tín chỉ";
            this.soTinChi.MinimumWidth = 8;
            this.soTinChi.Name = "soTinChi";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(242, 190);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(283, 26);
            this.txttimkiem.TabIndex = 6;
            // 
            // ManagerCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Name = "ManagerCourse";
            this.Text = "ManagerCourse";
            this.Load += new System.EventHandler(this.ManagerCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChi;
    }
}