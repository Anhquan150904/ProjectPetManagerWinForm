namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    partial class FormTinhLuong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lblPosition = new Label();
            lblName = new Label();
            lblID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnTinhLuong = new Button();
            cmbNam = new ComboBox();
            label5 = new Label();
            cmbThang = new ComboBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            lblThucLanh = new Label();
            label15 = new Label();
            txtPhat = new TextBox();
            label14 = new Label();
            txtThuong = new TextBox();
            label13 = new Label();
            lblPhuCap = new Label();
            label11 = new Label();
            lblLuongCoBan = new Label();
            label9 = new Label();
            lblDonGia = new Label();
            label7 = new Label();
            lblTongGio = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewChiTiet = new DataGridView();
            colNgay = new DataGridViewTextBoxColumn();
            colGioVao = new DataGridViewTextBoxColumn();
            colGioRa = new DataGridViewTextBoxColumn();
            colTongGio = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            btnDong = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTiet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPosition);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1076, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.Blue;
            lblPosition.Location = new Point(800, 40);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(28, 21);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "---";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Blue;
            lblName.Location = new Point(420, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(28, 21);
            lblName.TabIndex = 4;
            lblName.Text = "---";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Blue;
            lblID.Location = new Point(80, 40);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 21);
            lblID.TabIndex = 3;
            lblID.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(730, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "Vị trí:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 40);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTinhLuong);
            groupBox2.Controls.Add(cmbNam);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbThang);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn kỳ tính lương";
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.BackColor = Color.Green;
            btnTinhLuong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhLuong.ForeColor = Color.White;
            btnTinhLuong.Location = new Point(700, 35);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(150, 40);
            btnTinhLuong.TabIndex = 4;
            btnTinhLuong.Text = "Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = false;
            // 
            // cmbNam
            // 
            cmbNam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNam.FormattingEnabled = true;
            cmbNam.Location = new Point(420, 40);
            cmbNam.Name = "cmbNam";
            cmbNam.Size = new Size(200, 29);
            cmbNam.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 43);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 2;
            label5.Text = "Năm:";
            // 
            // cmbThang
            // 
            cmbThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbThang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbThang.FormattingEnabled = true;
            cmbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbThang.Location = new Point(100, 40);
            cmbThang.Name = "cmbThang";
            cmbThang.Size = new Size(200, 29);
            cmbThang.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 43);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 0;
            label4.Text = "Tháng:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblThucLanh);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtPhat);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtThuong);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(lblPhuCap);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lblLuongCoBan);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblDonGia);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lblTongGio);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1076, 180);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tính toán lương";
            // 
            // lblThucLanh
            // 
            lblThucLanh.AutoSize = true;
            lblThucLanh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThucLanh.ForeColor = Color.Red;
            lblThucLanh.Location = new Point(750, 125);
            lblThucLanh.Name = "lblThucLanh";
            lblThucLanh.Size = new Size(88, 32);
            lblThucLanh.TabIndex = 13;
            lblThucLanh.Text = "0 VNĐ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(600, 130);
            label15.Name = "label15";
            label15.Size = new Size(156, 25);
            label15.TabIndex = 12;
            label15.Text = "Tiền được nhận:";
            // 
            // txtPhat
            // 
            txtPhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhat.Location = new Point(420, 127);
            txtPhat.Name = "txtPhat";
            txtPhat.Size = new Size(150, 29);
            txtPhat.TabIndex = 11;
            txtPhat.Text = "0";
            txtPhat.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(350, 130);
            label14.Name = "label14";
            label14.Size = new Size(44, 21);
            label14.TabIndex = 10;
            label14.Text = "Phạt:";
            // 
            // txtThuong
            // 
            txtThuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThuong.Location = new Point(420, 85);
            txtThuong.Name = "txtThuong";
            txtThuong.Size = new Size(150, 29);
            txtThuong.TabIndex = 9;
            txtThuong.Text = "0";
            txtThuong.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(350, 88);
            label13.Name = "label13";
            label13.Size = new Size(67, 21);
            label13.TabIndex = 8;
            label13.Text = "Thưởng:";
            // 
            // lblPhuCap
            // 
            lblPhuCap.AutoSize = true;
            lblPhuCap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhuCap.ForeColor = Color.Green;
            lblPhuCap.Location = new Point(420, 43);
            lblPhuCap.Name = "lblPhuCap";
            lblPhuCap.Size = new Size(59, 21);
            lblPhuCap.TabIndex = 7;
            lblPhuCap.Text = "0 VNĐ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(350, 43);
            label11.Name = "label11";
            label11.Size = new Size(68, 21);
            label11.TabIndex = 6;
            label11.Text = "Phụ cấp:";
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.AutoSize = true;
            lblLuongCoBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuongCoBan.ForeColor = Color.Green;
            lblLuongCoBan.Location = new Point(750, 43);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(59, 21);
            lblLuongCoBan.TabIndex = 5;
            lblLuongCoBan.Text = "0 VNĐ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(600, 43);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 4;
            label9.Text = "Lương cơ bản:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonGia.ForeColor = Color.Blue;
            lblDonGia.Location = new Point(100, 88);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(90, 21);
            lblDonGia.TabIndex = 3;
            lblDonGia.Text = "25,000 đ/h";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 88);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 2;
            label7.Text = "Đơn giá:";
            // 
            // lblTongGio
            // 
            lblTongGio.AutoSize = true;
            lblTongGio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongGio.ForeColor = Color.Blue;
            lblTongGio.Location = new Point(100, 43);
            lblTongGio.Name = "lblTongGio";
            lblTongGio.Size = new Size(61, 21);
            lblTongGio.TabIndex = 1;
            lblTongGio.Text = "0.0 giờ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 43);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 0;
            label6.Text = "Tổng giờ:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewChiTiet);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox4.Location = new Point(12, 410);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1076, 300);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chi tiết chấm công trong tháng";
            // 
            // dataGridViewChiTiet
            // 
            dataGridViewChiTiet.AllowUserToAddRows = false;
            dataGridViewChiTiet.AllowUserToDeleteRows = false;
            dataGridViewChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChiTiet.Columns.AddRange(new DataGridViewColumn[] { colNgay, colGioVao, colGioRa, colTongGio, colThanhTien });
            dataGridViewChiTiet.Location = new Point(20, 30);
            dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            dataGridViewChiTiet.ReadOnly = true;
            dataGridViewChiTiet.RowTemplate.Height = 35;
            dataGridViewChiTiet.Size = new Size(1036, 250);
            dataGridViewChiTiet.TabIndex = 0;
            // 
            // colNgay
            // 
            colNgay.HeaderText = "Ngày";
            colNgay.Name = "colNgay";
            colNgay.ReadOnly = true;
            // 
            // colGioVao
            // 
            colGioVao.HeaderText = "Giờ vào";
            colGioVao.Name = "colGioVao";
            colGioVao.ReadOnly = true;
            // 
            // colGioRa
            // 
            colGioRa.HeaderText = "Giờ ra";
            colGioRa.Name = "colGioRa";
            colGioRa.ReadOnly = true;
            // 
            // colTongGio
            // 
            colTongGio.HeaderText = "Tổng giờ";
            colTongGio.Name = "colTongGio";
            colTongGio.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(968, 725);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(120, 40);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(32, 738);
            label8.Name = "label8";
            label8.Size = new Size(588, 17);
            label8.TabIndex = 6;
            label8.Text = "Công thức: Lương = (Tổng giờ × Đơn giá) + Phụ cấp + Thưởng - Phạt | Đơn giá mặc định: 25,000đ/giờ";
            // 
            // FormTinhLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 775);
            Controls.Add(label8);
            Controls.Add(btnDong);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormTinhLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính lương nhân viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongGio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblThucLanh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label8;
    }
}