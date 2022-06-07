using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //ボタンクリックイベントハンドラ
        private void btPush_Click(object sender, EventArgs e) 
        {
            //tbAns.Text = (int.Parse(tbSuu1.Text) + int.Parse(tbSuu2.Text)).ToString();
            nudAns.Value = nudSuu1.Value + nudSuu2.Value;
        }
    }
}
