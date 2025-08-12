using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace Catch_Ball_WinFormApp
{
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }
    public enum Game 
    {
        None, 
        Success,
        Loose
    }
    public partial class GameForm : Form
    {
        public static Difficulty difficulty;
        public Game game = Game.None;

        public static int numberOfBalls;
        public static int minTick;
        public static int maxTick;
        public static int minSize;
        public static int maxSize;


        Random random = new Random();
        public Graphics graphics;

        List<Ball> balls;

        public GameForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            graphics = CreateGraphics();
            timer.Start();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    minTick = 80;
                    maxTick = 100;

                    minSize = 80;
                    maxSize = 100;
                    break;
                case Difficulty.Normal:
                    minTick = 40;
                    maxTick = 50;

                    minSize = 60;
                    maxSize = 80;
                    break;
                case Difficulty.Hard:
                    minTick = 10;
                    maxTick = 15;

                    minSize = 40;
                    maxSize = 60;
                    break;
            }

            balls = new List<Ball>();
            for (int i = 0; i < numberOfBalls; i++)
            {
                Ball ball = new Ball(this, random.Next(minSize, maxSize), random.Next(minTick, maxTick));
                balls.Add(ball);
                ball.Show();
                ball.TurnOnOff();
            }
        }

        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            int index = -1;

            for (int i = 0; i < balls.Count; i++)
            {
                if ((e.X >= balls[i].x && e.X <= balls[i].x + balls[i].size) && (e.Y >= balls[i].y && e.Y <= balls[i].y + balls[i].size))
                {
                    balls[i].TurnOnOff();
                    balls[i].Clear();
                    index = i;
                    break;
                }
            }

            if (index != -1) balls.RemoveAt(index);
            if (balls.Count == 0)
            {
                game = Game.Success;
                Finish();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (game != Game.None) 
            {
                Finish();
            }
        }
        public void Finish() 
        {
            FinishForm.game = game;
            new FinishForm().Show();
            Close();
        }
    }
}
