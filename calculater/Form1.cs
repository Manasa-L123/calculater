namespace calculater
{
    public partial class Form1 : Form
    {

        
        
        public Form1()
        {
            InitializeComponent();
           

        }

        
        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblout.Text = string.Empty;
            int a;
            int b;
           a = int.Parse(textnum1.Text);
            b = int.Parse(textnum2.Text);
            int c = a + b;
            lblout.Text = "Addition result is:" + c;
           
            textnum1.Clear();
            textnum2.Clear();
            textnum1.Focus();
        }

       
        private void btnSub_Click(object sender, EventArgs e)
        {
            lblout.Text = string.Empty;
            int a;
            int b;
            a = int.Parse(textnum1.Text);
            
            b = int.Parse(textnum2.Text);

            int c = a - b;
            lblout.Text = "Subtraction result is:" + c;
            textnum1.Clear();
            textnum2.Clear();
            textnum1.Focus();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            lblout.Text = string.Empty;
            int a;
            int b;
            a = int.Parse(textnum1.Text);
            b = int.Parse(textnum2.Text);
            int c = a * b;
            lblout.Text = "Multiplication result is:" + c;
            textnum1.Clear();
            textnum2.Clear();
            textnum1.Focus();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            lblout.Text = string.Empty;
            int a;
            int b;
            a = int.Parse(textnum1.Text);
            textnum2.Focus();
            b = int.Parse(textnum2.Text);
            int c = a /b;
            lblout.Text = "Division result is:" + c;
            textnum1.Clear();
            textnum2.Clear();
            textnum1.Focus();
        }
    }
}
