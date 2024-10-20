namespace _21_WinForm
{
    partial class Form1
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
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            groupBox1 = new GroupBox();
            btn_createtable = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_username.Location = new Point(173, 47);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(251, 33);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_password.Location = new Point(173, 111);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(251, 33);
            txt_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(27, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifreniz:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(174, 176);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(250, 34);
            btn_login.TabIndex = 4;
            btn_login.Text = "GİRİŞ";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 229);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "GİRİŞ PANELİ";
            // 
            // btn_createtable
            // 
            btn_createtable.Location = new Point(551, 45);
            btn_createtable.Name = "btn_createtable";
            btn_createtable.Size = new Size(135, 23);
            btn_createtable.TabIndex = 6;
            btn_createtable.Text = "Tablo Oluştur";
            btn_createtable.UseVisualStyleBackColor = true;
            btn_createtable.Click += btn_createtable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 285);
            Controls.Add(btn_createtable);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label2;
        private Button btn_login;
        private GroupBox groupBox1;
        private Button btn_createtable;
    }
}
