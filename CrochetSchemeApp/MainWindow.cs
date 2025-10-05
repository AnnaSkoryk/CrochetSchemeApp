namespace CrochetSchemeApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpeg;*.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalPicture.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmapImg = new Bitmap(originalPicture.Image);

            //Draw grid
            using (Graphics g = Graphics.FromImage(bitmapImg))
            {
                int step = 15;
                Pen pen = new Pen(Color.White, 1);

                for (int x = 0; x < bitmapImg.Width; x += step)
                {
                    g.DrawLine(pen, x, 0, x, bitmapImg.Height);
                }
                for (int y = 0; y < bitmapImg.Height; y += step)
                {
                    g.DrawLine(pen, 0, y, bitmapImg.Width, y);
                }
            }

            schemeImg.Image = bitmapImg;
        }
    }
}
