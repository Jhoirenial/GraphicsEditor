using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        // toolStripButton - все эллементы быстрого доступа( на панели)
        private List<ToolStripButton> allt = new List<ToolStripButton>();
        // toolStripMenuItem - инструменты меню
        private List<ToolStripMenuItem> allm = new List<ToolStripMenuItem>();
        // toolStripMenuItem - все линии карандаша
        private List<ToolStripMenuItem> allms = new List<ToolStripMenuItem>();
        private Color CurrentColor;
        private int PenWidth;
        private Point PointStart;
        private Point PointEnd;
        private bool DrawMode;
        private ArrayList points;
        private Bitmap bmpImage;
        private Bitmap bmpImageObject;
        private Bitmap bmpBg;
        private Bitmap bmpBgObject;
        private bool draw = false;
        private delegate void DrawHandler(MouseEventArgs e);
        TextureBrush texBrsuh;
        float kSideStar = (float)Math.Sqrt((5 - Math.Sqrt(5)) * 0.5d);
        float kRadiusStar = (float)(Math.Sqrt(10) * Math.Sqrt(5 + Math.Sqrt(5)) / 10.0d);
        float kGoldenStar = (float)((1 + Math.Sqrt(5)) * 0.5d);
        float kTan18 = (float)Math.Tan(Math.PI * 18.0d / 180.0d);

        public Form1()
        {
            // Загрузить форму
            InitializeComponent();

            CurrentColor = Color.Black;
            DrawMode = false;
            points = new ArrayList();
            btnPen.Checked = true;
            PenWidth = 1;

            allt.Add(this.btnBrush);
            allt.Add(this.btnEllipse);
            allt.Add(this.btnErase);
            allt.Add(this.btnFill);
            allt.Add(this.btnLine);
            allt.Add(this.btnPen);
            allt.Add(this.btnRectangle);

            allm.Add(this.msBrush);
            allm.Add(this.msEllipse);
            allm.Add(this.msEraser);
            allm.Add(this.msFill);
            allm.Add(this.msLine);
            allm.Add(this.msPen);
            allm.Add(this.msRectangle);

            allms.Add(this.msSolid);
            allms.Add(this.msDashed);
            allms.Add(this.msDotDashed);
            allms.Add(this.msDotDotDashed);
            allms.Add(this.msDotted);

            ArrayList arp = new ArrayList();
            this.Show();
            CreateField();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                CurrentColor = colorDialog1.Color;
                // Перерисовываем кисти
                if (btnBrush.Checked)
                {
                    RecreateBrushes();
                }
            }
        }
        private void DrawPen(MouseEventArgs e, Graphics g)
        {

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen mainPen = new Pen(CurrentColor, PenWidth);
            mainPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            mainPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            if (msSolid.Checked)
                mainPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else if (msDashed.Checked)
                mainPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            else if (msDotDashed.Checked)
                mainPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            else if (msDotDotDashed.Checked)
                mainPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            else if (msDotted.Checked)
                mainPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            if (points.Count <= 1) return;
            Point[] pts = new Point[points.Count];
            points.CopyTo(pts, 0);
            g.DrawCurve(mainPen, pts);

        }
        private void DrawBrush(MouseEventArgs e, Graphics g)
        {
            Pen mainPen = new Pen(CurrentColor, PenWidth);
            if (msBrush.Checked) mainPen = new Pen(texBrsuh);
            mainPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            mainPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;


            Point[] pts = new Point[points.Count];
            points.CopyTo(pts, 0);
            foreach (Point p in points)
            {
                g.DrawImage(texBrsuh.Image, p.X - texBrsuh.Image.Width / 2, p.Y - texBrsuh.Image.Height / 2);
            }
        }
        private void DrawErase(MouseEventArgs e, Graphics g)
        {
            Pen mainPen = new Pen(Color.White, PenWidth * 2);
            mainPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            mainPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            Point[] pts = new Point[points.Count];
            points.CopyTo(pts, 0);
            if (points.Count == 0) return;
            if (points.Count == 1)
            {
                g.FillEllipse(mainPen.Brush, pts[0].X - mainPen.Width / 2, pts[0].Y - mainPen.Width / 2, mainPen.Width, mainPen.Width);
                return;
            }
            g.DrawCurve(mainPen, pts);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cms.Show(pbImage, e.Location);
                return;
            }
            if (btnFill.Checked)
            {
                Graphics graphics = Graphics.FromImage(bmpBg);
                graphics.Clear(Color.White);
                graphics.DrawImage(bmpImage, 0, 0);
                Fill(graphics, e.Location, ref bmpImage);
                graphics.Dispose();
                pbImage.Image = bmpImage;
                pbImage.Refresh();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                DrawMode = true;
                points.Clear();
                PointStart = e.Location;
                points.Add(new Point(e.X, e.Y));
                if (!draw) BeginInvoke(new DrawHandler(Draw), e);

            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Не выполнять, если кнопка правая кнопка не была нажата
            if (!DrawMode) return;
            Point pt = new Point(e.X, e.Y);
            if (!msBrush.Checked | points.Count == 0)
                points.Add(pt);
            else if (points.Count > 0)
            {
                Point p = (Point)points[points.Count - 1];
                if (Math.Abs(p.X - pt.X) > 3 & Math.Abs(p.Y - pt.Y) > 3)
                    points.Add(pt);
            }
            // Когда Draw выполняется к нему не возможно обратиться
            if (!draw) BeginInvoke(new DrawHandler(Draw), e);
        }
        private void Draw(MouseEventArgs e)
        {
            draw = true;
            Graphics graphics = Graphics.FromImage(bmpImage);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.Clear(Color.White);
            graphics.DrawImage(bmpBg, 0, 0);
            Pen mainPen = new Pen(CurrentColor, PenWidth);
            mainPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            mainPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            mainPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            Brush brush = new SolidBrush(CurrentColor);
            PointEnd = e.Location;
            int topX = (PointStart.X > PointEnd.X) ? PointEnd.X : PointStart.X;
            int topY = (PointStart.Y > PointEnd.Y) ? PointEnd.Y : PointStart.Y;
            int width = (PointStart.X > PointEnd.X) ? PointStart.X - PointEnd.X : PointEnd.X - PointStart.X;
            int height = (PointStart.Y > PointEnd.Y) ? PointStart.Y - PointEnd.Y : PointEnd.Y - PointStart.Y;

            if (btnPen.Checked)
            {
                DrawPen(e, graphics);
            }
            else if (btnBrush.Checked)
            {
                DrawBrush(e, graphics);
            }
            else if (btnErase.Checked)
            {
                DrawErase(e, graphics);
            }
            else if (btnLine.Checked)
            {
                graphics.DrawLine(mainPen, PointStart, PointEnd);
            }

            else if (btnRectangle.Checked)
            {
                graphics.DrawRectangle(mainPen, topX, topY, width, height);
            }
            else if (btnEllipse.Checked)
            {
                graphics.DrawEllipse(mainPen, topX, topY, width, height);
            }
            graphics.Dispose();
            pbImage.Refresh();
            draw = false;
        }
        private void CreatePB(Pen mainPen, int topX, int topY, int width, int height)
        {

            bmpBgObject = bmpBg;
            bmpImageObject = bmpImage;
            // Создает новый объект Graphics из указанного рисунка Image.
            Graphics graphics = Graphics.FromImage(bmpImageObject);
            graphics.Clear(Color.DeepPink);
            graphics.Dispose();
            graphics = Graphics.FromImage(bmpBg);
            graphics.Clear(Color.DimGray);
            graphics.Dispose();
            //Задаются свойства для пикчабокс
            PictureBox pbImageObject = new PictureBox();
            pbImageObject.Width = width + 2;
            pbImageObject.Height = height + 2;
            pbImageObject.BackgroundImage = bmpBgObject;
            pbImageObject.Image = bmpImageObject;
            pbImageObject.Location = new Point(topX, topY);
            pbImageObject.Capture = true;
            pbImageObject.Capture = true;


        }
        private void CreateObject(Pen mainPen, int topX, int topY, int width, int height)
        {

            bmpBgObject = bmpBg;
            bmpImageObject = bmpImage;
            // Создает новый объект Graphics из указанного рисунка Image.
            Graphics graphics = Graphics.FromImage(bmpImageObject);
            graphics.Clear(Color.DeepPink);
            graphics.Dispose();
            graphics = Graphics.FromImage(bmpBg);
            graphics.Clear(Color.DimGray);
            graphics.Dispose();
            //Задаются свойства для PictureBox
            PictureBox pbImageObject = new PictureBox();
            pbImageObject.Width = width + 2;
            pbImageObject.Height = height + 2;
            pbImageObject.BackgroundImage = bmpBgObject;
            pbImageObject.Image = bmpImageObject;
            pbImageObject.Location = new Point(topX, topY);

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            DrawMode = false;
            bmpBg = new Bitmap(bmpImage);
            pbImage.Refresh();

        }
        private void penWidthChanged(object sender, EventArgs e)
        {
            try
            {
                PenWidth = Convert.ToInt32(txtPenWidth.Text);
                if (msBrush.Checked) RecreateBrushes();
            }
            catch { }
        }
        #region
        // Проверить какая из кистей выбрана
        private void RecreateBrushes()
        {

            if (msBrushStar.Checked) EvaluateStar();
            else if (msBrushSuperStar.Checked) EvaluateSuperStar();
            else if (msBrushGrass.Checked) EvaluateGrass();
        }
        private void EvaluateStar()
        {
            GraphicsPath gp = new GraphicsPath();
            int width = PenWidth + 9;
            float R = width / 2;
            float A = kSideStar * R;
            float D2 = kGoldenStar * A / 2.0f;
            float l = (float)(Math.Sqrt(R * R - D2 * D2));
            float a = 2.0f * l * kTan18;
            float d2 = kGoldenStar * a / 2.0f;
            float r = kRadiusStar * a;

            PointF[] pt = new PointF[12];
            float x, y;
            int w = (int)(width * 1.5f) / 2;

            pt[0] = pt[10] = new PointF(w, w - R);
            pt[5] = new PointF(w, w + 1.5f * r);

            x = 1.5f * a / 2;
            y = l;
            pt[1] = pt[11] = new PointF(w + x, w - y);
            pt[9] = new PointF(w - x, w - y);

            x = A / 2;
            y = (float)(Math.Sqrt(R * R - x * x));
            pt[4] = new PointF(w + x, w + y);
            pt[6] = new PointF(w - x, w + y);

            x = D2;
            y = l;
            pt[2] = new PointF(w + x, w - y);
            pt[8] = new PointF(w - x, w - y);

            x = 1.5f * d2;
            y = (float)(1.5f * Math.Sqrt(r * r - d2 * d2));
            pt[3] = new PointF(w + x, w + y);
            pt[7] = new PointF(w - x, w + y);

            gp.AddLines(pt);

            w = (int)(width * 1.5f);
            Bitmap bmp = new Bitmap(w, w);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            Pen mainPen = new Pen(Color.FromArgb(80, CurrentColor), PenWidth / 10);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawPath(mainPen, gp);
            g.Dispose();
            texBrsuh = new TextureBrush(bmp);
        }
        private void EvaluateSuperStar()
        {
            GraphicsPath gp = new GraphicsPath();
            PointF[] pt = new PointF[18];
            int width = PenWidth + 9;

            float x = width / 2 + PenWidth + 1;
            float r = width / 2;
            float alpha = 0;

            for (int i = 0; i < 16; i++)
            {
                pt[i] = new PointF((float)(x + r * Math.Cos(Math.PI * alpha / 180) * ((i % 2 == 1) ? 0.5f : 1.0f)),
                    (float)(x - r * Math.Sin(Math.PI * alpha / 180) * ((i % 2 == 1) ? 0.5f : 1.0f)));
                alpha += 22.5f;
            }
            pt[16] = pt[0];
            pt[17] = pt[1];
            gp.AddLines(pt);

            Bitmap bmp = new Bitmap((int)x * 2, (int)x * 2);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            Pen mainPen = new Pen(Color.FromArgb(80, CurrentColor), PenWidth / 10);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawPath(mainPen, gp);
            g.Dispose();
            texBrsuh = new TextureBrush(bmp);
        }
        private void EvaluateGrass()
        {
            GraphicsPath gp = new GraphicsPath();
            PointF[] pt = new PointF[10];
            int width = PenWidth + 9;

            pt[0] = pt[7] = new PointF(0.5f * width, 0.1f * width);
            pt[1] = pt[8] = new PointF(0.35f * width, 0.3f * width);
            pt[2] = pt[9] = new PointF(0.2f * width, 0.55f * width);
            pt[3] = new PointF(0.18f * width, 0.9f * width);
            pt[4] = new PointF(0.15f * width, 0.875f * width);
            pt[5] = new PointF(0.177f * width, 0.55f * width);
            pt[6] = new PointF(0.34f * width, 0.3f * width);

            gp.AddBeziers(pt);
            Bitmap bmp = new Bitmap(width, width);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            Pen mainPen = new Pen(Color.FromArgb(128, CurrentColor), PenWidth / 10);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.FillPath(mainPen.Brush, gp);
            g.Dispose();
            texBrsuh = new TextureBrush(bmp);
        }

        // Синхронизирует выбранный эллемент меню с тулбаром и на оборот( следующий метод)
        private void btnTools_Click(object sender, EventArgs e)
        {
            // Синхронизирует выбранный эллемент меню с тулбаром и на оборот
            for (int i = 0; i < allt.Count; i++)
            {
                allt[i].Checked = allm[i].Checked = (allt[i] == sender);
            }
            // Перерисовывает Кисти, если они нажаты
            if (btnBrush.Checked)
            {
                RecreateBrushes();
            }
        }
        private void msTools_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allm.Count; i++)
            {
                allt[i].Checked = allm[i].Checked = (allm[i] == sender);
            }
        }
        // Активирует выбранный Pen 
        private void cmsPenStyle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allms.Count; i++)
            {
                allms[i].Checked = (allms[i] == sender);
            }
            btnPen.PerformClick();
        }
        /// <summary>
        /// Заливка области
        /// </summary>
        /// <param name="g">График отображаемого объекта (например, панели)</param>
        /// <param name="pos">Точка, в которой начинается заливка</param>    
        /// <param name="colorFill">Цвет заливки</param>
        /// <param name="img">Битмап, который отображается на нашем объекте</param>
        public void Fill(Graphics g, Point pos, ref Bitmap img)
        {
            GDI d = new GDI();

            // Цвет в точке, с которой начинается заливка


            Color colorBegin = img.GetPixel(pos.X, pos.Y);

            // DC панели
            IntPtr panelDC = g.GetHdc();

            // DC в памяти, совместимый с панелью
            IntPtr memDC = d.CreateCOMPATIBLEDC(panelDC);

            // Создаем и подсовываем свою кисть
            IntPtr hBrush = d.CreateSolidBRUSH((uint)ColorTranslator.ToWin32(CurrentColor));
            IntPtr hOldBr = d.SelectOBJECT(memDC, hBrush);

            // Подсовываем свой битмап
            IntPtr hBMP = img.GetHbitmap();
            IntPtr hOldBmp = d.SelectOBJECT(memDC, hBMP);

            // Заливаем (заливается благодаря совместимости с панелью, в противном случае 
            // заливки на битмапе не произойдет)
            d.ExtFloodFILL(memDC, pos.X, pos.Y, (uint)ColorTranslator.ToWin32(colorBegin), 1);

            // Записываем полученный залитый битмап в наш битмап
            img.Dispose();
            img = Bitmap.FromHbitmap(hBMP);

            // Возвращаем на место предыдущие кисть и битмап
            d.SelectOBJECT(memDC, hOldBr);
            d.SelectOBJECT(memDC, hOldBmp);

            // Освобождаем использованные ресурсы
            d.DeleteOBJECT(hBMP);
            d.DeleteOBJECT(hBrush);
            d.DeleteOBJECT(memDC);
        }
        private void tsmiCreate_Click(object sender, EventArgs e)
        {
            CreateField();
        }
        #endregion
        private void CreateField()
        {
            FormSize fs = new FormSize();
            fs.ShowDialog();
            bmpImage = new Bitmap(fs.width, fs.height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            bmpBg = new Bitmap(fs.width, fs.height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            // Создает новый объект Graphics из указанного рисунка Image.
            Graphics graphics = Graphics.FromImage(bmpImage);
            graphics.Clear(Color.White);
            graphics.Dispose();
            graphics = Graphics.FromImage(bmpBg);
            graphics.Clear(Color.White);
            graphics.Dispose();
            //Задаются свойства канвы рисования
            pbImage.Width = fs.width + 2;
            pbImage.Height = fs.height + 2;
            pbImage.BackgroundImage = bmpBg;
            pbImage.Image = bmpImage;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bmpBg = new Bitmap(ofd.FileName);
                bmpImage = new Bitmap(bmpBg);
                pbImage.Size = bmpBg.Size;
                pbImage.BackgroundImage = bmpBg;
                pbImage.Image = bmpImage;
            }
        }
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sfd.FilterIndex == 1)
                    bmpImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (sfd.FilterIndex == 2)
                    bmpImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                else if (sfd.FilterIndex == 3)
                    bmpImage.Save(sfd.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Сохранить работу в файл?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        bmpImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                        e.Cancel = true;
                    break;
                case System.Windows.Forms.DialogResult.No:
                    return;
                default:
                    e.Cancel = true;
                    return;
            }
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsBrushStyles_Click(object sender, EventArgs e)
        {
            msBrushStar.Checked = (msBrushStar == sender);
            msBrushSuperStar.Checked = (msBrushSuperStar == sender);
            msBrushGrass.Checked = (msBrushGrass == sender);
            btnBrush.PerformClick();
        }

        private void GetBrightness_Click(object sender, EventArgs e)
        {
            ToolTip toolTip;
            toolTip = new ToolTip();
            toolTip.SetToolTip(GetBrightness, "Сохранить яркость изображения в файл");

            int getWidth = pbImage.Image.Width;
          
            int getHeight = pbImage.Image.Height;

            if(getWidth * getHeight == 0) 
            {
                MessageBox.Show("Size can not be equal 0!");
                Application.Exit();
            }

            try
            {
                // Путь в который мы сохраняем файл
                string path = "D:\\Result.txt";
                StreamWriter sw = new StreamWriter(path);

                Color pixelColor = new Color();
                string str = pixelColor + "";

                int R = 0;
                int G = 0;
                int B = 0;
                int tmp = 0;
                string s = "";

                for (int height = 0; height < getHeight; height++)
                {
                    for (int width = 0; width < getWidth; width++)
                    {
                        pixelColor = bmpImage.GetPixel(width, height);
                        str = pixelColor + "";
                        int count = 0;
                        bool first = true;
                        for (int lineItem = 0; lineItem < str.Length; lineItem++)
                        {
                            if (str[lineItem] == '=')
                            {
                                if (!first)
                                {
                                    while (str[lineItem + 1] != ',' && str[lineItem + 1] != ']')
                                    {
                                        lineItem = lineItem + 1;
                                        s = s + str[lineItem];
                                    }

                                    int.TryParse(s, out tmp);

                                    switch (count)
                                    {
                                        case 1:
                                            R = R + tmp;
                                            sw.Write(R + " ");
                                            R = 0;
                                            break;
                                        case 2:
                                            G = G + tmp;
                                            sw.Write(G + " ");
                                            G = 0;
                                            break;
                                        case 3:
                                            B = B + tmp;
                                            sw.Write(B + " / ");
                                            B = 0;
                                            break;
                                    }
                                }
                                first = false;
                            }
                            else
                            {
                                continue;
                            }

                            count++;
                            s = "";
                            tmp = 0;
                        }
                    }
                    sw.WriteLine();
                    sw.WriteLine();
                }

                // Рассчитаем общее количество пикселей изображения 
                //int imageParams = getWidth * getHeight;

                //MessageBox.Show(R/imageParams + " " + G/imageParams + " " + B/imageParams);

                // Среднее арифметическое RGB
                //int getAvgBrightness = (R / imageParams + G / imageParams + B / imageParams) / 3;

                MessageBox.Show("Файл создан на " + path);

                MessageBox.Show("Запись в файл успешно выполнена");
                
                //Закрываем файл
                sw.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show("Exception: " + m.Message);
            }
        }
    }
  
    // Класс, в котором импортированы некоторые функции GDI 
    public class GDI
    {
        public IntPtr CreateSolidBRUSH(uint color)
        {
            return CreateSolidBrush(color);
        }

        public bool ExtFloodFILL(IntPtr hdcSourse, int x, int y, uint сolorRefColor, uint nFillType)
        {
            return ExtFloodFill(hdcSourse, x, y, сolorRefColor, nFillType);
        }

        public IntPtr SelectOBJECT(IntPtr hDCSourse, IntPtr hBitmap)
        {
            return SelectObject(hDCSourse, hBitmap);
        }

        public IntPtr CreateCOMPATIBLEDC(IntPtr hdcSourse)
        {
            return CreateCompatibleDC(hdcSourse);
        }

        public bool DeleteOBJECT(IntPtr hObject)
        {
            return DeleteObject(hObject);
        }


        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr CreateSolidBrush(uint crColor);

        [DllImport("gdi32", CharSet = CharSet.Auto)]
        private static extern bool ExtFloodFill(IntPtr hDC, int x, int y, uint сolorRefColor, uint nFillType);

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);
    }
}