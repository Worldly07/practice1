namespace practice1
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal txtNumberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            decimal subtotal =
                Convert.ToDecimal(txtNumberGrade.Text);
            if (txtNumberGrade >= 90)
            {
                txtletterGrade = "A";
            }
            else if (txtNumberGrade >= 80)
            {
                txtletterGrade = "B";
            }
            else if (txtNumberGrade >= 70)
            {
                txtletterGrade = "C";
            }
            else if (txtNumberGrade >= 60)
            {
                txtletterGrade = "D";
            }
            else if (txtNumberGrade >= 50)
            {
                txtletterGrade = "F";
            }




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtletterGrade_TextChanged(object sender, EventArgs e)
        {
            txtletterGrade.Text = txtletterGrade;
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {
            txtNumberGrade.Focus();
        }
    }
}
