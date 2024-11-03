namespace _24_Rent_A_Car
{
    partial class ArabaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArabaForm));
            dt_araba = new DataGridView();
            cmb_marka = new ComboBox();
            button2 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            label1 = new Label();
            txt_karaba = new TextBox();
            label2 = new Label();
            dt_baslaTarih = new DateTimePicker();
            dt_bitisTarih = new DateTimePicker();
            label3 = new Label();
            txt_ktoplamSaat = new TextBox();
            label4 = new Label();
            txt_ktoplam = new TextBox();
            label5 = new Label();
            btn_kirala = new Button();
            dt_bitisSaat = new DateTimePicker();
            dt_baslaSaat = new DateTimePicker();
            btn_hesapla = new Button();
            ((System.ComponentModel.ISupportInitialize)dt_araba).BeginInit();
            SuspendLayout();
            // 
            // dt_araba
            // 
            dt_araba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_araba.Location = new Point(30, 110);
            dt_araba.MultiSelect = false;
            dt_araba.Name = "dt_araba";
            dt_araba.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_araba.Size = new Size(875, 404);
            dt_araba.TabIndex = 0;
            dt_araba.DoubleClick += dt_araba_DoubleClick;
            // 
            // cmb_marka
            // 
            cmb_marka.Font = new Font("Segoe UI", 12F);
            cmb_marka.FormattingEnabled = true;
            cmb_marka.Location = new Point(201, 22);
            cmb_marka.Name = "cmb_marka";
            cmb_marka.Size = new Size(184, 29);
            cmb_marka.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(201, 57);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 3;
            button2.Text = "Araba Getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(927, 113);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 4;
            label1.Text = "Araç:";
            // 
            // txt_karaba
            // 
            txt_karaba.Enabled = false;
            txt_karaba.Font = new Font("Segoe UI", 12F);
            txt_karaba.Location = new Point(1048, 110);
            txt_karaba.Name = "txt_karaba";
            txt_karaba.Size = new Size(256, 29);
            txt_karaba.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(927, 169);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 6;
            label2.Text = "Kiralama Tarihi:";
            // 
            // dt_baslaTarih
            // 
            dt_baslaTarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dt_baslaTarih.Format = DateTimePickerFormat.Short;
            dt_baslaTarih.Location = new Point(1048, 163);
            dt_baslaTarih.Name = "dt_baslaTarih";
            dt_baslaTarih.Size = new Size(125, 29);
            dt_baslaTarih.TabIndex = 7;
            // 
            // dt_bitisTarih
            // 
            dt_bitisTarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dt_bitisTarih.Format = DateTimePickerFormat.Short;
            dt_bitisTarih.Location = new Point(1048, 214);
            dt_bitisTarih.Name = "dt_bitisTarih";
            dt_bitisTarih.Size = new Size(125, 29);
            dt_bitisTarih.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(927, 220);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 8;
            label3.Text = "Teslim Tarihi:";
            // 
            // txt_ktoplamSaat
            // 
            txt_ktoplamSaat.Enabled = false;
            txt_ktoplamSaat.Font = new Font("Segoe UI", 12F);
            txt_ktoplamSaat.Location = new Point(1048, 270);
            txt_ktoplamSaat.Name = "txt_ktoplamSaat";
            txt_ktoplamSaat.Size = new Size(256, 29);
            txt_ktoplamSaat.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(927, 273);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 10;
            label4.Text = "Toplam Saat:";
            // 
            // txt_ktoplam
            // 
            txt_ktoplam.Enabled = false;
            txt_ktoplam.Font = new Font("Segoe UI", 12F);
            txt_ktoplam.Location = new Point(1048, 323);
            txt_ktoplam.Name = "txt_ktoplam";
            txt_ktoplam.Size = new Size(256, 29);
            txt_ktoplam.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(927, 326);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 12;
            label5.Text = "Toplam Tutar:";
            // 
            // btn_kirala
            // 
            btn_kirala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_kirala.Location = new Point(927, 383);
            btn_kirala.Name = "btn_kirala";
            btn_kirala.Size = new Size(175, 38);
            btn_kirala.TabIndex = 14;
            btn_kirala.Text = "KİRALA";
            btn_kirala.UseVisualStyleBackColor = true;
            btn_kirala.Click += btn_kirala_Click;
            // 
            // dt_bitisSaat
            // 
            dt_bitisSaat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dt_bitisSaat.Format = DateTimePickerFormat.Time;
            dt_bitisSaat.Location = new Point(1179, 214);
            dt_bitisSaat.Name = "dt_bitisSaat";
            dt_bitisSaat.Size = new Size(125, 29);
            dt_bitisSaat.TabIndex = 16;
            // 
            // dt_baslaSaat
            // 
            dt_baslaSaat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dt_baslaSaat.Format = DateTimePickerFormat.Time;
            dt_baslaSaat.Location = new Point(1179, 163);
            dt_baslaSaat.Name = "dt_baslaSaat";
            dt_baslaSaat.Size = new Size(125, 29);
            dt_baslaSaat.TabIndex = 15;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_hesapla.Location = new Point(1129, 383);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(175, 38);
            btn_hesapla.TabIndex = 17;
            btn_hesapla.Text = "HESAPLA";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // ArabaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 631);
            Controls.Add(btn_hesapla);
            Controls.Add(dt_bitisSaat);
            Controls.Add(dt_baslaSaat);
            Controls.Add(btn_kirala);
            Controls.Add(txt_ktoplam);
            Controls.Add(label5);
            Controls.Add(txt_ktoplamSaat);
            Controls.Add(label4);
            Controls.Add(dt_bitisTarih);
            Controls.Add(label3);
            Controls.Add(dt_baslaTarih);
            Controls.Add(label2);
            Controls.Add(txt_karaba);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(cmb_marka);
            Controls.Add(dt_araba);
            Name = "ArabaForm";
            Text = "ArabaForm";
            Load += ArabaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dt_araba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dt_araba;
        private ComboBox cmb_marka;
        private Button button2;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private TextBox txt_karaba;
        private Label label2;
        private DateTimePicker dt_baslaTarih;
        private DateTimePicker dt_bitisTarih;
        private Label label3;
        private TextBox txt_ktoplamSaat;
        private Label label4;
        private TextBox txt_ktoplam;
        private Label label5;
        private Button btn_kirala;
        private DateTimePicker dt_bitisSaat;
        private DateTimePicker dt_baslaSaat;
        private Button btn_hesapla;
    }
}