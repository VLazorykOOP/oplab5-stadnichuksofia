namespace Task1Lab5pr
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxVx1;
        private System.Windows.Forms.TextBox textBoxVy1;
        private System.Windows.Forms.TextBox textBoxVx2;
        private System.Windows.Forms.TextBox textBoxVy2;
        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonDraw = new Button();
            textBoxX1 = new TextBox();
            textBoxY1 = new TextBox();
            textBoxX2 = new TextBox();
            textBoxY2 = new TextBox();
            textBoxVx1 = new TextBox();
            textBoxVy1 = new TextBox();
            textBoxVx2 = new TextBox();
            textBoxVy2 = new TextBox();
            pictureBox1 = new PictureBox();
            LX1 = new Label();
            LY1 = new Label();
            LX2 = new Label();
            LY2 = new Label();
            LVX1 = new Label();
            LVY1 = new Label();
            LVX2 = new Label();
            LVY2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(20, 53);
            buttonDraw.Margin = new Padding(6, 5, 6, 5);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(126, 45);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(156, 53);
            textBoxX1.Margin = new Padding(6, 5, 6, 5);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(81, 31);
            textBoxX1.TabIndex = 1;
            textBoxX1.Text = "100";
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(249, 53);
            textBoxY1.Margin = new Padding(6, 5, 6, 5);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(81, 31);
            textBoxY1.TabIndex = 2;
            textBoxY1.Text = "200";
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(341, 53);
            textBoxX2.Margin = new Padding(6, 5, 6, 5);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(81, 31);
            textBoxX2.TabIndex = 3;
            textBoxX2.Text = "400";
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(434, 53);
            textBoxY2.Margin = new Padding(6, 5, 6, 5);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(81, 31);
            textBoxY2.TabIndex = 4;
            textBoxY2.Text = "200";
            // 
            // textBoxVx1
            // 
            textBoxVx1.Location = new Point(529, 53);
            textBoxVx1.Margin = new Padding(6, 5, 6, 5);
            textBoxVx1.Name = "textBoxVx1";
            textBoxVx1.Size = new Size(81, 31);
            textBoxVx1.TabIndex = 5;
            textBoxVx1.Text = "150";
            // 
            // textBoxVy1
            // 
            textBoxVy1.Location = new Point(621, 53);
            textBoxVy1.Margin = new Padding(6, 5, 6, 5);
            textBoxVy1.Name = "textBoxVy1";
            textBoxVy1.Size = new Size(81, 31);
            textBoxVy1.TabIndex = 6;
            textBoxVy1.Text = "-150";
            // 
            // textBoxVx2
            // 
            textBoxVx2.Location = new Point(714, 53);
            textBoxVx2.Margin = new Padding(6, 5, 6, 5);
            textBoxVx2.Name = "textBoxVx2";
            textBoxVx2.Size = new Size(81, 31);
            textBoxVx2.TabIndex = 7;
            textBoxVx2.Text = "150";
            // 
            // textBoxVy2
            // 
            textBoxVy2.Location = new Point(809, 53);
            textBoxVy2.Margin = new Padding(6, 5, 6, 5);
            textBoxVy2.Name = "textBoxVy2";
            textBoxVy2.Size = new Size(81, 31);
            textBoxVy2.TabIndex = 8;
            textBoxVy2.Text = "100";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 102);
            pictureBox1.Margin = new Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1293, 740);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LX1
            // 
            LX1.AutoSize = true;
            LX1.Location = new Point(156, 23);
            LX1.Margin = new Padding(4, 0, 4, 0);
            LX1.Name = "LX1";
            LX1.Size = new Size(33, 25);
            LX1.TabIndex = 10;
            LX1.Text = "X1";
            // 
            // LY1
            // 
            LY1.AutoSize = true;
            LY1.Location = new Point(249, 23);
            LY1.Margin = new Padding(4, 0, 4, 0);
            LY1.Name = "LY1";
            LY1.Size = new Size(32, 25);
            LY1.TabIndex = 11;
            LY1.Text = "Y1";
            // 
            // LX2
            // 
            LX2.AutoSize = true;
            LX2.Location = new Point(341, 23);
            LX2.Margin = new Padding(4, 0, 4, 0);
            LX2.Name = "LX2";
            LX2.Size = new Size(33, 25);
            LX2.TabIndex = 12;
            LX2.Text = "X2";
            // 
            // LY2
            // 
            LY2.AutoSize = true;
            LY2.Location = new Point(434, 23);
            LY2.Margin = new Padding(4, 0, 4, 0);
            LY2.Name = "LY2";
            LY2.Size = new Size(32, 25);
            LY2.TabIndex = 13;
            LY2.Text = "Y2";
            // 
            // LVX1
            // 
            LVX1.AutoSize = true;
            LVX1.Location = new Point(527, 23);
            LVX1.Margin = new Padding(4, 0, 4, 0);
            LVX1.Name = "LVX1";
            LVX1.Size = new Size(44, 25);
            LVX1.TabIndex = 14;
            LVX1.Text = "VX1";
            // 
            // LVY1
            // 
            LVY1.AutoSize = true;
            LVY1.Location = new Point(621, 23);
            LVY1.Margin = new Padding(4, 0, 4, 0);
            LVY1.Name = "LVY1";
            LVY1.Size = new Size(43, 25);
            LVY1.TabIndex = 15;
            LVY1.Text = "VY1";
            // 
            // LVX2
            // 
            LVX2.AutoSize = true;
            LVX2.Location = new Point(714, 23);
            LVX2.Margin = new Padding(4, 0, 4, 0);
            LVX2.Name = "LVX2";
            LVX2.Size = new Size(44, 25);
            LVX2.TabIndex = 16;
            LVX2.Text = "VX2";
            // 
            // LVY2
            // 
            LVY2.AutoSize = true;
            LVY2.Location = new Point(809, 23);
            LVY2.Margin = new Padding(4, 0, 4, 0);
            LVY2.Name = "LVY2";
            LVY2.Size = new Size(43, 25);
            LVY2.TabIndex = 17;
            LVY2.Text = "VY2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(LVY2);
            Controls.Add(LVX2);
            Controls.Add(LVY1);
            Controls.Add(LVX1);
            Controls.Add(LY2);
            Controls.Add(LX2);
            Controls.Add(LY1);
            Controls.Add(LX1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxVy2);
            Controls.Add(textBoxVx2);
            Controls.Add(textBoxVy1);
            Controls.Add(textBoxVx1);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxY1);
            Controls.Add(textBoxX1);
            Controls.Add(buttonDraw);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Hermite Curve";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label LX1;
        private Label LY1;
        private Label LX2;
        private Label LY2;
        private Label LVX1;
        private Label LVY1;
        private Label LVX2;
        private Label LVY2;
    }
}