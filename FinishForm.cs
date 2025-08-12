using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_Ball_WinFormApp
{
    public partial class FinishForm : Form
    {
        public static Game game = Game.Loose;
        public FinishForm()
        {
            InitializeComponent();
            switch (game) 
            {
                case Game.Loose: 
                    showLabel.Text = "Вы упустили мяч!\nВы проиграли!"; 
                    showLabel.ForeColor = Color.Red;
                    break;
                case Game.Success: 
                    showLabel.Text = "Вы поймали все мячи!\nВы Выиграли!";
                    showLabel.ForeColor = Color.Green;
                    break;
            }
            Controls.Add(showLabel);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Close();
        }
    }
}
