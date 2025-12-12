namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    partial class FormChamCong
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lblPosition = new Label();
            lblName = new Label();
            lblID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtGhiChu = new TextBox();
            label10 = new Label();
            lblTongGio = new Label();
            label8 = new Label();
            btnGioRa = new Button();
            btnGioVao = new Button();
            dtpGioRa = new DateTimePicker();
            label7 = new Label();
            dtpGioVao = new DateTimePicker();
            label6 = new Label();
            dtpNgay = new DateTimePicker();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridViewLichSu = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNgay = new DataGridViewTextBoxColumn();
            colGioVao = new DataGridViewTextBoxColumn();
            colGioRa = new DataGridViewTextBoxColumn();
            colTongGio = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            btnLuu = new Button();
            btnXoa = new Button();
            btnDong = new Button();
            label4 = new Label();
            lblTongGioThang = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLichSu).BeginInit();
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
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblTongGio);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnGioRa);
            groupBox2.Controls.Add(btnGioVao);
            groupBox2.Controls.Add(dtpGioRa);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dtpGioVao);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpNgay);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chấm công hôm nay";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChu.Location = new Point(130, 165);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(920, 29);
            txtGhiChu.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 168);
            label10.Name = "label10";
            label10.Size = new Size(66, 21);
            label10.TabIndex = 10;
            label10.Text = "Ghi chú:";
            // 
            // lblTongGio
            // 
            lblTongGio.AutoSize = true;
            lblTongGio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongGio.ForeColor = Color.Green;
            lblTongGio.Location = new Point(730, 125);
            lblTongGio.Name = "lblTongGio";
            lblTongGio.Size = new Size(73, 25);
            lblTongGio.TabIndex = 9;
            lblTongGio.Text = "0.0 giờ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(620, 127);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 8;
            label8.Text = "Tổng giờ:";
            // 
            // btnGioRa
            // 
            btnGioRa.BackColor = Color.OrangeRed;
            btnGioRa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGioRa.ForeColor = Color.White;
            btnGioRa.Location = new Point(440, 120);
            btnGioRa.Name = "btnGioRa";
            btnGioRa.Size = new Size(150, 35);
            btnGioRa.TabIndex = 7;
            btnGioRa.Text = "Check-out";
            btnGioRa.UseVisualStyleBackColor = false;
            // 
            // btnGioVao
            // 
            btnGioVao.BackColor = Color.Green;
            btnGioVao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGioVao.ForeColor = Color.White;
            btnGioVao.Location = new Point(440, 75);
            btnGioVao.Name = "btnGioVao";
            btnGioVao.Size = new Size(150, 35);
            btnGioVao.TabIndex = 6;
            btnGioVao.Text = "Check-in";
            btnGioVao.UseVisualStyleBackColor = false;
            // 
            // dtpGioRa
            // 
            dtpGioRa.CustomFormat = "HH:mm";
            dtpGioRa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpGioRa.Format = DateTimePickerFormat.Custom;
            dtpGioRa.Location = new Point(130, 122);
            dtpGioRa.Name = "dtpGioRa";
            dtpGioRa.ShowUpDown = true;
            dtpGioRa.Size = new Size(280, 29);
            dtpGioRa.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 127);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 4;
            label7.Text = "Giờ ra:";
            // 
            // dtpGioVao
            // 
            dtpGioVao.CustomFormat = "HH:mm";
            dtpGioVao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpGioVao.Format = DateTimePickerFormat.Custom;
            dtpGioVao.Location = new Point(130, 78);
            dtpGioVao.Name = "dtpGioVao";
            dtpGioVao.ShowUpDown = true;
            dtpGioVao.Size = new Size(280, 29);
            dtpGioVao.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 83);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 2;
            label6.Text = "Giờ vào:";
            // 
            // dtpNgay
            // 
            dtpNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(130, 35);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(280, 29);
            dtpNgay.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 39);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 0;
            label5.Text = "Ngày:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewLichSu);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 344);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1076, 350);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lịch sử chấm công";
            // 
            // dataGridViewLichSu
            // 
            dataGridViewLichSu.AllowUserToAddRows = false;
            dataGridViewLichSu.AllowUserToDeleteRows = false;
            dataGridViewLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLichSu.Columns.AddRange(new DataGridViewColumn[] { colID, colNgay, colGioVao, colGioRa, colTongGio, colGhiChu });
            dataGridViewLichSu.Location = new Point(20, 30);
            dataGridViewLichSu.MultiSelect = false;
            dataGridViewLichSu.Name = "dataGridViewLichSu";
            dataGridViewLichSu.ReadOnly = true;
            dataGridViewLichSu.RowTemplate.Height = 35;
            dataGridViewLichSu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLichSu.Size = new Size(1036, 300);
            dataGridViewLichSu.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
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
            // colGhiChu
            // 
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.Name = "colGhiChu";
            colGhiChu.ReadOnly = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(688, 710);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(828, 710);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(968, 710);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(120, 40);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 720);
            label4.Name = "label4";
            label4.Size = new Size(163, 21);
            label4.TabIndex = 6;
            label4.Text = "Tổng giờ tháng này:";
            // 
            // lblTongGioThang
            // 
            lblTongGioThang.AutoSize = true;
            lblTongGioThang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongGioThang.ForeColor = Color.Green;
            lblTongGioThang.Location = new Point(230, 718);
            lblTongGioThang.Name = "lblTongGioThang";
            lblTongGioThang.Size = new Size(73, 25);
            lblTongGioThang.TabIndex = 7;
            lblTongGioThang.Text = "0.0 giờ";
            // 
            // FormChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 765);
            Controls.Add(lblTongGioThang);
            Controls.Add(label4);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chấm công nhân viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLichSu).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGioVao;
        private System.Windows.Forms.Button btnGioRa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongGio;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongGioThang;
    }
}