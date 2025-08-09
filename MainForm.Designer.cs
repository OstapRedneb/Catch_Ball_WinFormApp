namespace Catch_Ball_WinFormApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            startButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.Indigo;
            startButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = Color.Red;
            startButton.Location = new Point(339, 146);
            startButton.Name = "startButton";
            startButton.Size = new Size(163, 72);
            startButton.TabIndex = 0;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Indigo;
            exitButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.Red;
            exitButton.Location = new Point(339, 224);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(163, 72);
            exitButton.TabIndex = 1;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 468);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "Поймай мячики!";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button exitButton;
    }
}
