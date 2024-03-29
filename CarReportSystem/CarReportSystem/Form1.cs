﻿using System;
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
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("名前が入力されていません");
                return;
            }
            CarReport newCarReport = new CarReport {
                Date = dtpDateTime.Value,
                Auther = cbAuther.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
                Maker = GetRadioButtonMakerGroup(),
            };
            listCarReport.Add(newCarReport);
            dgvCarReport.Rows[dgvCarReport.RowCount - 1].Selected = true;
            EnabledCheck();

            setCbCarName(cbCarName.Text);
            setCbAuther(cbAuther.Text);
        }

        private CarReport.MakerGroup GetRadioButtonMakerGroup() {

            CarReport.MakerGroup selectedmakerGroup = CarReport.MakerGroup.その他;
            if (rbToyota.Checked) { //トヨタにチェックがついている
                selectedmakerGroup = CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) { //日産にチェックがついている
                selectedmakerGroup = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) { //ホンダにチェックがついている
                selectedmakerGroup = CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) { //スバルにチェックがついている
                selectedmakerGroup = CarReport.MakerGroup.スバル;
            }
            if (rbForeign.Checked) { //外国車にチェックがついている
                selectedmakerGroup = CarReport.MakerGroup.外国車;
            }
            return selectedmakerGroup;
        }

        private void setCbCarName(String carName) {

            if (cbCarName.Items.Contains(carName)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(cbCarName.Text);
            }
        }

        private void setCbAuther(String recorder) {

            if (cbAuther.Items.Contains(recorder)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(cbAuther.Text);
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

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvCarReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            int index = dgvCarReport.CurrentRow.Index;

            dtpDateTime.Value = listCarReport[index].Date;
            cbAuther.Text = listCarReport[index].Auther;
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;

            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbForeign.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
            }
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            listCarReport[dgvCarReport.CurrentRow.Index].Date = dtpDateTime.Value;
            listCarReport[dgvCarReport.CurrentRow.Index].Auther = cbAuther.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReport.Refresh();//データグリッドビュー更新
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvCarReport.CurrentRow.Index);
            EnabledCheck(); //マスク処理呼び出し
        }

        //更新・削除ボタンのマスク処理行う（マスク判定含む）
        private void EnabledCheck() {
            btUpdate.Enabled = btDelete.Enabled = listCarReport.Count() > 0 ? true : false;
        }

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

            EnabledCheck(); //マスク処理呼び出し
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
            
            //背景色
            //dgvPersons.RowsDefaultCellStyle.BackColor = Color.Bisque;
            //奇数行
            //dgvCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdCarReportSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarReportSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdCarReportOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む」
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                foreach (var item in listCarReport.Select(p => p.CarName)) {
                    setCbCarName(item);//存在する車名を登録
                }
                foreach (var item in listCarReport.Select(p => p.Auther)) {
                    setCbAuther(item);//存在する記録者を登録
                }
            }
            EnabledCheck(); //マスク処理呼び出し
        }
        
    }
}
