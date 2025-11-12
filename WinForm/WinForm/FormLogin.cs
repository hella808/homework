namespace Win1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_button(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_button(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                //code if true
                MessageBox.Show("Your need to write UserName or Password");
                return;
            }
            if (txtUserName.Text == "123" && txtPassword.Text == "321")
            {
                //code if true
                this.Hide();
                FormMain _formmain = new FormMain();
                _formmain.ShowDialog();

            }
            else
            {
                // code if false
                MessageBox.Show("You UserName or Password not right");
            }

        }
    }
}