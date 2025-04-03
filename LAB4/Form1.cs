namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog
                  openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "chus the pikczer";
                openFileDialog.Filter = "pliki graficzne|*.jpg;*.jpeg;*.png;*.gif|Wszystkie pliki|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK) { pictureBox1.Image = Image.FromFile(openFileDialog.FileName); }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBox1.Refresh();
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    bmp.SetPixel(x, y, invertedColor);
                }
            }
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }
    }
}
        private void button2b_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    if (pixelColor.G>110) 
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                   
                }
            }
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }
    }
}
