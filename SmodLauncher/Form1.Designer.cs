namespace SmodLauncher
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.smod;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 12);
            label1.Name = "label1";
            label1.Size = new Size(404, 37);
            label1.TabIndex = 1;
            label1.Text = "smod";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 49);
            label2.Name = "label2";
            label2.Size = new Size(454, 19);
            label2.TabIndex = 2;
            label2.Text = "its shit but its free";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 285);
            button1.Name = "button1";
            button1.Size = new Size(282, 55);
            button1.TabIndex = 3;
            button1.Text = "play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bg;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 156);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(261, 123);
            label3.Name = "label3";
            label3.Size = new Size(276, 38);
            label3.TabIndex = 5;
            label3.Text = "screenshot";
            // 
            // label4
            // 
            label4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(261, 161);
            label4.Name = "label4";
            label4.Size = new Size(276, 118);
            label4.TabIndex = 6;
            label4.Text = "its a fucking filler";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(493, 12);
            button2.Name = "button2";
            button2.Size = new Size(44, 34);
            button2.TabIndex = 7;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Bahnschrift", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 86);
            label5.Name = "label5";
            label5.Size = new Size(525, 34);
            label5.TabIndex = 8;
            label5.Text = "what's new";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(300, 285);
            button3.Name = "button3";
            button3.Size = new Size(158, 55);
            button3.TabIndex = 9;
            button3.Text = "community";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(464, 285);
            button4.Name = "button4";
            button4.Size = new Size(73, 55);
            button4.TabIndex = 10;
            button4.Text = "hammer++";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 235, 52);
            ClientSize = new Size(549, 352);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Button button3;
        private Button button4;
    }
}