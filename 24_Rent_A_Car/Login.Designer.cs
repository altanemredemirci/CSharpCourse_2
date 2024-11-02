namespace _24_Rent_A_Car
{
    partial class Login
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
            groupBox1 = new GroupBox();
            btn_login = new Button();
            txt_password = new TextBox();
            label2 = new Label();
            txt_phone = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_Rbalance = new TextBox();
            label7 = new Label();
            btn_register = new Button();
            txt_Rpass2 = new TextBox();
            label3 = new Label();
            txt_Rpass = new TextBox();
            label5 = new Label();
            txt_Rphone = new TextBox();
            label6 = new Label();
            txt_Rname = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(74, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MÜŞTERİ GİRİŞ";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(100, 153);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(190, 37);
            btn_login.TabIndex = 4;
            btn_login.Text = "GİRİŞ";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(95, 102);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(195, 29);
            txt_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(95, 58);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(195, 29);
            txt_phone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 61);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "Telefon:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_Rbalance);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btn_register);
            groupBox2.Controls.Add(txt_Rpass2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_Rpass);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_Rphone);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_Rname);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(547, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 388);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "MÜŞTERİ KAYIT";
            // 
            // txt_Rbalance
            // 
            txt_Rbalance.Location = new Point(123, 223);
            txt_Rbalance.Name = "txt_Rbalance";
            txt_Rbalance.Size = new Size(195, 29);
            txt_Rbalance.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 226);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 11;
            label7.Text = "Bakiye:";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(123, 273);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(195, 36);
            btn_register.TabIndex = 4;
            btn_register.Text = "KAYIT OL";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txt_Rpass2
            // 
            txt_Rpass2.Location = new Point(123, 182);
            txt_Rpass2.Name = "txt_Rpass2";
            txt_Rpass2.PasswordChar = '*';
            txt_Rpass2.Size = new Size(195, 29);
            txt_Rpass2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 185);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 9;
            label3.Text = "Tekrar Şifre:";
            // 
            // txt_Rpass
            // 
            txt_Rpass.Location = new Point(123, 141);
            txt_Rpass.Name = "txt_Rpass";
            txt_Rpass.PasswordChar = '*';
            txt_Rpass.Size = new Size(195, 29);
            txt_Rpass.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 144);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 7;
            label5.Text = "Şifre:";
            // 
            // txt_Rphone
            // 
            txt_Rphone.Location = new Point(123, 97);
            txt_Rphone.Name = "txt_Rphone";
            txt_Rphone.Size = new Size(195, 29);
            txt_Rphone.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 100);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 5;
            label6.Text = "Telefon:";
            // 
            // txt_Rname
            // 
            txt_Rname.Location = new Point(123, 58);
            txt_Rname.Name = "txt_Rname";
            txt_Rname.Size = new Size(195, 29);
            txt_Rname.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 61);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 0;
            label4.Text = "AdSoyad:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 593);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_phone;
        private Label label1;
        private Button btn_login;
        private TextBox txt_password;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_register;
        private TextBox txt_Rname;
        private Label label4;
        private TextBox txt_Rpass2;
        private Label label3;
        private TextBox txt_Rpass;
        private Label label5;
        private TextBox txt_Rphone;
        private Label label6;
        private TextBox txt_Rbalance;
        private Label label7;
    }
}