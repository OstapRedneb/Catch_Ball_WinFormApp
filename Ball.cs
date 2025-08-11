using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Catch_Ball_WinFormApp
{
    public class Ball
    {
        GameForm form;
        Graphics graphics;
        Random random = new Random();
        Timer timer;

        Brush brush;

        int size;

        int x;
        int y;

        int vx;
        int vy;

        public Ball(GameForm form, int vx, int vy)
        {
            this.vx = vx;
            this.vy = vy;
            this.form = form;

            timer = new Timer();
            timer.Tick += MoveNext;

            switch (random.Next(0, 6)) 
            {
                case 0: brush = Brushes.Aqua; break;
                case 1: brush = Brushes.Yellow; break;
                case 2: brush = Brushes.Violet; break;
                case 3: brush = Brushes.Tomato; break;
                case 4: brush = Brushes.Green; break;
            }
        }

        public void Show() 
        {
            size = random.Next();

            graphics = form.CreateGraphics();

            x = random.Next(0, form.ClientSize.Width - size);
            y = random.Next(0, form.ClientSize.Height - size);

            graphics.FillEllipse(brush, new Rectangle(x, y, size, size));
        }

        public void Show(int x, int y) 
        {
            graphics = form.CreateGraphics();

            graphics.DrawEllipse(new Pen(Color.Aqua), new Rectangle(x, y, size, size));
        }

        public void MoveNext(object sender, EventArgs e) 
        {
            Clear();
            Show(x + vx, y + vy);
        }
        public void Clear() 
        {
            graphics.Clear(form.BackColor);
        }

        public void TurnOnOff() 
        {
            timer.Enabled = !timer.Enabled;
        }
    }
}
