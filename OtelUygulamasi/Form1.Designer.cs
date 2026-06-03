namespace OtelUygulamasi
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
            txt_odakiralama = new Button();
            txt_kiralamageçmişi = new Button();
            txt_kayit = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // txt_odakiralama
            // 
            txt_odakiralama.BackColor = Color.Transparent;
            txt_odakiralama.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_odakiralama.ForeColor = SystemColors.ControlText;
            txt_odakiralama.Location = new Point(66, 223);
            txt_odakiralama.Name = "txt_odakiralama";
            txt_odakiralama.Size = new Size(206, 67);
            txt_odakiralama.TabIndex = 0;
            txt_odakiralama.Text = "Oda Kiralama ";
            txt_odakiralama.TextImageRelation = TextImageRelation.ImageBeforeText;
            txt_odakiralama.UseVisualStyleBackColor = false;
            txt_odakiralama.Click += button1_Click;
            // 
            // txt_kiralamageçmişi
            // 
            txt_kiralamageçmişi.BackColor = Color.Transparent;
            txt_kiralamageçmişi.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_kiralamageçmişi.Location = new Point(523, 223);
            txt_kiralamageçmişi.Name = "txt_kiralamageçmişi";
            txt_kiralamageçmişi.Size = new Size(206, 67);
            txt_kiralamageçmişi.TabIndex = 1;
            txt_kiralamageçmişi.Text = "Kiralama Geçmişi";
            txt_kiralamageçmişi.UseVisualStyleBackColor = false;
            txt_kiralamageçmişi.Click += txt_kiralamageçmişi_Click;
            // 
            // txt_kayit
            // 
            txt_kayit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_kayit.Location = new Point(294, 223);
            txt_kayit.Name = "txt_kayit";
            txt_kayit.Size = new Size(206, 67);
            txt_kayit.TabIndex = 2;
            txt_kayit.Text = "Kayıt İşlemleri";
            txt_kayit.UseVisualStyleBackColor = true;
            txt_kayit.Click += txt_kayit_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Exit.Location = new Point(335, 321);
            Exit.Name = "Exit";
            Exit.Size = new Size(124, 72);
            Exit.TabIndex = 3;
            Exit.Text = "Uygulamayı Kapat";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_11_May_2026_12_56_51;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(txt_kayit);
            Controls.Add(txt_kiralamageçmişi);
            Controls.Add(txt_odakiralama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button txt_odakiralama;
        private Button txt_kiralamageçmişi;
        private Button txt_kayit;
        private Button Exit;
    }
}
