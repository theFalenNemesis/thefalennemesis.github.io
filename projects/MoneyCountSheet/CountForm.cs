using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace MoneyCountSheet
{
    public partial class CountForm : Form
    {
        //global variables
        decimal pennies;
        decimal nickels;
        decimal dimes;
        decimal quarters;
        decimal rolls;
        decimal ones;
        decimal fives;
        decimal tens;
        decimal twenties;
        decimal fifties;
        decimal other;
        decimal batch;
        decimal checks;
        decimal total;
        decimal revenue;
        decimal depositTotal;
        decimal cashTotal;
        decimal drawer;
        decimal shiftRevenue;

        Bitmap memoryImage;
        SaveFileDialog save = new SaveFileDialog();
        DateTime thisDay = DateTime.Now;

        PrintDocument print = new PrintDocument();

        public CountForm()
        {
            InitializeComponent();
            //print page handler
            print.PrintPage += new PrintPageEventHandler(print_PrintPage);

            //sets the date label on the form to the days date
            dateLabel.Text = thisDay.ToString("d");
        }

        //===================calculate button===============================
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //check for bowling/grill radio button selection
            if (!bowlingRadioButton.Checked && !grillRadioButton.Checked)
            {
                //display error message if no selection is made, don't allow calculation
                MessageBox.Show("Please Select Bowling or Grill Radio Button In Top Right Corner.");
            }
            //check shiftRevenueTextBox for value
            else if(string.IsNullOrEmpty(shiftRevenueTextBox.Text))
            {
                //display error message if empty, don't allow calculation
                MessageBox.Show("Please Enter The Shift Report Amount.");
            }
            //radio buttons and shift revenue specs met
            else
            {
                //access getInput method to get values from all text boxes
                getInput();
                //access calculateTotals method to calculate the different totals
                calculateTotals();
            }
        }
        //============================get input==================================
        private void getInput()
        {
            try
            {
                //error checking for empty text boxes or non-numerics ELSE getting value from text boxes
                if (string.IsNullOrEmpty(penniesTextBox.Text) || !decimal.TryParse(penniesTextBox.Text, out pennies))
                {
                    pennies = 0;
                    penniesTextBox.Text = pennies.ToString();
                }
                else
                {
                    pennies = Convert.ToDecimal(penniesTextBox.Text);
                }

                if (string.IsNullOrEmpty(nickelsTextBox.Text) || !decimal.TryParse(nickelsTextBox.Text, out nickels))
                {
                    nickels = 0;
                    nickelsTextBox.Text = nickels.ToString();
                }
                else
                {
                    nickels = Convert.ToDecimal(nickelsTextBox.Text);
                }

                if (string.IsNullOrEmpty(dimesTextBox.Text) || !decimal.TryParse(dimesTextBox.Text, out dimes))
                {
                    dimes = 0;
                    dimesTextBox.Text = dimes.ToString();
                }
                else
                {
                    dimes = Convert.ToDecimal(dimesTextBox.Text);
                }

                if (string.IsNullOrEmpty(quartersTextBox.Text) || !decimal.TryParse(quartersTextBox.Text, out quarters))
                {
                    quarters = 0;
                    quartersTextBox.Text = quarters.ToString();
                }
                else
                {
                    quarters = Convert.ToDecimal(quartersTextBox.Text);
                }

                if (string.IsNullOrEmpty(rollsTextBox.Text) || !decimal.TryParse(rollsTextBox.Text, out rolls))
                {
                    rolls = 0;
                    rollsTextBox.Text = rolls.ToString();
                }
                else
                {
                    rolls = Convert.ToDecimal(rollsTextBox.Text);
                }

                if (string.IsNullOrEmpty(oneTextBox.Text) || !decimal.TryParse(oneTextBox.Text, out ones))
                {
                    ones = 0;
                    oneTextBox.Text = ones.ToString();
                }
                else
                {
                    ones = Convert.ToDecimal(oneTextBox.Text);
                }

                if (string.IsNullOrEmpty(fiveTextBox.Text) || !decimal.TryParse(fiveTextBox.Text, out fives))
                {
                    fives = 0;
                    fiveTextBox.Text = fives.ToString();
                }
                else
                {
                    fives = Convert.ToDecimal(fiveTextBox.Text);
                }

                if (string.IsNullOrEmpty(tenTextBox.Text) || !decimal.TryParse(tenTextBox.Text, out tens))
                {
                    tens = 0;
                    tenTextBox.Text = tens.ToString();
                }
                else
                {
                    tens = Convert.ToDecimal(tenTextBox.Text);
                }

                if (string.IsNullOrEmpty(twentyTextBox.Text) || !decimal.TryParse(twentyTextBox.Text, out twenties))
                {
                    twenties = 0;
                    twentyTextBox.Text = twenties.ToString();
                }
                else
                {
                    twenties = Convert.ToDecimal(twentyTextBox.Text);
                }

                if (string.IsNullOrEmpty(fiftyTextBox.Text) || !decimal.TryParse(fiftyTextBox.Text, out fifties))
                {
                    fifties = 0;
                    fiftyTextBox.Text = fifties.ToString();
                }
                else
                {
                    fifties = Convert.ToDecimal(fiftyTextBox.Text);
                }

                if (string.IsNullOrEmpty(otherTextBox.Text) || !decimal.TryParse(otherTextBox.Text, out other))
                {
                    other = 0;
                    otherTextBox.Text = other.ToString();
                }
                else
                {
                    other = Convert.ToDecimal(otherTextBox.Text);
                }

                if (string.IsNullOrEmpty(batchTextBox.Text) || !decimal.TryParse(batchTextBox.Text, out batch))
                {
                    batch = 0;
                    batchTextBox.Text = batch.ToString();
                }
                else
                {
                    batch = Convert.ToDecimal(batchTextBox.Text);
                }

                if (string.IsNullOrEmpty(checksTextBox.Text) || !decimal.TryParse(checksTextBox.Text, out checks))
                {
                    checks = 0;
                    checksTextBox.Text = checks.ToString();
                }
                else
                {
                    checks = Convert.ToDecimal(checksTextBox.Text);
                }

                if(string.IsNullOrEmpty(shiftRevenueTextBox.Text) || !decimal.TryParse(shiftRevenueTextBox.Text, out shiftRevenue))
                {
                    shiftRevenue = 0;
                    shiftRevenueTextBox.Text = shiftRevenue.ToString();
                }
                else
                {
                    shiftRevenue = Convert.ToDecimal(shiftRevenueTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Please fill out every text box. If there is no amount to enter, just enter 0");
            }
        }
        //===================================calculate totals===============================
        private void calculateTotals()
        {
            //calculate total amount based off of money in drawer and set label
            total = pennies + nickels + dimes + quarters + rolls + ones + fives + tens + twenties 
                + fifties + other + batch + checks;
            totalAmountLabel.Text = total.ToString("C");

            //calculate revenue and set label
            revenue = total - drawer;
            revenueTotalLabel.Text = revenue.ToString("C");

            //set batch label to batch amount
            batchTotalLabel.Text = batch.ToString("C");

            //calculate deposit and set label
            depositTotal = revenue - batch;
            depositTotalLabel.Text = depositTotal.ToString("C");

            //set checks label to checks amount
            checksTotalLabel.Text = checks.ToString("C");

            //calculate cash total and set label
            cashTotal = depositTotal - checks;
            cashTotalLabel.Text = cashTotal.ToString("C");

            //check for over/under
            if (shiftRevenue != revenue)
            {
                //display message if drawer is over/under
                MessageBox.Show("The amount in the drawer does not match the Shift Report. Please recount the drawer for any errors.");

                //find amount off
                decimal difference = revenue - shiftRevenue;

                //over
                if (difference > 0)
                {
                    overUnderLabel.Text = "Over: " + difference.ToString("C");
                    overUnderLabel.ForeColor = Color.Green;
                }
                //under
                else if (difference < 0)
                {
                    overUnderLabel.Text = "Under: " + difference.ToString("C");
                    overUnderLabel.ForeColor = Color.Red;
                }
            }
            //if equal
            else
            {
                overUnderLabel.Text = "Over/Under";
                overUnderLabel.ForeColor = Color.Black;
            }
        }
        //====================bowling radio button============================
        private void bowlingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //set drawer amount to 150 if bowling is checked
            if (bowlingRadioButton.Checked)
            {
                drawer = 150.00M;
            }
        }
        //======================grill radio button===============================
        private void grillRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //set drawer amount to 100 if grill is checked
            if (grillRadioButton.Checked)
            {
                drawer = 100.00M;
            }
        }
        //====================clear button=====================================
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all text boxes, labels, and radio buttons
            penniesTextBox.Clear();
            nickelsTextBox.Clear();
            dimesTextBox.Clear();
            quartersTextBox.Clear();
            rollsTextBox.Clear();
            oneTextBox.Clear();
            fiveTextBox.Clear();
            tenTextBox.Clear();
            twentyTextBox.Clear();
            fiftyTextBox.Clear();
            otherTextBox.Clear();
            batchTextBox.Clear();
            checksTextBox.Clear();
            shiftRevenueTextBox.Clear();
            totalAmountLabel.Text = "0.00";
            revenueTotalLabel.Text = "0.00";
            batchTotalLabel.Text = "0.00";
            depositTotalLabel.Text = "0.00";
            checksTotalLabel.Text = "0.00";
            cashTotalLabel.Text = "0.00";
            overUnderLabel.Text = "Over/Under";
            overUnderLabel.ForeColor = Color.Black;
            bowlingRadioButton.Checked = false;
            grillRadioButton.Checked = false;
        }
        //=====================exit button===========================
        private void exitButton_Click(object sender, EventArgs e)
        {
            //prompt for quit to prevent loss of progress
            if (MessageBox.Show("Are you sure you want to exit? You will lose all progress.", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //============================print and save button===========================
        private void printButton_Click(object sender, EventArgs e)
        {
            if(bowlingRadioButton.Checked && !string.IsNullOrEmpty(shiftRevenueTextBox.Text) 
                || grillRadioButton.Checked && !string.IsNullOrEmpty(shiftRevenueTextBox.Text))
            {
                //access captureScreen method, to get screencap of form
                CaptureScreen();
                //instantiate PrintDialog
                PrintDialog dialog = new PrintDialog();
                //set dialog to print function
                dialog.Document = print;
                print.DefaultPageSettings.Color = false;
                //set initial directory for save and restore directory each time
                if(bowlingRadioButton.Checked)
                {
                    save.InitialDirectory = "C:\\Users\\bvahle\\Desktop\\Count Sheets\\Bowling";
                }
                else if(grillRadioButton.Checked)
                {
                    save.InitialDirectory = "C:\\Users\\bvahle\\Desktop\\Count Sheets\\Grill";
                }
                
                save.RestoreDirectory = true;

                //dynamic naming depending on drawer type
                if (bowlingRadioButton.Checked)
                {
                    save.FileName = "BowlingCount_" + thisDay.ToString("MM-dd-yyyy");
                }
                else if (grillRadioButton.Checked)
                {
                    save.FileName = "GrillCount_" + thisDay.ToString("MM-dd-yyyy");
                }
                //set filter and format
                save.Filter = "Images|*.jpg";
                ImageFormat format = ImageFormat.Jpeg;

                //save on OK
                if (save.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();
                    memoryImage.Save(fs, format);
                    fs.Close();

                    //print on OK
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        print.Print();
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Cannot Print or Save. Please fill out the form.");
            }
            

        }
        //==========================capture screen===================================
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            
        }
        //=========================print page====================================
        private void print_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        //=======================Process Cmd Key===================================
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                if(penniesTextBox.Focused)
                {

                }
                else if(nickelsTextBox.Focused)
                {
                    penniesTextBox.Focus();
                }
                else if(dimesTextBox.Focused)
                {
                    nickelsTextBox.Focus();
                }
                else if(quartersTextBox.Focused)
                {
                    dimesTextBox.Focus();
                }
                else if(rollsTextBox.Focused)
                {
                    quartersTextBox.Focus();
                }
                else if (oneTextBox.Focused)
                {
                    rollsTextBox.Focus();
                }
                else if (fiveTextBox.Focused)
                {
                    oneTextBox.Focus();
                }
                else if (tenTextBox.Focused)
                {
                    fiveTextBox.Focus();
                }
                else if (twentyTextBox.Focused)
                {
                    tenTextBox.Focus();
                }
                else if (fiftyTextBox.Focused)
                {
                    twentyTextBox.Focus();
                }
                else if (otherTextBox.Focused)
                {
                    fiftyTextBox.Focus();
                }
                else if (batchTextBox.Focused)
                {
                    otherTextBox.Focus();
                }
                else if (checksTextBox.Focused)
                {
                    batchTextBox.Focus();
                }
            }
            //capture down arrow key
            else if (keyData == Keys.Down)
            {
                if (penniesTextBox.Focused)
                {
                    nickelsTextBox.Focus();
                }
                else if (nickelsTextBox.Focused)
                {
                    dimesTextBox.Focus();
                }
                else if (dimesTextBox.Focused)
                {
                    quartersTextBox.Focus();
                }
                else if (quartersTextBox.Focused)
                {
                    rollsTextBox.Focus();
                }
                else if (rollsTextBox.Focused)
                {
                    oneTextBox.Focus();
                }
                else if (oneTextBox.Focused)
                {
                    fiveTextBox.Focus();
                }
                else if (fiveTextBox.Focused)
                {
                    tenTextBox.Focus();
                }
                else if (tenTextBox.Focused)
                {
                    twentyTextBox.Focus();
                }
                else if (twentyTextBox.Focused)
                {
                    fiftyTextBox.Focus();
                }
                else if (fiftyTextBox.Focused)
                {
                    otherTextBox.Focus();
                }
                else if (otherTextBox.Focused)
                {
                    batchTextBox.Focus();
                }
                else if (batchTextBox.Focused)
                {
                    checksTextBox.Focus();
                }
                else if (checksTextBox.Focused)
                {
                    
                }
            }
            //capture right arrow key
            else if(keyData == Keys.Right)
            {
                shiftRevenueTextBox.Focus();
            }
            //capture left arrow key
            else if(keyData == Keys.Left)
            {
                penniesTextBox.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CountForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

