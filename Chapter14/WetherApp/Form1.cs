using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WetherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            cbAreaSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
           
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = " ";
            var weather = " ";
            switch (cbAreaSelect.SelectedItem) {
                case "宗谷地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                    break;
                case "上川・留萌地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                    break;
                case "網走・北見・紋別地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    break;
                case "釧路・根室地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                    break;
                case "胆振・日高地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                    break;
                case "石狩・空知・後志地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                    break;
                case "渡島・檜山地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                    break;
                case "青森県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                    break;
                case "岩手県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                    break;
                case "宮城県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                    break;
                case "秋田県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                    break;
                case "山形県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                    break;
                case "福島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                    break;
                case "茨城県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                    break;
                case "栃木県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                    break;
                case "群馬県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                    break;
                case "埼玉県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                    break;
                case "千葉県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                    break;
                case "東京都":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                    break;
                case "神奈川県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                    break;
                case "山梨県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                    break;
                case "長野県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                    break;
                case "岐阜県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                    break;
                case "静岡県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                    break;
                case "愛知県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                    break;
                case "三重県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                    break;
                case "新潟県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                    break;
                case "富山県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                    break;
                case "石川県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                    break;
                case "福井県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                    break;
                case "滋賀県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                    break;
                case "京都府":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                    break;
                case "大阪府":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                    break;
                case "兵庫県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                    break;
                case "奈良県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                    break;
                case "和歌山県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                    break;
                case "鳥取県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                    break;
                case "島根県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                    break;
                case "岡山県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                    break;
                case "広島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                    break;
                case "徳島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
                    break;
                case "香川県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                    break;
                case "愛媛県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                    break;
                case "高知県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                    break;
                case "山口県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                    break;
                case "福岡県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                    break;
                case "佐賀県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                    break;
                case "長崎県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                    break;
                case "熊本県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                    break;
                case "大分県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                    break;
                case "宮崎県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                    break;
                case "鹿児島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
                    break;
                case "沖縄本島地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                    break;
                case "大東島地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                    break;
                case "宮古島地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                    break;
                case "八重山地方":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                    weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                    break;
                
            }

            // var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
            //var weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");


            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(weather);

            tbWeatherInfo.Text = json.text;
            lbWeather.Text = json2[0].timeSeries[0].areas[0].weathers[0];
            pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
            pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            pbDayAfterTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            pbThreeDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[2] + ".png";
            pbFourDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[3] + ".png";
            pbFiveDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[4] + ".png";
            pbSixDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[5] + ".png";
            
            
            lbTemps.Text = (json2[0].timeSeries[2].areas[0].temps[0] + "°");
            lbTemps2.Text = (json2[0].timeSeries[2].areas[0].temps[3] + "°");

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            DateTime today = DateTime.Today;
            label7.Text = (today.Month.ToString() + "/" + today.Day.ToString());
            DateTime tomorrow = DateTime.Today.AddDays(1);
            label8.Text = (tomorrow.Month.ToString() + "/" + tomorrow.Day.ToString());
            DateTime twodays = DateTime.Today.AddDays(2);
            label9.Text = (twodays.Month.ToString() + "/" + twodays.Day.ToString());
            DateTime treedays = DateTime.Today.AddDays(3);
            label10.Text = (treedays.Month.ToString() + "/" + treedays.Day.ToString());
            DateTime fourdays = DateTime.Today.AddDays(4);
            label11.Text = (fourdays.Month.ToString() + "/" + fourdays.Day.ToString());
            DateTime fivedays = DateTime.Today.AddDays(5);
            label12.Text = (fivedays.Month.ToString() + "/" + fivedays.Day.ToString());
            DateTime sixdays = DateTime.Today.AddDays(6);
            label6.Text = (sixdays.Month.ToString() + "/" + sixdays.Day.ToString());

            cbAreaSelect.SelectedIndex = 15;

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var dString = " ";
            var weather = " ";
            dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
            weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(weather);
            tbWeatherInfo.Text = json.text;
            lbWeather.Text = json2[0].timeSeries[0].areas[0].weathers[0];
            pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
            pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            pbDayAfterTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            pbThreeDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[2] + ".png";
            pbFourDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[3] + ".png";
            pbFiveDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[4] + ".png";
            pbSixDaysLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[1].timeSeries[0].areas[0].weatherCodes[5] + ".png";
            lbTemps.Text = (json2[0].timeSeries[2].areas[0].temps[0] + "°");
            lbTemps2.Text = (json2[0].timeSeries[2].areas[0].temps[3] + "°");


        }
            
    }
}
