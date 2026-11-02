using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        string currentTool = "Карандаш";
        Color currentColor = Color.Black;
        string textToPrint = ""; 
        Bitmap map;
        Bitmap tempMap;
        Graphics graphics;
        Pen pen;
        bool isDrawing = false;
        Point startPoint;
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(map);
            graphics.Clear(Color.White);
            pictureBox1.Image = map;
            pen = new Pen(Color.Black, 3);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pen.Width = trackBar1.Value;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentTool == "Текст")
            {
                using (Form textForm = new Form())
                {
                    textForm.Width = 300;
                    textForm.Height = 150;
                    textForm.Text = "Введите текст холста";
                    textForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    textForm.StartPosition = FormStartPosition.CenterParent;
                    TextBox textBox = new TextBox() { Left = 20, Top = 20, Width = 240 };
                    Button buttonOk = new Button() { Text = "ОК", Left = 185, Top = 60, DialogResult = DialogResult.OK };
                    textForm.Controls.Add(textBox);
                    textForm.Controls.Add(buttonOk);

                    if (textForm.ShowDialog() == DialogResult.OK)
                    {
                        textToPrint = textBox.Text;
                        if (!string.IsNullOrEmpty(textToPrint))
                        {
                            using (Font font = new Font("Arial", pen.Width * 3))
                            using (Brush brush = new SolidBrush(currentColor))
                            {
                                graphics.DrawString(textToPrint, font, brush, e.Location);
                            }
                            pictureBox1.Refresh();
                        }
                    }
                }
                return;
            }
            isDrawing = true;
            startPoint = e.Location;
            lastPoint = e.Location;
            if (currentTool == "Заливка")
            {
                FloodFill(map, e.X, e.Y, currentColor);
                pictureBox1.Refresh();
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"MyPaint | X: {e.X}, Y: {e.Y}";
            if (!isDrawing) return;
            if (currentTool == "Карандаш")
            {
                graphics.DrawLine(pen, lastPoint, e.Location);
                lastPoint = e.Location;
                pictureBox1.Refresh();
            }
            else if (currentTool == "Ластик")
            {
                using (Pen eraserPen = new Pen(Color.White, pen.Width))
                {
                    eraserPen.StartCap = pen.StartCap;
                    eraserPen.EndCap = pen.EndCap;
                    graphics.DrawLine(eraserPen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                pictureBox1.Refresh();
            }
            else if (currentTool == "Заливка" || currentTool == "Текст")
            {
            }
            else
            {
                tempMap = (Bitmap)map.Clone();

                using (Graphics tempGraphics = Graphics.FromImage(tempMap))
                {
                    using (Pen tempPen = new Pen(currentColor, pen.Width))
                    {
                        tempPen.StartCap = pen.StartCap;
                        tempPen.EndCap = pen.EndCap;

                        if (currentTool == "Линия")
                        {
                            tempGraphics.DrawLine(tempPen, startPoint, e.Location);
                        }
                        else if (currentTool == "Прямоугольник")
                        {
                            int x = Math.Min(startPoint.X, e.X);
                            int y = Math.Min(startPoint.Y, e.Y);
                            int width = Math.Abs(startPoint.X - e.X);
                            int height = Math.Abs(startPoint.Y - e.Y);
                            tempGraphics.DrawRectangle(tempPen, x, y, width, height);
                        }
                        else if (currentTool == "Эллипс")
                        {
                            int x = Math.Min(startPoint.X, e.X);
                            int y = Math.Min(startPoint.Y, e.Y);
                            int width = Math.Abs(startPoint.X - e.X);
                            int height = Math.Abs(startPoint.Y - e.Y);
                            tempGraphics.DrawEllipse(tempPen, x, y, width, height);
                        }
                    }
                }
                pictureBox1.Image = tempMap;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;

            if (currentTool == "Линия" || currentTool == "Прямоугольник" || currentTool == "Эллипс")
            {
                if (tempMap != null)
                {
                    map = (Bitmap)tempMap.Clone();
                    graphics = Graphics.FromImage(map);
                    pictureBox1.Image = map;
                }
            }
        }
        private void btnBlack_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            pen.Color = currentColor;
            if (currentTool == "Ластик") currentTool = "Карандаш";
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
            pen.Color = currentColor;
            if (currentTool == "Ластик") currentTool = "Карандаш";
        }
        private void btnPalette_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                pen.Color = currentColor;
                if (currentTool == "Ластик") currentTool = "Карандаш";
            }
        }
        private void btnEraser_Click(object sender, EventArgs e)
        {
            currentTool = "Ластик";
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Изображение JPG|*.jpg|Изображение PNG|*.png";
            saveFileDialog1.Title = "Сохранить рисунок";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    map.Save(saveFileDialog1.FileName);
                }
            }
        }
        private void FloodFill(Bitmap bmp, int x, int y, Color targetColor)
        {
            Color originalColor = bmp.GetPixel(x, y);
            if (originalColor.ToArgb() == targetColor.ToArgb()) return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point a = pixels.Dequeue();
                if (a.X < 0 || a.X >= bmp.Width || a.Y < 0 || a.Y >= bmp.Height) continue;

                if (bmp.GetPixel(a.X, a.Y).ToArgb() == originalColor.ToArgb())
                {
                    bmp.SetPixel(a.X, a.Y, targetColor);

                    pixels.Enqueue(new Point(a.X - 1, a.Y));
                    pixels.Enqueue(new Point(a.X + 1, a.Y));
                    pixels.Enqueue(new Point(a.X, a.Y - 1));
                    pixels.Enqueue(new Point(a.X, a.Y + 1));
                }
            }
        }
        private void btnPencil_Click(object sender, EventArgs e) { currentTool = "Карандаш"; }
        private void btnBucket_Click(object sender, EventArgs e) { currentTool = "Заливка"; }
        private void btnLine_Click(object sender, EventArgs e) { currentTool = "Линия"; }
        private void btnRect_Click(object sender, EventArgs e) { currentTool = "Прямоугольник"; }
        private void btnEllipse_Click(object sender, EventArgs e) { currentTool = "Эллипс"; }
        private void btnText_Click(object sender, EventArgs e)
        {
            currentTool = "Текст";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (graphics != null)
            {
                graphics.Clear(Color.White);
                pictureBox1.Refresh();
            }
        }
    }
}
