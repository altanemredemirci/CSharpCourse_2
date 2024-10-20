namespace _21_WinForm
{
    partial class Teacher
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
            btn_register = new Button();
            dt_teachers = new DataGridView();
            msk_phone = new MaskedTextBox();
            label6 = new Label();
            dt_birthDate = new DateTimePicker();
            label5 = new Label();
            nmr_experience = new NumericUpDown();
            label4 = new Label();
            chc_CSharp = new CheckBox();
            chc_net = new CheckBox();
            label3 = new Label();
            chc_sql = new CheckBox();
            chc_java = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt_teachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_experience).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(dt_teachers);
            groupBox1.Controls.Add(msk_phone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dt_birthDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nmr_experience);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1052, 521);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÖĞRETMEN KAYIT PANELİ";
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_register.Location = new Point(32, 477);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(420, 38);
            btn_register.TabIndex = 17;
            btn_register.Text = "Kaydet";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // dt_teachers
            // 
            dt_teachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_teachers.Location = new Point(492, 51);
            dt_teachers.Name = "dt_teachers";
            dt_teachers.Size = new Size(540, 464);
            dt_teachers.TabIndex = 16;
            // 
            // msk_phone
            // 
            msk_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            msk_phone.Location = new Point(171, 427);
            msk_phone.Mask = "0000-000-00-00";
            msk_phone.Name = "msk_phone";
            msk_phone.Size = new Size(281, 33);
            msk_phone.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(32, 435);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 14;
            label6.Text = "Telefon No:";
            // 
            // dt_birthDate
            // 
            dt_birthDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dt_birthDate.Location = new Point(171, 366);
            dt_birthDate.Name = "dt_birthDate";
            dt_birthDate.Size = new Size(281, 33);
            dt_birthDate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(28, 372);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 12;
            label5.Text = "Doğum Tarihi:";
            // 
            // nmr_experience
            // 
            nmr_experience.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nmr_experience.Location = new Point(171, 300);
            nmr_experience.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            nmr_experience.Name = "nmr_experience";
            nmr_experience.Size = new Size(281, 33);
            nmr_experience.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(28, 302);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 10;
            label4.Text = "Deneyim:";
            // 
            // chc_CSharp
            // 
            chc_CSharp.AutoSize = true;
            chc_CSharp.Font = new Font("Segoe UI", 14.25F);
            chc_CSharp.Location = new Point(120, 67);
            chc_CSharp.Name = "chc_CSharp";
            chc_CSharp.Size = new Size(54, 29);
            chc_CSharp.TabIndex = 9;
            chc_CSharp.Text = "C#";
            chc_CSharp.UseVisualStyleBackColor = true;
            // 
            // chc_net
            // 
            chc_net.AutoSize = true;
            chc_net.Font = new Font("Segoe UI", 14.25F);
            chc_net.Location = new Point(120, 22);
            chc_net.Name = "chc_net";
            chc_net.Size = new Size(65, 29);
            chc_net.TabIndex = 8;
            chc_net.Text = ".Net";
            chc_net.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(28, 167);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 7;
            label3.Text = "Yetenekler:";
            // 
            // chc_sql
            // 
            chc_sql.AutoSize = true;
            chc_sql.Font = new Font("Segoe UI", 14.25F);
            chc_sql.Location = new Point(26, 67);
            chc_sql.Name = "chc_sql";
            chc_sql.Size = new Size(64, 29);
            chc_sql.TabIndex = 6;
            chc_sql.Text = "SQL";
            chc_sql.UseVisualStyleBackColor = true;
            // 
            // chc_java
            // 
            chc_java.AutoSize = true;
            chc_java.Font = new Font("Segoe UI", 14.25F);
            chc_java.Location = new Point(26, 22);
            chc_java.Name = "chc_java";
            chc_java.Size = new Size(67, 29);
            chc_java.TabIndex = 5;
            chc_java.Text = "Java";
            chc_java.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14.25F);
            radioButton2.Location = new Point(267, 104);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 29);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 14.25F);
            radioButton1.Location = new Point(154, 104);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(28, 108);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Cinsiyet:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(171, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 33);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chc_java);
            groupBox2.Controls.Add(chc_sql);
            groupBox2.Controls.Add(chc_net);
            groupBox2.Controls.Add(chc_CSharp);
            groupBox2.Location = new Point(180, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 119);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 556);
            Controls.Add(groupBox1);
            Name = "Teacher";
            Text = "Teacher";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt_teachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_experience).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private CheckBox chc_sql;
        private CheckBox chc_java;
        private CheckBox chc_CSharp;
        private CheckBox chc_net;
        private MaskedTextBox msk_phone;
        private Label label6;
        private DateTimePicker dt_birthDate;
        private Label label5;
        private NumericUpDown nmr_experience;
        private Label label4;
        private Button btn_register;
        private DataGridView dt_teachers;
        private GroupBox groupBox2;
    }
}