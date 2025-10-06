namespace CrochetSchemeApp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            schemeImg = new PictureBox();
            convertBtn = new Button();
            originalPicture = new PictureBox();
            uploadImgBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chooseColorsPanel = new FlowLayoutPanel();
            twoColorsCheckBox = new CheckBox();
            threeColorsCheckBox = new CheckBox();
            fourColorsCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)schemeImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPicture).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            chooseColorsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // schemeImg
            // 
            schemeImg.BackColor = SystemColors.ButtonFace;
            schemeImg.Location = new Point(710, 725);
            schemeImg.Margin = new Padding(10, 10, 10, 40);
            schemeImg.Name = "schemeImg";
            schemeImg.Padding = new Padding(0, 0, 0, 50);
            schemeImg.Size = new Size(1034, 1034);
            schemeImg.SizeMode = PictureBoxSizeMode.Zoom;
            schemeImg.TabIndex = 3;
            schemeImg.TabStop = false;
            // 
            // convertBtn
            // 
            convertBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            convertBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertBtn.Location = new Point(710, 644);
            convertBtn.Margin = new Padding(10, 3, 10, 3);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(1034, 68);
            convertBtn.TabIndex = 2;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // originalPicture
            // 
            originalPicture.BackColor = SystemColors.ButtonFace;
            originalPicture.Dock = DockStyle.Fill;
            originalPicture.Location = new Point(710, 104);
            originalPicture.Margin = new Padding(10);
            originalPicture.Name = "originalPicture";
            originalPicture.Size = new Size(1034, 395);
            originalPicture.SizeMode = PictureBoxSizeMode.Zoom;
            originalPicture.TabIndex = 1;
            originalPicture.TabStop = false;
            // 
            // uploadImgBtn
            // 
            uploadImgBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uploadImgBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadImgBtn.Location = new Point(710, 23);
            uploadImgBtn.Margin = new Padding(10, 3, 10, 3);
            uploadImgBtn.Name = "uploadImgBtn";
            uploadImgBtn.Size = new Size(1034, 68);
            uploadImgBtn.TabIndex = 0;
            uploadImgBtn.Text = "Upload image";
            uploadImgBtn.UseVisualStyleBackColor = true;
            uploadImgBtn.Click += uploadImgBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(uploadImgBtn);
            flowLayoutPanel1.Controls.Add(originalPicture);
            flowLayoutPanel1.Controls.Add(chooseColorsPanel);
            flowLayoutPanel1.Controls.Add(convertBtn);
            flowLayoutPanel1.Controls.Add(schemeImg);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(700, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(2083, 727);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // chooseColorsPanel
            // 
            chooseColorsPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chooseColorsPanel.AutoSize = true;
            chooseColorsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chooseColorsPanel.BackColor = SystemColors.GradientInactiveCaption;
            chooseColorsPanel.Controls.Add(twoColorsCheckBox);
            chooseColorsPanel.Controls.Add(threeColorsCheckBox);
            chooseColorsPanel.Controls.Add(fourColorsCheckBox);
            chooseColorsPanel.Location = new Point(710, 519);
            chooseColorsPanel.Margin = new Padding(10);
            chooseColorsPanel.Name = "chooseColorsPanel";
            chooseColorsPanel.Padding = new Padding(10, 5, 10, 5);
            chooseColorsPanel.Size = new Size(1034, 112);
            chooseColorsPanel.TabIndex = 4;
            // 
            // twoColorsCheckBox
            // 
            twoColorsCheckBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            twoColorsCheckBox.Appearance = Appearance.Button;
            twoColorsCheckBox.AutoSize = true;
            twoColorsCheckBox.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            twoColorsCheckBox.Location = new Point(30, 8);
            twoColorsCheckBox.Margin = new Padding(20, 3, 20, 3);
            twoColorsCheckBox.Name = "twoColorsCheckBox";
            twoColorsCheckBox.Size = new Size(291, 96);
            twoColorsCheckBox.TabIndex = 0;
            twoColorsCheckBox.Text = "2 Colors";
            twoColorsCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            twoColorsCheckBox.UseVisualStyleBackColor = true;
            twoColorsCheckBox.CheckedChanged += twoColorsCheckBox_CheckedChanged;
            // 
            // threeColorsCheckBox
            // 
            threeColorsCheckBox.Anchor = AnchorStyles.Left;
            threeColorsCheckBox.Appearance = Appearance.Button;
            threeColorsCheckBox.AutoSize = true;
            threeColorsCheckBox.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            threeColorsCheckBox.Location = new Point(361, 8);
            threeColorsCheckBox.Margin = new Padding(20, 3, 20, 3);
            threeColorsCheckBox.Name = "threeColorsCheckBox";
            threeColorsCheckBox.Size = new Size(291, 96);
            threeColorsCheckBox.TabIndex = 1;
            threeColorsCheckBox.Text = "3 Colors";
            threeColorsCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            threeColorsCheckBox.UseVisualStyleBackColor = true;
            threeColorsCheckBox.CheckedChanged += threeColorsCheckBox_CheckedChanged;
            // 
            // fourColorsCheckBox
            // 
            fourColorsCheckBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fourColorsCheckBox.Appearance = Appearance.Button;
            fourColorsCheckBox.AutoSize = true;
            fourColorsCheckBox.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fourColorsCheckBox.Location = new Point(692, 8);
            fourColorsCheckBox.Margin = new Padding(20, 3, 20, 3);
            fourColorsCheckBox.Name = "fourColorsCheckBox";
            fourColorsCheckBox.Size = new Size(291, 96);
            fourColorsCheckBox.TabIndex = 2;
            fourColorsCheckBox.Text = "4 Colors";
            fourColorsCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            fourColorsCheckBox.UseVisualStyleBackColor = true;
            fourColorsCheckBox.CheckedChanged += fourColorsCheckBox_CheckedChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2083, 727);
            Controls.Add(flowLayoutPanel1);
            Name = "MainWindow";
            Text = "a";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)schemeImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPicture).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            chooseColorsPanel.ResumeLayout(false);
            chooseColorsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox schemeImg;
        private Button convertBtn;
        private PictureBox originalPicture;
        private Button uploadImgBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel chooseColorsPanel;
        private CheckBox twoColorsCheckBox;
        private CheckBox threeColorsCheckBox;
        private CheckBox fourColorsCheckBox;
    }
}
