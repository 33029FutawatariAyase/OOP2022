using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private Random rand = new Random();

        private int randomNumber;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            getRandom();     
        }

        private void Judge_Click(object sender, EventArgs e) {
            if (Number.Value == randomNumber) {
                textBox1.Text = "正解";
            }else if(Number.Value > randomNumber){
                textBox1.Text = "乱数より大きい";
            }else if (Number.Value < randomNumber) {
                textBox1.Text = "乱数より小さい";
            }
        }

        private void maxNum_ValueChanged(object sender, EventArgs e) {
            getRandom();
        }

        private void getRandom() {
            randomNumber = rand.Next(1, (int)maxNum.Value);
            this.Text = randomNumber.ToString();
        }
    }
}
