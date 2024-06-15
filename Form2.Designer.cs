using System.Runtime.InteropServices;
namespace Flappy_Bird_Windows_Game_Application
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            FlappyBird = new PictureBox();
            pipe = new PictureBox();
            pipedown = new PictureBox();
            ground = new PictureBox();
            ScoreBox = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            tallpipe = new PictureBox();
            shortpipe = new PictureBox();
            GameOver = new PictureBox();
            HScoreBoard = new Label();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tallpipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shortpipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GameOver).BeginInit();
            SuspendLayout();
            // 
            // FlappyBird
            // 
            FlappyBird.BackColor = Color.Transparent;
            FlappyBird.BackgroundImage = (Image)resources.GetObject("FlappyBird.BackgroundImage");
            FlappyBird.BackgroundImageLayout = ImageLayout.Stretch;
            FlappyBird.Location = new Point(388, 190);
            FlappyBird.Name = "FlappyBird";
            FlappyBird.Size = new Size(112, 86);
            FlappyBird.TabIndex = 2;
            FlappyBird.TabStop = false;
            // 
            // pipe
            // 
            pipe.BackColor = Color.Transparent;
            pipe.BackgroundImage = (Image)resources.GetObject("pipe.BackgroundImage");
            pipe.BackgroundImageLayout = ImageLayout.Stretch;
            pipe.Location = new Point(607, 393);
            pipe.Name = "pipe";
            pipe.Size = new Size(126, 348);
            pipe.TabIndex = 3;
            pipe.TabStop = false;
            // 
            // pipedown
            // 
            pipedown.BackColor = Color.Transparent;
            pipedown.BackgroundImage = (Image)resources.GetObject("pipedown.BackgroundImage");
            pipedown.BackgroundImageLayout = ImageLayout.Stretch;
            pipedown.Location = new Point(903, -2);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(126, 276);
            pipedown.TabIndex = 4;
            pipedown.TabStop = false;
            // 
            // ground
            // 
            ground.BackColor = Color.Transparent;
            ground.BackgroundImage = (Image)resources.GetObject("ground.BackgroundImage");
            ground.BackgroundImageLayout = ImageLayout.Stretch;
            ground.Location = new Point(-6, 612);
            ground.Name = "ground";
            ground.Size = new Size(1202, 129);
            ground.TabIndex = 5;
            ground.TabStop = false;
            // 
            // ScoreBox
            // 
            ScoreBox.AutoSize = true;
            ScoreBox.BackColor = Color.Transparent;
            ScoreBox.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreBox.Location = new Point(52, 31);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.Size = new Size(26, 38);
            ScoreBox.TabIndex = 6;
            ScoreBox.Text = " ";
            ScoreBox.Click += label1_Click;
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gametimerevent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Exit_PNG_Image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1039, 567);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tallpipe
            // 
            tallpipe.BackColor = Color.Transparent;
            tallpipe.BackgroundImage = (Image)resources.GetObject("tallpipe.BackgroundImage");
            tallpipe.BackgroundImageLayout = ImageLayout.Stretch;
            tallpipe.Location = new Point(69, 252);
            tallpipe.Name = "tallpipe";
            tallpipe.Size = new Size(126, 403);
            tallpipe.TabIndex = 8;
            tallpipe.TabStop = false;
            tallpipe.Visible = false;
            tallpipe.Click += tallpipe_Click;
            // 
            // shortpipe
            // 
            shortpipe.BackColor = Color.Transparent;
            shortpipe.BackgroundImage = (Image)resources.GetObject("shortpipe.BackgroundImage");
            shortpipe.BackgroundImageLayout = ImageLayout.Stretch;
            shortpipe.Location = new Point(329, -111);
            shortpipe.Name = "shortpipe";
            shortpipe.Size = new Size(126, 241);
            shortpipe.TabIndex = 9;
            shortpipe.TabStop = false;
            // 
            // GameOver
            // 
            GameOver.BackColor = Color.Transparent;
            GameOver.BackgroundImage = (Image)resources.GetObject("GameOver.BackgroundImage");
            GameOver.BackgroundImageLayout = ImageLayout.Zoom;
            GameOver.Location = new Point(343, 173);
            GameOver.Name = "GameOver";
            GameOver.Size = new Size(580, 352);
            GameOver.TabIndex = 10;
            GameOver.TabStop = false;
            GameOver.Visible = false;
            // 
            // HScoreBoard
            // 
            HScoreBoard.AutoSize = true;
            HScoreBoard.BackColor = Color.Transparent;
            HScoreBoard.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HScoreBoard.Location = new Point(543, 506);
            HScoreBoard.Name = "HScoreBoard";
            HScoreBoard.Size = new Size(180, 35);
            HScoreBoard.TabIndex = 11;
            HScoreBoard.Text = "HighScore :  ";
            HScoreBoard.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1176, 726);
            Controls.Add(ScoreBox);
            Controls.Add(HScoreBoard);
            Controls.Add(pictureBox1);
            Controls.Add(GameOver);
            Controls.Add(shortpipe);
            Controls.Add(ground);
            Controls.Add(pipedown);
            Controls.Add(FlappyBird);
            Controls.Add(tallpipe);
            Controls.Add(pipe);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird Game       ";
            KeyDown += Form2_KeyDown;
            KeyUp += Form2_KeyUp;
            ((System.ComponentModel.ISupportInitialize)FlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tallpipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)shortpipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)GameOver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FlappyBird;
        private PictureBox pipe;
        private PictureBox pipedown;
        private PictureBox ground;
        private Label ScoreBox;
        private System.Windows.Forms.Timer gametimer;
        private PictureBox pictureBox1;
        private PictureBox tallpipe;
        private PictureBox shortpipe;
        private PictureBox GameOver;
        private Label HScoreBoard;
    }
}