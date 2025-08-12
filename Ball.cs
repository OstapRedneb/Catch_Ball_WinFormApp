using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Catch_Ball_WinFormApp
{
    public class Ball
    {
        Random random = new Random();

        GameForm form;
        Timer timer;

        Graphics graphics;
        Rectangle rectangle;
        Pen pen;
        Brush brush;

        Brush formBrush;
        Pen formPen;

        public int size;

        public int x;
        public int y;

        int vx;
        int vy;

        public Ball(GameForm form, int size, int interval)
        {
            this.form = form;
            formBrush = new SolidBrush(ColorTranslator.FromHtml(ColorTranslator.ToHtml(form.BackColor)));
            formPen = new Pen(form.BackColor);

            x = random.Next(100, form.ClientSize.Width - size - 100);
            y = random.Next(100, form.ClientSize.Height - size - 100);

            (vx, vy) = CreateVectors();

            
            this.size = size;

            timer = new Timer();
            timer.Interval = interval;
            timer.Tick += MoveNext;

            //switch (random.Next(0, 6)) 
            //{
            //    case 0: brush = Brushes.Aqua; break;
            //    case 1: brush = Brushes.Yellow; break;
            //    case 2: brush = Brushes.Violet; break;
            //    case 3: brush = Brushes.Tomato; break;
            //    case 4: brush = Brushes.Green; break;
            //}

            graphics = form.graphics;

            pen = new Pen(Color.Black);
            brush = PickBrush();
            rectangle = new Rectangle(x, y, size, size);
        }

        private (int, int) CreateVectors()
        {
            int vx1 = 0;
            int vy1 = 0;

            while (vx1 == 0 && vy1 == 0)
            {
                vx1 = random.Next(-2, 3);
                vy1 = random.Next(-2, 3);
            }

            return (vx1, vy1);
        }

        public void Show() 
        {
            graphics.DrawEllipse(pen, rectangle with {X = x, Y = y });
            graphics.FillEllipse(brush, rectangle with { X = x, Y = y });
        }

        public void MoveNext(object sender, EventArgs e) 
        {
            Clear();
            x += vx;
            y += vy;

            if (x < -size * 2 || y < -size * 2 || x > form.ClientSize.Width || y > form.ClientSize.Height) 
            {
                form.game = Game.Loose;
            }
            Show();
        }
        public void Clear() 
        {
            graphics.DrawEllipse(formPen, rectangle with { X = x, Y = y });
            graphics.FillEllipse(formBrush, rectangle with { X = x, Y = y });
        }

        public void TurnOnOff() 
        {
            timer.Enabled = !timer.Enabled;
        }
        public Brush PickBrush()
        {
            Brush result = Brushes.Transparent;

            Type brushesType = typeof(Brushes);

            PropertyInfo[] properties = brushesType.GetProperties();

            int rnd = random.Next(properties.Length);
            result = (Brush)properties[rnd].GetValue(null, null);

            return result;
        }
    }
}
