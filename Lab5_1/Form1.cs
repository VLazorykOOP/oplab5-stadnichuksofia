namespace Task1Lab5pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            
            float x1 = float.Parse(textBoxX1.Text);
            float y1 = float.Parse(textBoxY1.Text);
            float x2 = float.Parse(textBoxX2.Text);
            float y2 = float.Parse(textBoxY2.Text);
            float vx1 = float.Parse(textBoxVx1.Text);
            float vy1 = float.Parse(textBoxVy1.Text);
            float vx2 = float.Parse(textBoxVx2.Text);
            float vy2 = float.Parse(textBoxVy2.Text);

            
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

            
            DrawHermiteCurve(g, x1, y1, x2, y2, vx1, vy1, vx2, vy2);

            
            pictureBox1.Invalidate();
        }

        private void DrawHermiteCurve(Graphics g, float x1, float y1, float x2, float y2, float vx1, float vy1, float vx2, float vy2)
        {
            Pen pen = new Pen(Color.DarkGreen, 5);
            const int steps = 100;

            for (int i = 0; i < steps; i++)
            {
                float t1 = i / (float)steps;
                float t2 = (i + 1) / (float)steps;

                PointF p1 = GetHermitePoint(t1, x1, y1, x2, y2, vx1, vy1, vx2, vy2);
                PointF p2 = GetHermitePoint(t2, x1, y1, x2, y2, vx1, vy1, vx2, vy2);

                g.DrawLine(pen, p1, p2);
            }
        }

        private PointF GetHermitePoint(float t, float x1, float y1, float x2, float y2, float vx1, float vy1, float vx2, float vy2)
        {
            float h1 = 2 * t * t * t - 3 * t * t + 1;
            float h2 = -2 * t * t * t + 3 * t * t;
            float h3 = t * t * t - 2 * t * t + t;
            float h4 = t * t * t - t * t;

            float x = h1 * x1 + h2 * x2 + h3 * vx1 + h4 * vx2;
            float y = h1 * y1 + h2 * y2 + h3 * vy1 + h4 * vy2;

            return new PointF(x, y);
        }

       }
    }
