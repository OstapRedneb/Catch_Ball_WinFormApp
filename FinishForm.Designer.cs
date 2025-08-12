namespace Catch_Ball_WinFormApp
{
    partial class FinishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishForm));
            finishButton = new Button();
            showLabel = new Label();
            SuspendLayout();
            // 
            // finishButton
            // 
            finishButton.BackColor = Color.DarkOrchid;
            finishButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            finishButton.ForeColor = Color.DarkRed;
            finishButton.Location = new Point(304, 324);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(179, 72);
            finishButton.TabIndex = 0;
            finishButton.Text = "Завершить";
            finishButton.UseVisualStyleBackColor = false;
            finishButton.Click += finishButton_Click;
            // 
            // showLabel
            // 
            showLabel.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.Red;
            showLabel.Image = (Image)resources.GetObject("showLabel.Image");
            showLabel.ImageAlign = ContentAlignment.TopCenter;
            showLabel.Location = new Point(106, 43);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(578, 157);
            showLabel.TabIndex = 1;
            showLabel.Text = "Вы упустили мяч! Вы проиграли!";
            // 
            // FinishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(showLabel);
            Controls.Add(finishButton);
            Name = "FinishForm";
            Text = "FinishForm";
            ResumeLayout(false);
        }

        #endregion

        private Button finishButton;
        private Label showLabel;
    }
}