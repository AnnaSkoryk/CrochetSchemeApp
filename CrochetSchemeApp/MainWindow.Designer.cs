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
            uploadImgBtn = new Button();
            originalPicture = new PictureBox();
            convertBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            schemeImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)originalPicture).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schemeImg).BeginInit();
            SuspendLayout();
            // 
            // uploadImgBtn
            // 
            uploadImgBtn.Anchor = AnchorStyles.Top;
            uploadImgBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadImgBtn.Location = new Point(391, 3);
            uploadImgBtn.Name = "uploadImgBtn";
            uploadImgBtn.Size = new Size(257, 68);
            uploadImgBtn.TabIndex = 0;
            uploadImgBtn.Text = "Upload image";
            uploadImgBtn.UseVisualStyleBackColor = true;
            uploadImgBtn.Click += uploadImgBtn_Click;
            // 
            // originalPicture
            // 
            originalPicture.Location = new Point(3, 77);
            originalPicture.Name = "originalPicture";
            originalPicture.Size = new Size(1034, 395);
            originalPicture.SizeMode = PictureBoxSizeMode.Zoom;
            originalPicture.TabIndex = 1;
            originalPicture.TabStop = false;
            // 
            // convertBtn
            // 
            convertBtn.Anchor = AnchorStyles.Top;
            convertBtn.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertBtn.Location = new Point(391, 478);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(257, 68);
            convertBtn.TabIndex = 2;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(uploadImgBtn);
            flowLayoutPanel1.Controls.Add(originalPicture);
            flowLayoutPanel1.Controls.Add(convertBtn);
            flowLayoutPanel1.Controls.Add(schemeImg);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1083, 727);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // schemeImg
            // 
            schemeImg.Location = new Point(3, 552);
            schemeImg.Name = "schemeImg";
            schemeImg.Padding = new Padding(0, 0, 0, 50);
            schemeImg.Size = new Size(1034, 457);
            schemeImg.SizeMode = PictureBoxSizeMode.Zoom;
            schemeImg.TabIndex = 3;
            schemeImg.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 727);
            Controls.Add(flowLayoutPanel1);
            Name = "MainWindow";
            Text = "a";
            ((System.ComponentModel.ISupportInitialize)originalPicture).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)schemeImg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button uploadImgBtn;
        private PictureBox originalPicture;
        private Button convertBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox schemeImg;
    }
}
