using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BallClassLibrary;

namespace Catch_Ball_WinFormApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            countLabel.Text = e.NewValue.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            switch (e.NewValue) 
            {
                case < 33: dificultLabel.Text = "Легко"; break;
                case > 66: dificultLabel.Text = "Сложно"; break;
                default: dificultLabel.Text = "Средне"; break;
            }
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            switch (dificultLabel.Text) 
            {
                case "Легко": GameForm.difficulty = Difficulty.Easy; break;
                case "Средне": GameForm.difficulty = Difficulty.Normal; break;
                case "Сложно": GameForm.difficulty = Difficulty.Hard; break;
            }
            GameForm.numberOfBalls = int.Parse(countLabel.Text);

            new GameForm().Show();
            Hide();
        }
    }
}
