using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch07MPGGUI
{
    public partial class frmMilesPerGallon : Form
    {
        public frmMilesPerGallon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  Program constants
            const decimal MINMILES =    0;
            const decimal MAXMILES = 1000;
            const decimal MINGALLS =    0;
            const decimal MAXGALLS =   50;

            //  Local variables
            decimal milesDriven = 0m;           //  Value in the first  textbox
            decimal gallonsUsed = 0m;           //  Value in the second textbox
            decimal mpg         = 0m;           //  Value in the third  textbox

            try
            {
                //  Attempting to convert whatever was in textbox1
                //  and textbox2 to their decimal equivalents.
                milesDriven = Convert.ToDecimal(txtMilesDriven.Text);
                gallonsUsed = Convert.ToDecimal(txtGallonsUsed.Text);

                //  Do a valid range check for miles driven
                if ((milesDriven < MINMILES) || (milesDriven > MAXMILES))
                {
                    throw new ArgumentOutOfRangeException();
                }

                //  Do a valid range check for gallons
                if ((gallonsUsed < MINGALLS) || (gallonsUsed > MAXGALLS))
                {
                    throw new ArgumentOutOfRangeException();
                }

                //  Do the MPG calculation
                mpg = milesDriven / gallonsUsed;

                //  Put calculated value in the last textbox
                txtMPG.Text = mpg.ToString("n2");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.GetType().ToString(),
                                "EXCEPTION TYPE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMPG.Text = aoore.Message;
                return;
            }

            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.GetType().ToString(),
                                "EXCEPTION TYPE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMPG.Text = ae.Message;
                return;
            }

            catch (FormatException fe)
            {
                MessageBox.Show(fe.GetType().ToString(),
                                "EXCEPTION TYPE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMPG.Text = fe.Message;
                return;
            }

            catch (DivideByZeroException dbze)
            {
                MessageBox.Show(dbze.GetType().ToString(),
                                "EXCEPTION TYPE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMPG.Text = dbze.Message;
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFieldsAndSetFocus();
        }

        private void clearFieldsAndSetFocus()
        {
            txtMilesDriven.Text = "";
            txtGallonsUsed.Text = "";
            txtMPG.Text = "";
            txtMilesDriven.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitTheProgramOrNot();
        }

        private void exitTheProgramOrNot()
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
