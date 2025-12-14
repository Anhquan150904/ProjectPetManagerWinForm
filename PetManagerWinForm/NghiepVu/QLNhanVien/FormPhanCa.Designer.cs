namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    partial class FormPhanCa
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
            groupBox1 = new GroupBox();
            lblPosition = new Label();
            lblName = new Label();
            lblID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridViewLich = new DataGridView();
            colNgay = new DataGridViewTextBoxColumn();
            colThu = new DataGridViewTextBoxColumn();
            colCaSang = new DataGridViewTextBoxColumn();
            colCaChieu = new DataGridViewTextBoxColumn();
            colCaToi = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnXoaCa = new Button();
            btnThemCa = new Button();
            cmbCa = new ComboBox();
            label6 = new Label();
            dtpNgay = new DateTimePicker();
            label5 = new Label();
            btnLuu = new Button();
            btnDong = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLich).BeginInit();
            groupBox3.SuspendLayout();
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
            groupBox1.Size = new Size(976, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.Blue;
            lblPosition.Location = new Point(750, 40);
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
            lblName.Location = new Point(400, 40);
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
            label3.Location = new Point(680, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "Vị trí:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 40);
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
            groupBox2.Controls.Add(dataGridViewLich);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch làm việc";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridViewLich
            // 
            dataGridViewLich.AllowUserToAddRows = false;
            dataGridViewLich.AllowUserToDeleteRows = false;
            dataGridViewLich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLich.Columns.AddRange(new DataGridViewColumn[] { colNgay, colThu, colCaSang, colCaChieu, colCaToi });
            dataGridViewLich.Location = new Point(20, 28);
            dataGridViewLich.MultiSelect = false;
            dataGridViewLich.Name = "dataGridViewLich";
            dataGridViewLich.ReadOnly = true;
            dataGridViewLich.RowTemplate.Height = 40;
            dataGridViewLich.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLich.Size = new Size(936, 402);
            dataGridViewLich.TabIndex = 0;
            // 
            // colNgay
            // 
            colNgay.HeaderText = "Ngày";
            colNgay.Name = "colNgay";
            colNgay.ReadOnly = true;
            // 
            // colThu
            // 
            colThu.HeaderText = "Thứ";
            colThu.Name = "colThu";
            colThu.ReadOnly = true;
            // 
            // colCaSang
            // 
            colCaSang.HeaderText = "Ca Sáng (6h-14h)";
            colCaSang.Name = "colCaSang";
            colCaSang.ReadOnly = true;
            // 
            // colCaChieu
            // 
            colCaChieu.HeaderText = "Ca Chiều (14h-22h)";
            colCaChieu.Name = "colCaChieu";
            colCaChieu.ReadOnly = true;
            // 
            // colCaToi
            // 
            colCaToi.HeaderText = "Ca Tối (22h-6h)";
            colCaToi.Name = "colCaToi";
            colCaToi.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaCa);
            groupBox3.Controls.Add(btnThemCa);
            groupBox3.Controls.Add(cmbCa);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dtpNgay);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 574);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(976, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm/Xóa ca làm việc";
            // 
            // btnXoaCa
            // 
            btnXoaCa.BackColor = Color.Red;
            btnXoaCa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaCa.ForeColor = Color.White;
            btnXoaCa.Location = new Point(840, 40);
            btnXoaCa.Name = "btnXoaCa";
            btnXoaCa.Size = new Size(100, 35);
            btnXoaCa.TabIndex = 5;
            btnXoaCa.Text = "Xóa ca";
            btnXoaCa.UseVisualStyleBackColor = false;
            btnXoaCa.Click += btnXoaCa_Click;
            // 
            // btnThemCa
            // 
            btnThemCa.BackColor = Color.Green;
            btnThemCa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemCa.ForeColor = Color.White;
            btnThemCa.Location = new Point(720, 40);
            btnThemCa.Name = "btnThemCa";
            btnThemCa.Size = new Size(100, 35);
            btnThemCa.TabIndex = 4;
            btnThemCa.Text = "Thêm ca";
            btnThemCa.UseVisualStyleBackColor = false;
            btnThemCa.Click += btnThemCa_Click;
            // 
            // cmbCa
            // 
            cmbCa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCa.FormattingEnabled = true;
            cmbCa.Items.AddRange(new object[] { "Ca Sáng (6h-14h)", "Ca Chiều (14h-22h)", "Ca Tối (22h-6h)" });
            cmbCa.Location = new Point(480, 42);
            cmbCa.Name = "cmbCa";
            cmbCa.Size = new Size(220, 29);
            cmbCa.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(380, 45);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 2;
            label6.Text = "Chọn ca:";
            // 
            // dtpNgay
            // 
            dtpNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(130, 42);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(220, 29);
            dtpNgay.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 45);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 0;
            label5.Text = "Chọn ngày:";
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(732, 690);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu lịch";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(868, 690);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(120, 40);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // FormPhanCa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 745);
            Controls.Add(btnDong);
            Controls.Add(btnLuu);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPhanCa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân ca làm việc";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLich).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridViewLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaSang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaToi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.Button btnThemCa;
        private System.Windows.Forms.Button btnXoaCa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}