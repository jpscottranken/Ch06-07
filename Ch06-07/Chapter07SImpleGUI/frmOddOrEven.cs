using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07SImpleGUI
{
    public partial class frmOddOrEven : Form
    {
        public frmOddOrEven()
        {
            InitializeComponent();
        }

        int number;
        string numberStr;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            inputTheNumber();
        }

        private void inputTheNumber()
        {
            bool result;
            int remainder;

            //  Handle case of nothing in textbox
            if (txtEnterNumber.Text.Trim() == "")
            {
                //  There was nothing put into the textbox.
                //  Show a message and stop the program run
                MessageBox.Show("No Input Provided",
                                "NO INPUT!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            //  Handle case of non-numeric value in textbox
            else
            {
                //  There was something in the textbox.
                //  Now verify that what was input was numeric
                numberStr = txtEnterNumber.Text;
                result = Int32.TryParse(numberStr, out number);

                if (!result)
                {
                    //  There was nothing put into the textbox.
                    //  Show a message and stop the program run
                    MessageBox.Show("Non-Numeric Input Provided",
                                    "NON-NUMERIC INPUT!!!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;

                }
            }

            //  Integer Input WAS provided
            if (number == 0)
            {
                //  If number in textbox was a 0, print
                //  not odd not even message and return
                txtStatus.Text = "The number " + number.ToString() + 
                                 " is neither or nor even";
                return;
            }

            //  An int other that 0 was input
            remainder = number % 2;
            if (remainder == 0)
            {   //  Remainder of 0 means number was even
                txtStatus.Text = "The number " + number.ToString() + " is even";
            }
            else
            {   //  Remainder of 1 means number was odd
                txtStatus.Text = "The number " + number.ToString() + " is odd";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFieldsAndSetFocus();
        }

        private void clearFieldsAndSetFocus()
        {
            txtEnterNumber.Text = "";
            txtStatus.Text      = "";
            txtEnterNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
