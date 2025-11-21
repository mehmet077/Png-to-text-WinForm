using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenCvSharp;
using System.Drawing;
using Tesseract;

namespace Png_to_text_WinForm
{
    public partial class Form2 : Form
    {
        private string selectedImagePath = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
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

            string tessDataPath = System.IO.Path.Combine(Application.StartupPath, "tessdata");

            try
            {
                using (Mat preprocessed = PreprocessForOCR(selectedImagePath))
                {
                    using (var ms = new MemoryStream())
                    {
                        // Mat'i PNG olarak MemoryStream'e kaydet
                        Cv2.ImEncode(".png", preprocessed, out byte[] imageData);
                        ms.Write(imageData, 0, imageData.Length);
                        ms.Position = 0;

                        using (var engine = new TesseractEngine(tessDataPath, "tur", EngineMode.Default))
                        {
                            using (var img = Pix.LoadFromMemory(ms.ToArray()))
                            {
                                using (var page = engine.Process(img))
                                {
                                    string text = page.GetText();
                                    richTextBox1.Text = text;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private Mat PreprocessForOCR(string imagePath)
        {
            Mat src = Cv2.ImRead(imagePath, ImreadModes.Color);
            Mat gray = new Mat();
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            Mat blurred = new Mat();
            Cv2.GaussianBlur(gray, blurred, new OpenCvSharp.Size(5, 5), 0);
            Mat thresh = new Mat();
            Cv2.AdaptiveThreshold(blurred, thresh, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 11, 2);
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
            Mat morph = new Mat();
            Cv2.MorphologyEx(thresh, morph, MorphTypes.Open, kernel);
            return morph;
        }
    }
}
