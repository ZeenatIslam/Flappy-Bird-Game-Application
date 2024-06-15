using System.Runtime.InteropServices;


namespace Flappy_Bird_Windows_Game_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PictureBox1 = new PictureBox();
            Button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.BackgroundImage = Properties.Resources.Exit_PNG_Image;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.InitialImage = (Image)resources.GetObject("PictureBox1.InitialImage");
            PictureBox1.Location = new Point(113, 76);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(125, 62);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            PictureBox1.Click += pictureBox1_Click;
            // 
            // Button1
            // 
            Button1.BackColor = Color.DarkOrange;
            Button1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(112, 174);
            Button1.Name = "Button1";
            Button1.Size = new Size(126, 49);
            Button1.TabIndex = 1;
            Button1.Text = "Start";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1176, 726);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox1;
        private Button Button1;
    }
}
