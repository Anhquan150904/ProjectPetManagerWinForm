namespace PetManagerWinForm
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_DangNhap = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(168, 143);
            btn_DangNhap.Margin = new Padding(3, 2, 3, 2);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(141, 37);
            btn_DangNhap.TabIndex = 0;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(3, 103);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(96, 54);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(285, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 100);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btn_DangNhap);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(99, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 210);
            panel1.TabIndex = 6;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_;
            ClientSize = new Size(642, 355);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDangNhap";
            Text = "Đăng Nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_DangNhap;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Panel panel1;
    }
}
