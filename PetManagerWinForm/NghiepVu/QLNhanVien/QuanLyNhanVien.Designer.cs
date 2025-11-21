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
            dataGridView1 = new DataGridView();
            textID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textName = new TextBox();
            label3 = new Label();
            textAddress = new TextBox();
            label4 = new Label();
            textPhone = new TextBox();
            label5 = new Label();
            textSex = new TextBox();
            label6 = new Label();
            textEmail = new TextBox();
            label7 = new Label();
            textPosition = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(743, 427);
            dataGridView1.TabIndex = 0;
            // 
            // textID
            // 
            textID.Location = new Point(874, 92);
            textID.Name = "textID";
            textID.Size = new Size(237, 23);
            textID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(778, 95);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(778, 139);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            textName.Location = new Point(874, 136);
            textName.Name = "textName";
            textName.Size = new Size(237, 23);
            textName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(778, 183);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(874, 180);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(237, 23);
            textAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(778, 227);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "PhoneNumber:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(874, 224);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(237, 23);
            textPhone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(778, 271);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 10;
            label5.Text = "Sex:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textSex
            // 
            textSex.Location = new Point(874, 268);
            textSex.Name = "textSex";
            textSex.Size = new Size(237, 23);
            textSex.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(778, 315);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(874, 312);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(237, 23);
            textEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(778, 359);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 14;
            label7.Text = "Position:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPosition
            // 
            textPosition.Location = new Point(874, 356);
            textPosition.Name = "textPosition";
            textPosition.Size = new Size(237, 23);
            textPosition.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(778, 408);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(864, 408);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpt_Click;
            // 
            // button3
            // 
            button3.Location = new Point(950, 408);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDel_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1036, 408);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 18;
            button4.Text = "Detail";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(778, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 23);
            textBox1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(778, 32);
            label8.Name = "label8";
            label8.Size = new Size(183, 15);
            label8.TabIndex = 20;
            label8.Text = "Tìm kiếm nhân viên (id/tên/vị trí)\r\n";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(1071, 50);
            button5.Name = "button5";
            button5.Size = new Size(40, 23);
            button5.TabIndex = 21;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = false;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 454);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textPosition);
            Controls.Add(label6);
            Controls.Add(textEmail);
            Controls.Add(label5);
            Controls.Add(textSex);
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
        private TextBox textSex;
        private Label label6;
        private TextBox textEmail;
        private Label label7;
        private TextBox textPosition;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label8;
        private Button button5;
    }
}