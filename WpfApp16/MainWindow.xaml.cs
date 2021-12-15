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
using System.Windows.Media.Animation;

namespace WpfApp16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            //doubleAnimation.From = 150;
            doubleAnimation.To = 300;
            //doubleAnimation.By = 20;
            doubleAnimation.RepeatBehavior = new RepeatBehavior(2);
            doubleAnimation.Duration = TimeSpan.FromSeconds(1);
            //doubleAnimation.SpeedRatio = 0.25;
            //doubleAnimation.AccelerationRatio = 0.5;
            //DoubleAnimation doubleAnimation1 = new DoubleAnimation();
            //doubleAnimation1.From = 50;
            //doubleAnimation1.To = 100;
            //doubleAnimation1.Duration = TimeSpan.FromSeconds(1);
            doubleAnimation.AutoReverse = true;
            btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
            btn.BeginAnimation(Button.HeightProperty, doubleAnimation);

            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.White;
            colorAnimation.To = Colors.Red;
            colorAnimation.Duration = TimeSpan.FromSeconds(1);
            colorAnimation.RepeatBehavior = new RepeatBehavior(2);
            colorAnimation.AutoReverse = true;
            btn.Background = new SolidColorBrush(Colors.White);
            btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
    }
}
