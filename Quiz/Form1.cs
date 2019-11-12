using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string tel = txtTelephone.Text;


            if (fname != "" && lname != "" && tel != "")
            {
                MessageBox.Show("First Name:" + fname + "\nLast Name:" + lname + "\nTelephone: " + tel, "Login Caption", MessageBoxButtons.OKCancel);
                FileStream stream = new FileStream("C:/Users/1034123/Desktop/Net Programming/users.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(fname);
                    writer.Write(lname);
                    writer.Write(tel+ "\n");
                }


            }
            else
            {
                MessageBox.Show("You must fill out the form");
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string tel = txtTelephone.Text;

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtTelephone.Text = string.Empty;
        }

        private void btnCountUsers_Click(object sender, EventArgs e)
      
        {
                using (StreamReader r = new StreamReader("C:/Users/1034123/Desktop/Net Programming/users.txt"))
                {
                    int i = 0;
                    while (r.ReadLine() != null) { i++; }
                    MessageBox.Show("The number of users are " + i);
                }

            
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            string tempfile = Path.GetTempFileName();
            FileStream stream = new FileStream("C:/Users/1034123/Desktop/Net Programming/users.txt", FileMode.Create);
            using (StreamReader reader = new StreamReader(stream))
            {
                File.Delete(tempfile);
                MessageBox.Show("File has been deleted");
            }

            
        }
    }
}
