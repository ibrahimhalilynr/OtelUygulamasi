namespace OtelUygulamasi
{
    partial class Form2
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
            dataGridView2 = new DataGridView();
            button1 = new Button();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 182);
            dataGridView2.TabIndex = 1;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(287, 284);
            button1.Name = "button1";
            button1.Size = new Size(233, 89);
            button1.TabIndex = 2;
            button1.Text = "Oda Seçimi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // back
            // 
            back.Location = new Point(669, 400);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 3;
            back.Text = "Geri";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_18_May_2026_16_12_13;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private Button button1;
        private Button back;
    }
}