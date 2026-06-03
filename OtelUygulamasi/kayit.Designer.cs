namespace OtelUygulamasi
{
    partial class kayit
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
            back = new Button();
            label1 = new Label();
            txt_Tc = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            txt_surname = new TextBox();
            txt_tel = new TextBox();
            txt_adres = new TextBox();
            label3 = new Label();
            label = new Label();
            label5 = new Label();
            txt_kayit = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(676, 399);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 0;
            back.Text = "Geri";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(159, 34);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 1;
            label1.Text = "Tc";
            // 
            // txt_Tc
            // 
            txt_Tc.Location = new Point(159, 57);
            txt_Tc.Name = "txt_Tc";
            txt_Tc.Size = new Size(125, 27);
            txt_Tc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(159, 106);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 3;
            label2.Text = "Ad";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(159, 129);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 4;
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(159, 191);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(125, 27);
            txt_surname.TabIndex = 5;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(159, 258);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(125, 27);
            txt_tel.TabIndex = 6;
            // 
            // txt_adres
            // 
            txt_adres.Location = new Point(159, 319);
            txt_adres.Multiline = true;
            txt_adres.Name = "txt_adres";
            txt_adres.Size = new Size(192, 96);
            txt_adres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(159, 168);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Soyad";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.ForeColor = SystemColors.Control;
            label.Location = new Point(159, 235);
            label.Name = "label";
            label.Size = new Size(58, 20);
            label.TabIndex = 9;
            label.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(159, 296);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 10;
            label5.Text = "Adres";
            // 
            // txt_kayit
            // 
            txt_kayit.Location = new Point(439, 319);
            txt_kayit.Name = "txt_kayit";
            txt_kayit.Size = new Size(160, 96);
            txt_kayit.TabIndex = 11;
            txt_kayit.Text = "Kayıt";
            txt_kayit.UseVisualStyleBackColor = true;
            txt_kayit.Click += txt_kayit_Click;
            // 
            // kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_16_May_2026_00_17_18;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_kayit);
            Controls.Add(label5);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(txt_adres);
            Controls.Add(txt_tel);
            Controls.Add(txt_surname);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(txt_Tc);
            Controls.Add(label1);
            Controls.Add(back);
            Name = "kayit";
            Text = "kayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label label1;
        private TextBox txt_Tc;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_surname;
        private TextBox txt_tel;
        private TextBox txt_adres;
        private Label label3;
        private Label label;
        private Label label5;
        private Button txt_kayit;
    }
}