using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbAuthor.Text)) {
                MessageBox.Show("名前が入力されていません");
                return;
            }
            DataRow newRow = infosys202203DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDateTime.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = pbPicture.Image;
            //データセットへ新しいレコードを追加
            infosys202203DataSet.CarReportDB.Rows.Add(newRow);
            //データ更新
            this.carReportDBTableAdapter.Update(this.infosys202203DataSet.CarReportDB);
            
        }

        private void setCbCarName(String carName) {

            if (cbCarName.Items.Contains(carName)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(cbCarName.Text);
            }
        }

        private void setCbAuther(String recorder) {

            if (cbAuthor.Items.Contains(recorder)) {
                //まだ登録されていなければ登録処理
                cbAuthor.Items.Add(cbAuthor.Text);
            }
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdCarReportOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへ設定
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDateTime.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;

            //データベースの中をデータベースへ反映(保存)
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202203DataSet);
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {

            carReportDBDataGridView.Rows.RemoveAt(carReportDBDataGridView.CurrentRow.Index);
            //EnabledCheck(); //マスク処理呼び出し
        }

        //更新・削除ボタンのマスク処理行う（マスク判定含む）
        //private void EnabledCheck() {
        //    btUpdate.Enabled = btDelete.Enabled = listCarReport.Count() > 0 ? true : false;
        //}

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化（P305）
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

            //EnabledCheck(); //マスク処理呼び出し
            try {
                //設定ファイルを逆シリアル化(P307)して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);//ARGB形式からColorオブジェクトへ変換
                                                                       
                }
            }
            catch (Exception) {

                
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202203DataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e) {
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202203DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202203DataSet.CarReportDB);
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null)
                return;
            //データグリッドビューの選択レコードを各テキストへ設定
            cbAuthor.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            switch (carReportDBDataGridView.CurrentRow.Cells[3].Value) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbForeign.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();

            //画像表示処理
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))
                pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            else
                pbPicture.Image = null;
        }


        private void btClear_Click(object sender, EventArgs e) {
            cbAuthor.Text = null;
            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbForeign.Checked = false;
            rbOther.Checked = false;
            cbCarName.Text = null;
            tbReport.Text = null;
            pbPicture.Image = null;
        }

        private void btSearchName_Click(object sender, EventArgs e) {
            carReportDBTableAdapter.FillByAuthor(infosys202203DataSet.CarReportDB, tbSearchName.Text);
        }

        private string GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return "トヨタ";
            }
            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            if (rbForeign.Checked) {
                return "外国車";
            }
            return "その他";
        }
    }
}
