using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
            };
           
            listPerson.Add(newPerson);

        }

        private void btPictureOpen_Click(object sender, EventArgs e) {

            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
            
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
    }
}
