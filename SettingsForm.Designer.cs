namespace Catch_Ball_WinFormApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            hScrollBar1 = new HScrollBar();
            showLabel = new Label();
            countLabel = new Label();
            dificultLabel = new Label();
            showLabel1 = new Label();
            hScrollBar2 = new HScrollBar();
            beginButton = new Button();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(364, 66);
            hScrollBar1.Maximum = 20;
            hScrollBar1.Minimum = 1;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(201, 38);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Value = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.Location = new Point(105, 66);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(244, 38);
            showLabel.TabIndex = 1;
            showLabel.Text = "Число шариков: ";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            countLabel.Location = new Point(590, 66);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(33, 38);
            countLabel.TabIndex = 2;
            countLabel.Text = "1";
            // 
            // dificultLabel
            // 
            dificultLabel.AutoSize = true;
            dificultLabel.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dificultLabel.Location = new Point(590, 152);
            dificultLabel.Name = "dificultLabel";
            dificultLabel.Size = new Size(94, 38);
            dificultLabel.TabIndex = 5;
            dificultLabel.Text = "Легко";
            // 
            // showLabel1
            // 
            showLabel1.AutoSize = true;
            showLabel1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel1.Location = new Point(181, 152);
            showLabel1.Name = "showLabel1";
            showLabel1.Size = new Size(168, 38);
            showLabel1.TabIndex = 4;
            showLabel1.Text = "Сложность:";
            // 
            // hScrollBar2
            // 
            hScrollBar2.LargeChange = 1;
            hScrollBar2.Location = new Point(364, 152);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(201, 38);
            hScrollBar2.TabIndex = 3;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // beginButton
            // 
            beginButton.BackColor = Color.Black;
            beginButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            beginButton.ForeColor = Color.Purple;
            beginButton.Location = new Point(313, 330);
            beginButton.Name = "beginButton";
            beginButton.Size = new Size(163, 72);
            beginButton.TabIndex = 6;
            beginButton.Text = "Начать";
            beginButton.UseVisualStyleBackColor = false;
            beginButton.Click += beginButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(beginButton);
            Controls.Add(dificultLabel);
            Controls.Add(showLabel1);
            Controls.Add(hScrollBar2);
            Controls.Add(countLabel);
            Controls.Add(showLabel);
            Controls.Add(hScrollBar1);
            Name = "SettingsForm";
            Text = "Настройки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private Label showLabel;
        private Label countLabel;
        private Label dificultLabel;
        private Label showLabel1;
        private HScrollBar hScrollBar2;
        private Button beginButton;
    }
}