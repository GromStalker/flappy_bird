namespace FlappyBird
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pipe_up = new PictureBox();
            ground = new PictureBox();
            pipe_down = new PictureBox();
            flappy = new PictureBox();
            lb_score = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pipe_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pipe_up
            // 
            pipe_up.Image = Properties.Resources.pipe;
            pipe_up.Location = new Point(486, 368);
            pipe_up.Name = "pipe_up";
            pipe_up.Size = new Size(100, 270);
            pipe_up.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_up.TabIndex = 0;
            pipe_up.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(0, 621);
            ground.Name = "ground";
            ground.Size = new Size(639, 99);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 1;
            ground.TabStop = false;
            // 
            // pipe_down
            // 
            pipe_down.Image = Properties.Resources.pipedown;
            pipe_down.Location = new Point(385, -32);
            pipe_down.Name = "pipe_down";
            pipe_down.Size = new Size(100, 142);
            pipe_down.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_down.TabIndex = 2;
            pipe_down.TabStop = false;
            // 
            // flappy
            // 
            flappy.Image = Properties.Resources.bird;
            flappy.Location = new Point(69, 266);
            flappy.Name = "flappy";
            flappy.Size = new Size(65, 57);
            flappy.SizeMode = PictureBoxSizeMode.StretchImage;
            flappy.TabIndex = 3;
            flappy.TabStop = false;
            flappy.Click += pictureBox4_Click;
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.BackColor = Color.FromArgb(255, 192, 128);
            lb_score.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lb_score.Location = new Point(91, 20);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(197, 55);
            lb_score.TabIndex = 4;
            lb_score.Text = "Score:0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(634, 711);
            Controls.Add(lb_score);
            Controls.Add(flappy);
            Controls.Add(pipe_down);
            Controls.Add(ground);
            Controls.Add(pipe_up);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pipe_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappy).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipe_up;
        private PictureBox pipe_down;
        private PictureBox flappy;
        private Label lb_score;
        private System.Windows.Forms.Timer timer1;
        private BindingSource bindingSource1;
        private PictureBox ground;
    }
}
