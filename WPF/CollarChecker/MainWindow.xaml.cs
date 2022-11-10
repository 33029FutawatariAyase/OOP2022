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

        //MyColor mycolor = new MyColor();
        List<MyColor> colorList = new List<MyColor>();

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

            //Slider1.Value = mycolor.Color.R;
            //Slider2.Value = mycolor.Color.G;
            //Slider3.Value = mycolor.Color.B;

            Slider1.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            Slider2.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            Slider3.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            setColor();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //stockList.Items.Add("R:" + TextBox1.Text + " G:" + TextBox2.Text + " B:" + TextBox3.Text);
            MyColor stColor = new MyColor();
            var r = byte.Parse(TextBox1.Text);
            var g = byte.Parse(TextBox2.Text);
            var b = byte.Parse(TextBox3.Text);

            stColor.Color = Color.FromRgb(r, g, b);
            //colorList.Add(stColor);

            //テキストボックスのRGB値から色名称があるかチェック
            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                       c.Color.G == stColor.Color.G &&
                                       c.Color.B == stColor.Color.B).FirstOrDefault();

            stockList.Items.Insert(0,colorName?.Name ?? "R:" + r + " G:" + g + " B:" + b);
            colorList.Insert(0,stColor);

        }

        private void DELETE_Click(object sender, RoutedEventArgs e) {
            var delIndex = stockList.SelectedIndex;

            if (delIndex == -1) return;

            stockList.Items.RemoveAt(delIndex);
            colorList.RemoveAt(delIndex);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex == -1) return;
            Slider1.Value = colorList[stockList.SelectedIndex].Color.R;
            Slider2.Value = colorList[stockList.SelectedIndex].Color.G;
            Slider3.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();

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
