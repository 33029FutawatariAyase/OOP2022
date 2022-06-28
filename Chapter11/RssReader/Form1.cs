using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<string> xTitle;
        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                var xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                var xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));

                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);
                }
            }

        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            int index = lbRssTitle.SelectedIndex; //選択した箇所のインデックスを取得(0～ )
        }
    }
}
