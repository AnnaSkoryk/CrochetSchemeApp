using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

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
            if ((twoColorsCheckBox.Checked || threeColorsCheckBox.Checked || fourColorsCheckBox.Checked) && originalPicture.Image is not null)
            {
                Bitmap bitmapImg = new Bitmap(originalPicture.Image);
                GraphicController.SetAvarageColors(bitmapImg);
                Bitmap imgWithGrid = GraphicController.InsertGrid(bitmapImg);

                schemeImg.Image = imgWithGrid;
            }
        }

        private void twoColorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (twoColorsCheckBox.Checked) {
                threeColorsCheckBox.Checked = false;
                fourColorsCheckBox.Checked = false;
                GraphicController.numberOfColorsInUse = 2;
            }
        }

        private void threeColorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (threeColorsCheckBox.Checked)
            {
                twoColorsCheckBox.Checked = false;
                fourColorsCheckBox.Checked = false;
                GraphicController.numberOfColorsInUse = 3;
            }
        }

        private void fourColorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fourColorsCheckBox.Checked)
            {
                twoColorsCheckBox.Checked = false;
                threeColorsCheckBox.Checked = false;
                GraphicController.numberOfColorsInUse = 3;
            }
        }
    }
}
