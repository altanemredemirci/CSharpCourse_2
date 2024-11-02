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
            dt_araba = new DataGridView();
            cmb_marka = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dt_araba).BeginInit();
            SuspendLayout();
            // 
            // dt_araba
            // 
            dt_araba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_araba.Location = new Point(30, 110);
            dt_araba.Name = "dt_araba";
            dt_araba.Size = new Size(923, 404);
            dt_araba.TabIndex = 0;
            // 
            // cmb_marka
            // 
            cmb_marka.FormattingEnabled = true;
            cmb_marka.Location = new Point(201, 22);
            cmb_marka.Name = "cmb_marka";
            cmb_marka.Size = new Size(184, 23);
            cmb_marka.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(201, 51);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 3;
            button2.Text = "Araba Getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ArabaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 631);
            Controls.Add(button2);
            Controls.Add(cmb_marka);
            Controls.Add(dt_araba);
            Name = "ArabaForm";
            Text = "ArabaForm";
            Load += ArabaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dt_araba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dt_araba;
        private ComboBox cmb_marka;
        private Button button2;
    }
}