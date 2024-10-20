namespace _21_WinForm
{
    partial class Register
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
            btn_register = new Button();
            groupBox1 = new GroupBox();
            cmb_branch = new ComboBox();
            label3 = new Label();
            txt_surname = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Location = new Point(283, 197);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(157, 35);
            btn_register.TabIndex = 6;
            btn_register.Text = "Kayıt Ol";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(cmb_branch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_surname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 260);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Kayıt Paneli";
            // 
            // cmb_branch
            // 
            cmb_branch.FormattingEnabled = true;
            cmb_branch.Items.AddRange(new object[] { "Yazılım", "Tekstil", "Çocuk Gelişimi", "Grafik", "Motor", "Elektrik" });
            cmb_branch.Location = new Point(133, 131);
            cmb_branch.Name = "cmb_branch";
            cmb_branch.Size = new Size(307, 33);
            cmb_branch.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 132);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "Bölüm:";
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(133, 79);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(307, 33);
            txt_surname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(133, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(307, 33);
            txt_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 290);
            Controls.Add(groupBox1);
            Name = "Register";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_register;
        private GroupBox groupBox1;
        private ComboBox cmb_branch;
        private Label label3;
        private TextBox txt_surname;
        private Label label2;
        private TextBox txt_name;
        private Label label1;
    }
}