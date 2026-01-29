namespace Png_to_text_WinForm
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            label = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 506);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Resim Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelectImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(733, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
            // 
            // button2
            // 
            button2.Location = new Point(1019, 506);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 2;
            button2.Text = "Metni al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnExtractText_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(769, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(337, 400);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(12, 22);
            label.Name = "label";
            label.Size = new Size(287, 37);
            label.TabIndex = 5;
            label.Text = "Resim Ön izleme Alanı ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(850, 22);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 6;
            label1.Text = "Metin Çıktı Alanı";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 400);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 510);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 8;
            label2.Text = "Geliştirici: Mehmet Aydın © 2026";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1118, 541);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label label;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}
