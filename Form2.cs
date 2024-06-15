using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//SYSTEM.MEDIA IS REQUIRED FOR PLAYING THEE SOUNDS
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Flappy_Bird_Windows_Game_Application
{
    public partial class Form2 : Form
    {
        HighscoreCalculate H = new HighscoreCalculate();
        private const int V = 10;
        int gravity = 15;
        int pipespeed = 8;
        int score = 0;
        bool flag = true;
        //ArrayList Array = new ArrayList();
        int[] arr = new int[100];

        public Form2()
        {
            InitializeComponent();
        }

        private void gametimerevent(object sender, EventArgs e)
        {//time interval 20 miliseccond
            FlappyBird.Top += gravity;
            pipedown.Left -= pipespeed;
            pipe.Left -= pipespeed;
            tallpipe.Left -= pipespeed;
            shortpipe.Left -= pipespeed;

            //For Moving pipes in left side every 20 miliseconds 
            if (pipe.Left <= -100)
            {
                pipe.Left = 1200;
            }
            if (pipedown.Left <= -100)
            {
                pipedown.Left = 1200;

            }
            if (tallpipe.Left < -100)
            {
                tallpipe.Show();
                tallpipe.Left = 1200;
            }
            if (shortpipe.Left <= -100)
            {
                shortpipe.Left = 1200;
            }

            //Check for Clloision between two Sprites
            if ((FlappyBird.Bounds.IntersectsWith(pipe.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipedown.Bounds)) || (FlappyBird.Bounds.IntersectsWith(ground.Bounds)) )
            {
       

                GameOver.Show();
                gametimer.Stop();
                new System.Media.SoundPlayer(@"E:\Windows_Application\Flappy Bird Windows Game Application\Resources\audio\died.wav").Play();
                flag = false;
            }
            if (flag == true)
            {
                score = score + 1;
                string scored = score.ToString();

                ScoreBox.Text = "Score :" + scored;
                //SystemSounds.Beep.Play();

            }

            else
            {

                string filepath = "E:\\Windows_Application\\Flappy Bird Windows Game Application\\Resources\\HIGHSCORE.txt";
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {

                    writer.WriteLine(score);

                }

                //read the numbers from the file and store them in an array
                int[] Numbers = File.ReadLines(filepath).Select(int.Parse).ToArray();
                //finding the maximum number
                int maxNumber = Numbers.Max();
                //the maximum number from the file is 
                HScoreBoard.Visible = true;
                HScoreBoard.Text = "HighScore : " + maxNumber.ToString();
            }
            //Increasing the speed of pipes/Game
            if (score > 100)
            {
                pipespeed = 9;

            }
            if (score > 150)
            {
                pipespeed = 10;
            }
            if (score > 200)
            {
                pipespeed = 12;
            }
            if (score > 250)
            {
                pipespeed = 15;
            }
            if (score > 300)
            {
                pipespeed = 17;
            }
            if (score > 350)
            {
                pipespeed = 19;
            }
            if (score > 400)
            {
                pipespeed = 20;
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;

            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                new System.Media.SoundPlayer(@"E:\Windows_Application\Flappy Bird Windows Game Application\Resources\audio\flap.wav").Play();
                gravity = 15;

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            gametimer.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(@"E:\Windows_Application\Flappy Bird Windows Game Application\Resources\audio\flap.wav").Play();
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();

        }

        private void tallpipe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
