using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        MyColor mycolor = new MyColor();

        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void setColor() {
            var r = byte.Parse(TextBox1.Text);
            var g = byte.Parse(TextBox2.Text);
            var b = byte.Parse(TextBox3.Text);
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //var color = mycolor.Color;
            //var name = mycolor.Name;
            
            //TextBox1.Text = mycolor.Color.R.ToString();
            //TextBox2.Text = mycolor.Color.G.ToString();
            //TextBox3.Text = mycolor.Color.B.ToString();

            Slider1.Value = mycolor.Color.R;
            Slider2.Value = mycolor.Color.G;
            Slider3.Value = mycolor.Color.B;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            stockList.Items.Add("R:" + TextBox1.Text + " G:" + TextBox2.Text + " B:" + TextBox3.Text);
        }

        private void DELETE_Click(object sender, RoutedEventArgs e) {
            stockList.Items.Clear();
            
        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
