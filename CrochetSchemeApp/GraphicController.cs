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

        public static List<ImgCluster> CreateListOfClusters(Bitmap source)
        {
            List<ImgCluster> listOfClusters = new List<ImgCluster>();

            ImgCluster cluster;
            for (int y = 0; y < source.Height; y += step - 1)
            {
                for (int x = 0; x < source.Width; x += step - 1)
                {
                    cluster = new ImgCluster(x, y);
                    cluster.DefineAverageColorOfClaster(source);
                    listOfClusters.Add(cluster);
                    cluster.paintClusterWithColor(source);
                }
            }
            return listOfClusters;
        }
    }
}
