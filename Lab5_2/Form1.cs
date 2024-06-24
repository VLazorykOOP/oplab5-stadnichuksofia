using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lab5_2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо значення порядку K з текстового поля
            if (!int.TryParse(textBox1.Text, out int orderK))
            {
                MessageBox.Show("Please enter a valid integer for K.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White); // Очистити попереднє зображення

            DrawHarterHeighway(orderK, 0, 0, pictureBox1.Width, pictureBox1.Height, g);

            pictureBox1.Image = bmp;
        }

        private void DrawHarterHeighway(int order, float x1, float y1, float x2, float y2, Graphics g)
        {
            if (order == 0)
            {
                // Випадкове малювання відрізків
                Pen pen = new Pen(GetRandomBlueColor(), 2);
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            else
            {
                // Рекурсивно малюємо фрактал
                float dx = (x2 - x1) / 3;
                float dy = (y2 - y1) / 3;

                float mx = x1 + dx;
                float my = y1 + dy;

                DrawHarterHeighway(order - 1, x1, y1, mx, my, g);
                DrawHarterHeighway(order - 1, x2, y2, mx, my, g);

                float nx = mx + dx * 0.5f - dy * 0.866f;
                float ny = my + dy * 0.5f + dx * 0.866f;

                DrawHarterHeighway(order - 1, mx, my, nx, ny, g);
            }
        }

        private Color GetRandomBlueColor()
        {
            int blueValue = random.Next(100, 256); // Випадковий відтінок синього
            return Color.FromArgb(255, 0, 0, blueValue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}