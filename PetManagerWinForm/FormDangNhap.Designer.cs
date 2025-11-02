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
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(317, 293);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(161, 49);
            btn_DangNhap.TabIndex = 0;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 168);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 231);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(262, 165);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(325, 27);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(263, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(325, 27);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 121);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập tài khoản và mật khẩu";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_DangNhap);
            Name = "FormDangNhap";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DangNhap;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label3;
    }
}
