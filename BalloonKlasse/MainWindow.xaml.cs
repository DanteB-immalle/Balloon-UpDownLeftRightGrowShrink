using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BalloonKlasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
       
    {
        private Balloon balloon;

        public MainWindow()
        {
            InitializeComponent();

            balloon = new Balloon();       
        }

       

       
        private void MoveRight_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveRight(20);
        }

        private void MoveLeft_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveLeft(20);
        }

        private void MoveUp_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveUp(20);
        }

        private void MoveDown_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveDown(20);
        }

        private void Shrink_Click(object sender, RoutedEventArgs e)
        {
            balloon.ShrinkSize(20);
        }

        private void Grow_Click(object sender, RoutedEventArgs e)
        {
            balloon.GrowSize(20);
        }

        private void Changecolor_Click(object sender, RoutedEventArgs e)
        {
            balloon.ChangeColor(Colors.Blue);
        }
    }
}
