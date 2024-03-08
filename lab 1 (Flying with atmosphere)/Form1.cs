using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_1__Flying_with_atmosphere_
{
    public partial class Form1 : Form
    {
        private ChartArea chartArea;
        private List<Series> seriesList = new List<Series>();
        private Timer timer = new Timer();
        private double angle;
        private double speed;
        private double size;
        private double frequency;
        private double weight;
        private double currentTime = 0;
        private int i = 0;
        double area = 0;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;
        double t, x, y, v0, cosa, sina, S, m, k, vx, vy;
        private int currentIndex = 0;
        private List<Point> points = new List<Point>();

        public class Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double.TryParse(inputSpeed.Text, out speed);
            double.TryParse(inputAngle.Text, out angle);
            double.TryParse(inputSize.Text, out size);
            double.TryParse(inputWeight.Text, out weight);
            double.TryParse(inputFrequency.Text, out frequency);


            if (!timer.Enabled)
            {
                chart1.Series[i].Points.Clear();
                t = 0;
                x = 0;
                y = 0;
                double maxX = 0;
                double maxY = 0;
                v0 = speed;
                double a = angle * Math.PI / 180;
                cosa = Math.Cos(a);
                sina = Math.Sin(a);
                S = size;
                m = weight;
                k = 0.5 * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[i].Points.AddXY(x, y);

                // Создаем список точек
                do
                {
                    t += frequency;
                    double v = (double)Math.Sqrt((double)(vx * vx + vy * vy));
                    vx = vx - k * vx * v * frequency;
                    vy = vy - (g + k * vy * v) * frequency;
                    x = x + vx * frequency;
                    y = y + vy * frequency;
                    if (x > maxX) { maxX = x; }
                    if (y > maxY) { maxY = y; }
                    points.Add(new Point(x, y));
                } while (y > 0);

                area = Math.Max(area, Math.Max(maxX, maxY));
                // Настройка графика
                chartArea = chart1.ChartAreas[0];
                // Установка минимального значения по оси X
                chartArea.AxisX.Minimum = 0;
                // Установка максимального значения по оси X
                chartArea.AxisX.Maximum = area;
                // Установка минимального значения по оси Y
                chartArea.AxisY.Minimum = 0;
                // Установка максимального значения по оси Y
                chartArea.AxisY.Maximum = area;
                // Установка размера шага по оси X
                chartArea.AxisX.Interval = area / 20;
                // Установка размера шага по оси Y
                chartArea.AxisY.Interval = area / 20;

                // Инициализация таймера
                timer.Interval = 25;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обработчик события таймера

            // Проверка на выход за пределы списка
            if (currentIndex < points.Count)
            {
                // Получение текущей точки
                Point currentPoint = points[currentIndex];

                // Ваш код обработки текущей точки, например, вывод в консоль
                chart1.Series[i].Points.AddXY(currentPoint.X, currentPoint.Y);

                // Увеличение индекса для следующей итерации
                currentIndex++;
            }
            else
            {
                // Если все точки обработаны, остановите таймер
                timer.Stop();
                i++;
                i %= 3;
                currentTime = 0;
                points.Clear();
                currentIndex = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();

            seriesList.Add(chart1.Series[0]);
            seriesList.Add(chart1.Series[1]);
            seriesList.Add(chart1.Series[2]);
            timer.Tick += Timer_Tick;
        }
        
    }
}
