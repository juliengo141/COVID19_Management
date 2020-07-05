using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyy/MM/dd hh:mm:ss";

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            //this.Close();
            DateTime iDate;
            iDate = dateTimePicker1.Value;

        }
    }
}
