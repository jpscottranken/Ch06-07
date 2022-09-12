using System;
using System.Windows.Forms;

/*
 *      This is a graphical user interfac (GUI)
 *      calculator program demonstrating
 *      modularization. Also, there are NO
 *      global variables.
 */

namespace Ch6CalculatorGUI01
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        //  This code executes when the Calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        //  This method converts the values in textboxes 1 and 2
        //  to their decimal equivalents and then calls the
        //  determineResult() method to actaully determine the result.
        private void calculate()
        {
            determineResult();
        }

        //  This code executes when the Clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFieldsAndSetFocus();
        }

        //  This method clears the three textboxes, sets
        //  the value in the dropdown to Enter Operation,
        //  and sets the focus to the first textbox.
        private void clearAllFieldsAndSetFocus() 
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtResult.Text = "";
            cboOperation.SelectedIndex = 0;
            txtNumber1.Focus();
        }

        //  This code executes when the Exit button is clicked.
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        //  This method lets the user end the program if desired.
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

        //  This code executes when the form is loaded into
        //  memory. It sets the text in the dropdown to
        //  Enter Operation.
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            cboOperation.SelectedIndex = 0;
        }

        //  This method determines the result. If no value was
        //  entered into the dropdown list, an error MessageBox
        //  is printed and the method returns.
        //
        //  Otherwise, the appropriate method is called, based
        //  on the value selected in the dropdown list (combobox).
        private void determineResult()
        {
            //  Declaring and initializing local program variables
            decimal number1 = Convert.ToDecimal(txtNumber1.Text);
            decimal number2 = Convert.ToDecimal(txtNumber2.Text);
            decimal result = 0;

            if (cboOperation.SelectedIndex <= 0)
            {
                //  No dropdown list (combox) value selected
                MessageBox.Show("You Must Select An Operation To Perform",
                                "NO OPERATION SELECTED!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            //  Combobox selection was made.
            //  If "+" call the add function.
            //  If "-" call the subtract function.
            //  If "*" call the multiply function.
            //  If "/" call the divide   function.
            //  If "%" call the modulus  function.
            //  Default (should never happen), show
            //  an error MessageBox.
            switch (cboOperation.SelectedItem.ToString())
            {
                case "Enter Operation":
                    MessageBox.Show(
                        "You Must Choose An Operation From The List Below",
                        "INVALID OPERATOR CHOSEN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;

                case "+":
                    result = add2(number1, number2);
                    break;

                case "-":
                    result = sub2(number1, number2);
                    break;

                case "*":
                    result = prod2(number1, number2);
                    break;

                case "/":
                    result = div2(number1, number2);
                    break;

                case "%":
                    result = mod2(number1, number2);
                    break;

                default:
                    MessageBox.Show(
                        "You Must Choose An Operation From The List Below",
                        "INVALID OPERATOR CHOSEN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
            }

            //  Print out the results of the math operation.
            txtResult.Text = "The result is: " + result.ToString("n2");
        }
        private decimal add2(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        private decimal sub2(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        private decimal prod2(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
        private decimal div2(decimal n1, decimal n2)
        {
            return n1 / n2;
        }

        private decimal mod2(decimal n1, decimal n2)
        {
            return n1 % n2;
        }
    }
}
