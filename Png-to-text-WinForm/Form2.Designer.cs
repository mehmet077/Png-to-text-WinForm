namespace Png_to_text_WinForm
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(527, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(257, 291);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(533, 334);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 1;
            button1.Text = "Resim seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelectImage_Click;
            // 
            // button2
            // 
            button2.Location = new Point(684, 333);
            button2.Name = "button2";
            button2.Size = new Size(104, 46);
            button2.TabIndex = 2;
            button2.Text = "Metin al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnExtractText_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 430);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}