namespace OtelUygulamasi
{
    partial class giris
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
            txt_pass = new TextBox();
            btn_passgrs = new Button();
            SuspendLayout();
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(323, 212);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(165, 27);
            txt_pass.TabIndex = 0;
            // 
            // btn_passgrs
            // 
            btn_passgrs.Location = new Point(341, 278);
            btn_passgrs.Name = "btn_passgrs";
            btn_passgrs.Size = new Size(125, 59);
            btn_passgrs.TabIndex = 1;
            btn_passgrs.Text = "Giriş";
            btn_passgrs.UseVisualStyleBackColor = true;
            btn_passgrs.Click += btn_passgrs_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_6iq4ms6iq4ms6iq4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_passgrs);
            Controls.Add(txt_pass);
            DoubleBuffered = true;
            Name = "giris";
            Text = "giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_pass;
        private Button btn_passgrs;
    }
}