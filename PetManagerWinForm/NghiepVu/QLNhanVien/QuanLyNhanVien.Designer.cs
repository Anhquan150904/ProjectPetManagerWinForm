namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    partial class QuanLyNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            clmID = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmAddress = new DataGridViewTextBoxColumn();
            clmPhone = new DataGridViewTextBoxColumn();
            clmSex = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmPosition = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            textID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textName = new TextBox();
            label3 = new Label();
            textAddress = new TextBox();
            label4 = new Label();
            textPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textEmail = new TextBox();
            label7 = new Label();
            textPosition = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            button5 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button6 = new Button();
            comboBox1 = new ComboBox();
            label9 = new Label();
            btnTinhLuong = new Button();
            btnChamCong = new Button();
            btnPhanCa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmID, clmName, clmAddress, clmPhone, clmSex, clmEmail, clmPosition, clmStatus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(1128, 978);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clmID
            // 
            clmID.HeaderText = "ID";
            clmID.Name = "clmID";
            clmID.ReadOnly = true;
            clmID.Width = 60;
            // 
            // clmName
            // 
            clmName.HeaderText = "Tên nhân viên";
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            clmName.Width = 200;
            // 
            // clmAddress
            // 
            clmAddress.HeaderText = "Địa chỉ";
            clmAddress.Name = "clmAddress";
            clmAddress.ReadOnly = true;
            clmAddress.Width = 180;
            // 
            // clmPhone
            // 
            clmPhone.HeaderText = "Số điện thoại";
            clmPhone.Name = "clmPhone";
            clmPhone.ReadOnly = true;
            clmPhone.Width = 140;
            // 
            // clmSex
            // 
            clmSex.HeaderText = "Giới tính";
            clmSex.Name = "clmSex";
            clmSex.ReadOnly = true;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            clmEmail.Width = 150;
            // 
            // clmPosition
            // 
            clmPosition.HeaderText = "Vị trí";
            clmPosition.Name = "clmPosition";
            clmPosition.ReadOnly = true;
            clmPosition.Width = 140;
            // 
            // clmStatus
            // 
            clmStatus.HeaderText = "Trạng thái";
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            clmStatus.Width = 115;
            // 
            // textID
            // 
            textID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textID.Location = new Point(1275, 138);
            textID.Name = "textID";
            textID.Size = new Size(251, 29);
            textID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1172, 141);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1172, 204);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 4;
            label2.Text = "Tên:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(1275, 201);
            textName.Name = "textName";
            textName.Size = new Size(251, 29);
            textName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1172, 267);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAddress.Location = new Point(1275, 264);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(251, 29);
            textAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1172, 330);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 8;
            label4.Text = "Số điện thoại:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPhone
            // 
            textPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPhone.Location = new Point(1275, 327);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(251, 29);
            textPhone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1172, 392);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 10;
            label5.Text = "Giới tính:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1172, 452);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 12;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(1275, 449);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(251, 29);
            textEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1172, 515);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 14;
            label7.Text = "Vị trí:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPosition
            // 
            textPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPosition.Location = new Point(1275, 512);
            textPosition.Name = "textPosition";
            textPosition.Size = new Size(251, 29);
            textPosition.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1172, 645);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 15;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1298, 645);
            button2.Name = "button2";
            button2.Size = new Size(102, 29);
            button2.TabIndex = 16;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpt_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(1451, 575);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 17;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDel_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1172, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 29);
            textBox1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1172, 51);
            label8.Name = "label8";
            label8.Size = new Size(238, 21);
            label8.TabIndex = 20;
            label8.Text = "Tìm kiếm nhân viên (id/tên/vị trí)\r\n";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1472, 75);
            button5.Name = "button5";
            button5.Size = new Size(54, 29);
            button5.TabIndex = 21;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnSearch_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(1275, 390);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 25);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(1384, 390);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 25);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(1424, 645);
            button6.Name = "button6";
            button6.Size = new Size(102, 29);
            button6.TabIndex = 24;
            button6.Text = "Làm mới";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnReset_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chưa xác định", "Đang làm", "Đã nghỉ" });
            comboBox1.Location = new Point(1275, 575);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 29);
            comboBox1.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1172, 578);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 26;
            label9.Text = "Trạng thái";
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinhLuong.Location = new Point(1424, 705);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(102, 29);
            btnTinhLuong.TabIndex = 29;
            btnTinhLuong.Text = "Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = true;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChamCong.Location = new Point(1298, 705);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(102, 29);
            btnChamCong.TabIndex = 28;
            btnChamCong.Text = "Chấm công";
            btnChamCong.UseVisualStyleBackColor = true;
            btnChamCong.Click += this.btnChamCong_Click;
            // 
            // btnPhanCa
            // 
            btnPhanCa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhanCa.Location = new Point(1172, 705);
            btnPhanCa.Name = "btnPhanCa";
            btnPhanCa.Size = new Size(102, 29);
            btnPhanCa.TabIndex = 27;
            btnPhanCa.Text = "Phân ca";
            btnPhanCa.UseVisualStyleBackColor = true;
            btnPhanCa.Click += this.btnPhanCa_Click;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1538, 1002);
            Controls.Add(btnTinhLuong);
            Controls.Add(btnChamCong);
            Controls.Add(btnPhanCa);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textPosition);
            Controls.Add(label6);
            Controls.Add(textEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textPhone);
            Controls.Add(label3);
            Controls.Add(textAddress);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            Controls.Add(textID);
            Controls.Add(dataGridView1);
            Name = "QuanLyNhanVien";
            Text = "Quan Ly Nhan Vien";
            Load += QuanLyNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textID;
        private Label label1;
        private Label label2;
        private TextBox textName;
        private Label label3;
        private TextBox textAddress;
        private Label label4;
        private TextBox textPhone;
        private Label label5;
        private Label label6;
        private TextBox textEmail;
        private Label label7;
        private TextBox textPosition;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label8;
        private Button button5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button6;
        private ComboBox comboBox1;
        private Label label9;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmAddress;
        private DataGridViewTextBoxColumn clmPhone;
        private DataGridViewTextBoxColumn clmSex;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmPosition;
        private DataGridViewTextBoxColumn clmStatus;
        private Button btnTinhLuong;
        private Button btnChamCong;
        private Button btnPhanCa;
    }
}