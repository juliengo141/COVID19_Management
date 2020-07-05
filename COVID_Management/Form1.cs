using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace COVID_Management
{
    public partial class Form1 : Form
    {
        //configures firebase 
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "B2ZyJIc6a1qeGcy31DfSrGGSwevdn2tPWPii8HsR",
            BasePath = "https://covid-manager-bf570.firebaseio.com/"
        };

        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            //this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tests if firebase connection is successful
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connection is established");
            }
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yesCovidPosButton_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            //this.Close();
        }

        private void quarantineScheduleButton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            //this.Close();

        }

        private void companyLogoPicture_Click(object sender, EventArgs e)
        {

        }
    }

}