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

        private void button2_Click(object sender, EventArgs e)
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
