namespace _21_WinForm
{
    partial class AnaForm
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
            lst_ogrenciler = new ListBox();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtgridOgrenciler = new DataGridView();
            btn_ogretmen = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgridOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Location = new Point(68, 555);
            btn_register.Margin = new Padding(4);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(202, 32);
            btn_register.TabIndex = 0;
            btn_register.Text = "Yeni Öğrenci Kaydı";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click_1;
            // 
            // lst_ogrenciler
            // 
            lst_ogrenciler.FormattingEnabled = true;
            lst_ogrenciler.ItemHeight = 21;
            lst_ogrenciler.Location = new Point(68, 78);
            lst_ogrenciler.Name = "lst_ogrenciler";
            lst_ogrenciler.Size = new Size(185, 424);
            lst_ogrenciler.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(454, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 45);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci Listesi";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Location = new Point(358, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(443, 424);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İSİM";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SOYİSİM";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "BÖLÜM";
            // 
            // dtgridOgrenciler
            // 
            dtgridOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridOgrenciler.Location = new Point(905, 84);
            dtgridOgrenciler.Name = "dtgridOgrenciler";
            dtgridOgrenciler.Size = new Size(491, 406);
            dtgridOgrenciler.TabIndex = 4;
            // 
            // btn_ogretmen
            // 
            btn_ogretmen.Location = new Point(854, 555);
            btn_ogretmen.Name = "btn_ogretmen";
            btn_ogretmen.Size = new Size(183, 32);
            btn_ogretmen.TabIndex = 5;
            btn_ogretmen.Text = "Yeni Öğretmen Kaydı";
            btn_ogretmen.UseVisualStyleBackColor = true;
            btn_ogretmen.Click += btn_ogretmen_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 620);
            Controls.Add(btn_ogretmen);
            Controls.Add(dtgridOgrenciler);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(lst_ogrenciler);
            Controls.Add(btn_register);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaForm";
            ((System.ComponentModel.ISupportInitialize)dtgridOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_register;
        private ListBox lst_ogrenciler;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DataGridView dtgridOgrenciler;
        private Button btn_ogretmen;
    }
}