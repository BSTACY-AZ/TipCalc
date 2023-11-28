namespace TipCalc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {

            string strBillAmt = txtBillAmt.Text;
            double number1 = 0;
            bool canConvert = double.TryParse(strBillAmt, out number1);
            if (canConvert == true)
                calculateAmts(number1);
            else
                MessageBox.Show("Please enter a valid total bill amount.", "Invalid Bill Amount Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtBillAmt.Text = "";
        }

        private void calculateAmts(double billAmt)
        {
            //Calculate a 15% and 20% tip amount
            double dFifteenPct = Math.Round(billAmt * .15, 2);
            double dTwentyPct = Math.Round(billAmt * .20, 2);
            double dFifteenTotal = Math.Round(billAmt + dFifteenPct, 2);
            double dTwentyTotal = Math.Round(billAmt + dTwentyPct, 2);


            //Convert Doubles to String to show in text boxes
            txtFifeentBillAmt.Text = Math.Round(billAmt, 2).ToString("N2");
            txtFifteenTipAmt.Text = dFifteenPct.ToString("N2");
            txtFifteenTotal.Text = dFifteenTotal.ToString("N2");
            txtTwentyBillAmt.Text = Math.Round(billAmt, 2).ToString("N2");
            txtTwentyTipAmt.Text = dTwentyPct.ToString("N2");
            txtTwentyTotal.Text = dTwentyTotal.ToString("N2");

        }


    }
}