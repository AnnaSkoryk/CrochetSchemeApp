namespace CrochetSchemeApp
{
    public class ImgCluster
    {
        public ImgCluster(int x, int y, Color color)
        {
            startX = x;
            startY = y;
            this.color = color;
        }
        public ImgCluster(int x, int y)
        {
            startX = x;
            startY = y;
            //this.color = ;
        }

        public int startX { get; set; }
        public int startY { get; set; }
        public Color color { get; set; }

        private int size = GraphicController.step;

        public void paintClusterWithColor(Bitmap sourceImg)
        {
            for (int y = startY; y < startY + size && y < sourceImg.Height; y++)
            {
                for (int x = startX; x < startX + size && x < sourceImg.Width; x++)
                {
                    sourceImg.SetPixel(x, y, color);
                }
            }
        }

        public void DefineAverageColorOfClaster(Bitmap sourceImg)
        {
            int r = 0, g = 0, b = 0;
            int countOfPixels = 0;

            for (int y = startY; y < startY + size && y < sourceImg.Height; y++)
            {
                for (int x = startX; x < startX + size && x < sourceImg.Width; x++)
                {
                    Color pixel = sourceImg.GetPixel(x, y);
                    r += pixel.R;
                    g += pixel.G;
                    b += pixel.B;
                    countOfPixels++;
                }
            }
            color = Color.FromArgb(r / countOfPixels, g / countOfPixels, b / countOfPixels);
        }
    }
}
