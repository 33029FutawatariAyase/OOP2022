
namespace WetherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cbAreaSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTomorrow = new System.Windows.Forms.PictureBox();
            this.pbDayAfterTomorrow = new System.Windows.Forms.PictureBox();
            this.pbThreeDaysLater = new System.Windows.Forms.PictureBox();
            this.pbFourDaysLater = new System.Windows.Forms.PictureBox();
            this.pbFiveDaysLater = new System.Windows.Forms.PictureBox();
            this.pbSixDaysLater = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTemps = new System.Windows.Forms.Label();
            this.lbWeather = new System.Windows.Forms.Label();
            this.lbTemps2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeDaysLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourDaysLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveDaysLater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSixDaysLater)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(35, 459);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbWeatherInfo.Size = new System.Drawing.Size(652, 178);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherGet.Location = new System.Drawing.Point(710, 591);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(159, 46);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cbAreaSelect
            // 
            this.cbAreaSelect.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAreaSelect.FormattingEnabled = true;
            this.cbAreaSelect.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県\t",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
            this.cbAreaSelect.Location = new System.Drawing.Point(134, 43);
            this.cbAreaSelect.Name = "cbAreaSelect";
            this.cbAreaSelect.Size = new System.Drawing.Size(187, 24);
            this.cbAreaSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "天気概況";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "地方選択";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "今日";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Enabled = false;
            this.dtpDateTime.Location = new System.Drawing.Point(15, 12);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 19);
            this.dtpDateTime.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(479, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "明日";
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.Color.Transparent;
            this.pbToday.Location = new System.Drawing.Point(138, 107);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(151, 144);
            this.pbToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbToday.TabIndex = 6;
            this.pbToday.TabStop = false;
            // 
            // pbTomorrow
            // 
            this.pbTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.pbTomorrow.Location = new System.Drawing.Point(525, 147);
            this.pbTomorrow.Name = "pbTomorrow";
            this.pbTomorrow.Size = new System.Drawing.Size(132, 119);
            this.pbTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTomorrow.TabIndex = 6;
            this.pbTomorrow.TabStop = false;
            // 
            // pbDayAfterTomorrow
            // 
            this.pbDayAfterTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.pbDayAfterTomorrow.Location = new System.Drawing.Point(73, 321);
            this.pbDayAfterTomorrow.Name = "pbDayAfterTomorrow";
            this.pbDayAfterTomorrow.Size = new System.Drawing.Size(80, 80);
            this.pbDayAfterTomorrow.TabIndex = 6;
            this.pbDayAfterTomorrow.TabStop = false;
            // 
            // pbThreeDaysLater
            // 
            this.pbThreeDaysLater.BackColor = System.Drawing.Color.Transparent;
            this.pbThreeDaysLater.Location = new System.Drawing.Point(209, 321);
            this.pbThreeDaysLater.Name = "pbThreeDaysLater";
            this.pbThreeDaysLater.Size = new System.Drawing.Size(80, 80);
            this.pbThreeDaysLater.TabIndex = 8;
            this.pbThreeDaysLater.TabStop = false;
            // 
            // pbFourDaysLater
            // 
            this.pbFourDaysLater.BackColor = System.Drawing.Color.Transparent;
            this.pbFourDaysLater.Location = new System.Drawing.Point(345, 321);
            this.pbFourDaysLater.Name = "pbFourDaysLater";
            this.pbFourDaysLater.Size = new System.Drawing.Size(80, 80);
            this.pbFourDaysLater.TabIndex = 8;
            this.pbFourDaysLater.TabStop = false;
            // 
            // pbFiveDaysLater
            // 
            this.pbFiveDaysLater.BackColor = System.Drawing.Color.Transparent;
            this.pbFiveDaysLater.Location = new System.Drawing.Point(496, 321);
            this.pbFiveDaysLater.Name = "pbFiveDaysLater";
            this.pbFiveDaysLater.Size = new System.Drawing.Size(80, 80);
            this.pbFiveDaysLater.TabIndex = 8;
            this.pbFiveDaysLater.TabStop = false;
            // 
            // pbSixDaysLater
            // 
            this.pbSixDaysLater.BackColor = System.Drawing.Color.Transparent;
            this.pbSixDaysLater.Location = new System.Drawing.Point(647, 321);
            this.pbSixDaysLater.Name = "pbSixDaysLater";
            this.pbSixDaysLater.Size = new System.Drawing.Size(80, 80);
            this.pbSixDaysLater.TabIndex = 8;
            this.pbSixDaysLater.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(107, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(522, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(70, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(206, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(342, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(493, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(644, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 10;
            // 
            // lbTemps
            // 
            this.lbTemps.AutoSize = true;
            this.lbTemps.BackColor = System.Drawing.Color.Transparent;
            this.lbTemps.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTemps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTemps.Location = new System.Drawing.Point(316, 166);
            this.lbTemps.Name = "lbTemps";
            this.lbTemps.Size = new System.Drawing.Size(0, 37);
            this.lbTemps.TabIndex = 11;
            // 
            // lbWeather
            // 
            this.lbWeather.AutoSize = true;
            this.lbWeather.BackColor = System.Drawing.Color.Transparent;
            this.lbWeather.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWeather.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWeather.Location = new System.Drawing.Point(180, 254);
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Size = new System.Drawing.Size(0, 16);
            this.lbWeather.TabIndex = 12;
            // 
            // lbTemps2
            // 
            this.lbTemps2.AutoSize = true;
            this.lbTemps2.BackColor = System.Drawing.Color.Transparent;
            this.lbTemps2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTemps2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTemps2.Location = new System.Drawing.Point(678, 192);
            this.lbTemps2.Name = "lbTemps2";
            this.lbTemps2.Size = new System.Drawing.Size(0, 29);
            this.lbTemps2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 671);
            this.Controls.Add(this.lbTemps2);
            this.Controls.Add(this.lbWeather);
            this.Controls.Add(this.lbTemps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbSixDaysLater);
            this.Controls.Add(this.pbFiveDaysLater);
            this.Controls.Add(this.pbFourDaysLater);
            this.Controls.Add(this.pbThreeDaysLater);
            this.Controls.Add(this.pbDayAfterTomorrow);
            this.Controls.Add(this.pbTomorrow);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAreaSelect);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "天気予報";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeDaysLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourDaysLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveDaysLater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSixDaysLater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cbAreaSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTomorrow;
        private System.Windows.Forms.PictureBox pbDayAfterTomorrow;
        private System.Windows.Forms.PictureBox pbThreeDaysLater;
        private System.Windows.Forms.PictureBox pbFourDaysLater;
        private System.Windows.Forms.PictureBox pbFiveDaysLater;
        private System.Windows.Forms.PictureBox pbSixDaysLater;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTemps;
        private System.Windows.Forms.Label lbWeather;
        private System.Windows.Forms.Label lbTemps2;
    }
}

