using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex
{
    public partial class Form1 : Form
    {
        System.Text.RegularExpressions.Regex phoneRegex =
    new System.Text.RegularExpressions.Regex(@"^(0|(00|\+)353)\d{8,9}$");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_Validate(object sender, EventArgs e)
        {
            if (phoneRegex.Matches(txtPhone.Text).Count < 1)
            {
                lblWarning.Text = "Invalid Phone number!";
                lblWarning.Visible = true;
            }
            else lblWarning.Visible = false;
        }
    }
}
