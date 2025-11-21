using System.Windows.Forms;
using Tesseract;

namespace Png_to_text_WinForm
{
    public partial class Form1 : Form
    {
        private string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pictureBox1.ImageLocation = selectedImagePath;
                }
            }
        }

        private void btnExtractText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Önce bir resim seçin!");
                return;
            }

            //string tessDataPath = @"./tessdata"; // Proje dizininde tessdata klasörü
            string tessDataPath = System.IO.Path.Combine(Application.StartupPath, "tessdata");


            try
            {
                using (var engine = new TesseractEngine(tessDataPath, "tur", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(selectedImagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            string text = page.GetText();
                            richTextBox1.Text = text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}