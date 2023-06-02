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

namespace Wpf_Button_Homework {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void button6_Click(object sender, RoutedEventArgs e) {
            changeColor((Button)sender, e);
        }

        private void button5_Click(object sender, RoutedEventArgs e) {
            changeColor((Button)sender, e);
        }

        private void button4_Click(object sender, RoutedEventArgs e) {
            changeColor((Button)sender, e);
        }

        private void button3_Click(object sender, RoutedEventArgs e) {
            changeColor((Button)sender, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            changeColor((Button)sender, e);
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            changeColor((Button)sender, e);
        }

        private void changeColor(Button button, RoutedEventArgs e) {
            var red = Random.Shared.Next(0, 255);
            var green = Random.Shared.Next(0, 255);
            var blue = Random.Shared.Next(0, 255);
            button.Background = new SolidColorBrush() {
                Color = Color.FromRgb((byte)red, (byte)green, (byte)blue)
            };
            MessageBox.Show($"Button Content : {button.Content}, Button name : {button.Name}, Button Color : {button.Background}, Button size : {button.Height}:{button.Width}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MyButton_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e) {
            Button button = (Button)sender;
            Title = button.Content.ToString();
            ButtonContainer.Children.Remove((button));
        }
    }
}
