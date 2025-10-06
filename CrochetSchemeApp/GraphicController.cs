using static CrochetSchemeApp.ImgCluster;

namespace CrochetSchemeApp
{
    static public class GraphicController
    {
        public static int step = 20;
        static Color gridColor = Color.White;
        public static int numberOfColorsInUse;
        

        public static Bitmap InsertGrid(Bitmap source)
        {
            int linesToAddX= source.Width / step - 1;
            int linesToAddY = source.Width / step - 1;

            Bitmap middleResultX = new Bitmap(source.Width + linesToAddX, source.Height);
            Bitmap result = new Bitmap(source.Width + linesToAddX, source.Height + linesToAddY);

            for (int y = 0; y < source.Height; y++)
            {
                int linesAddedX = 0;
                for (int x = 0; x < middleResultX.Width; x++)
                {
                    if (x % step == 0 && x!= 0)
                    {
                        middleResultX.SetPixel(x, y, gridColor);
                        linesAddedX++;
                    }
                    else
                    {
                        middleResultX.SetPixel(x, y, source.GetPixel(x-linesAddedX, y));
                    }
                }
            }

            for (int x = 0; x < result.Width; x++)
            {
                int linesAddedY = 0;
                for (int y = 0; y < result.Height; y++)
                {
                    if (y % step == 0 && y != 0)
                    {
                        result.SetPixel(x, y, gridColor);
                        linesAddedY++;
                    }
                    else
                    {
                        result.SetPixel(x, y, middleResultX.GetPixel(x, y - linesAddedY));
                    }
                }
            }
            return result;
        }

        public static void CreateListOfClusters(Bitmap source)
        {
            List<ImgCluster> listOfClusters = new List<ImgCluster>();
            Color avarageColor;
            for (int y = 0; y < source.Height; y += step - 1)
            {
                for (int x = 0; x < source.Width; x += step - 1)
                {
                    avarageColor = GetAverageColorOfClaster(source, x, y);
                    listOfClusters.Add(new ImgCluster(x, y, avarageColor));

                    SetColorOfCluster(source, x, y, avarageColor);
                }
            }
        }

        public static void SetAvarageColors(Bitmap source)
        {
            for (int y = 0; y < source.Height; y += step - 1)
            {
                for (int x = 0; x < source.Width; x += step - 1)
                {
                    SetColorOfCluster(source, x, y, GetAverageColorOfClaster(source, x, y));
                }
            }
        }

        public static void SetColorsOfAllClusters(Bitmap source, Color color)
        {
            for (int y = 0; y < source.Height; y += step - 1)
            {
                for (int x = 0; x < source.Width; x += step - 1)
                {
                    SetColorOfCluster(source, x, y, color);
                }
            }
        }

        private static Color GetAverageColorOfClaster(Bitmap sourceImg, int startX, int startY)
        {
            int r = 0, g = 0, b = 0;
            int count = 0;

            for (int y = startY; y < startY + step && y < sourceImg.Height; y++)
            {
                for (int x = startX; x < startX + step && x < sourceImg.Width; x++)
                {
                    Color pixel = sourceImg.GetPixel(x, y);
                    r += pixel.R;
                    g += pixel.G;
                    b += pixel.B;
                    count++;
                }
            }

            return Color.FromArgb(r / count, g / count, b / count);
        }

        private static void SetColorOfCluster(Bitmap sourceImg, int startX, int startY, Color averageColor)
        {
            for (int y = startY; y < startY + step && y < sourceImg.Height; y++)
            {
                for (int x = startX; x < startX + step && x < sourceImg.Width; x++)
                {
                    sourceImg.SetPixel(x, y, averageColor); 
                }
            }
        }
    }
}
