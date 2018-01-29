using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BalloonKlasse
{
    class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
       
        private Ellipse ellipse;
    
        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }

        public void MoveLeft(int xStep)
        {
            x = x - xStep;
            UpdateEllipse();
        }

        public void MoveUp(int yStep)
        {
            y = y - yStep;
            UpdateEllipse();
        }

        public void MoveDown(int yStep)
        {
            y = y + yStep;
            UpdateEllipse();
        }

        public void GrowSize(int change)
        {
            diameter = diameter + change;
            UpdateEllipse();
        }

        public void ShrinkSize(int change)
        {
            diameter = diameter - change;
            UpdateEllipse();
        }

        public void ChangeColor(Color newColor)
        {
            Random rndgen = new Random();
            ellipse.Stroke = new SolidColorBrush(Color.FromRgb((byte) rndgen.Next(0,255),(byte) rndgen.Next(0,255), (byte) rndgen.Next(0,255)));
            ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rndgen.Next(0, 255), (byte)rndgen.Next(0, 255), (byte) rndgen.Next(0, 255)));
            
        }

        public void DisplayOn(Canvas MijnCanvas)
        {
            MijnCanvas.Children.Add(ellipse);
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.MediumPurple);
            ellipse.StrokeThickness = 5;

           
        }

        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            
        }
    }
}
