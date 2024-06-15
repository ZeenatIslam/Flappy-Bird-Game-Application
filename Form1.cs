using System.Media;
namespace Flappy_Bird_Windows_Game_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(@"E:\Windows_Application\Flappy Bird Windows Game Application\Resources\audio\Point.wav").Play();
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(@"E:\Windows_Application\Flappy Bird Windows Game Application\Resources\audio\Swoosh.wav").Play();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(@"E:\Windows_Application\Flappy Bird Windows Game Application\Resources\audio\SM.wav").Play();


        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
