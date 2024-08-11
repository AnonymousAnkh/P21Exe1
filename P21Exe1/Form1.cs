namespace P21Exe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text), num2 = int.Parse(txtNum2.Text), ans;
            if (num1 > num2)
            {
                ans = num1;
                txtMaxNum.Text = ans.ToString();
            }
            else
            {
                ans = num2;
                txtMaxNum.Text = ans.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}