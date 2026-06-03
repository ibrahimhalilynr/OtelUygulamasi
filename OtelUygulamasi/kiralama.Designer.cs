namespace OtelUygulamasi
{
    partial class kiralama
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
            btn_back = new Button();
            db_rooms = new DataGridView();
            date_bitis = new DateTimePicker();
            date_basla = new DateTimePicker();
            btn_kirala = new Button();
            btn_hesapla = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_fiyat = new TextBox();
            label3 = new Label();
            yes = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)db_rooms).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(938, 480);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 0;
            btn_back.Text = "Geri";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // db_rooms
            // 
            db_rooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            db_rooms.Location = new Point(51, 22);
            db_rooms.Name = "db_rooms";
            db_rooms.RowHeadersWidth = 51;
            db_rooms.Size = new Size(799, 309);
            db_rooms.TabIndex = 1;
            db_rooms.DoubleClick += db_rooms_DoubleClick;
            // 
            // date_bitis
            // 
            date_bitis.Location = new Point(51, 467);
            date_bitis.Name = "date_bitis";
            date_bitis.Size = new Size(250, 27);
            date_bitis.TabIndex = 2;
            // 
            // date_basla
            // 
            date_basla.Location = new Point(51, 390);
            date_basla.Name = "date_basla";
            date_basla.Size = new Size(250, 27);
            date_basla.TabIndex = 3;
            // 
            // btn_kirala
            // 
            btn_kirala.Location = new Point(360, 427);
            btn_kirala.Name = "btn_kirala";
            btn_kirala.Size = new Size(139, 67);
            btn_kirala.TabIndex = 4;
            btn_kirala.Text = "Kirala";
            btn_kirala.UseVisualStyleBackColor = true;
            btn_kirala.Click += btn_kirala_Click;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(902, 214);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(130, 55);
            btn_hesapla.TabIndex = 5;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(51, 367);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 6;
            label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(51, 444);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Bitiş Tarihi";
            // 
            // txt_fiyat
            // 
            txt_fiyat.Location = new Point(902, 90);
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(130, 27);
            txt_fiyat.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(562, 381);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 9;
            label3.Text = "Ödeme Alındı mı?";
            // 
            // yes
            // 
            yes.AutoSize = true;
            yes.BackColor = Color.Transparent;
            yes.ForeColor = SystemColors.Control;
            yes.Location = new Point(570, 417);
            yes.Name = "yes";
            yes.Size = new Size(59, 24);
            yes.TabIndex = 10;
            yes.Text = "Evet";
            yes.UseVisualStyleBackColor = false;
            // 
            // kiralama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_11_May_2026_18_55_47;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1056, 566);
            Controls.Add(yes);
            Controls.Add(label3);
            Controls.Add(txt_fiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_hesapla);
            Controls.Add(btn_kirala);
            Controls.Add(date_basla);
            Controls.Add(date_bitis);
            Controls.Add(db_rooms);
            Controls.Add(btn_back);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "kiralama";
            Text = "kiralama";
            ((System.ComponentModel.ISupportInitialize)db_rooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private DataGridView db_rooms;
        private DateTimePicker date_bitis;
        private DateTimePicker date_basla;
        private Button btn_kirala;
        private Button btn_hesapla;
        private Label label1;
        private Label label2;
        private TextBox txt_fiyat;
        private Label label3;
        private CheckBox yes;
    }
}