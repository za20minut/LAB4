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
                openFileDialog = new OpenFileDialog()) { openFileDialog.Title = "chus the pikczer";
                openFileDialog.Filter = "pliki graficzne|*.jpg;*.jpeg;*.png;*.gif|Wszystkie pliki|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK) { pictureBox1.Image = Image.FromFile(openFileDialog.FileName); }
            }
        }


    }
}
