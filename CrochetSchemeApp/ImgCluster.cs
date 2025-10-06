using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int startX { get; set; }
        public int startY { get; set; }
        public Color color { get; set; }
    }
}
