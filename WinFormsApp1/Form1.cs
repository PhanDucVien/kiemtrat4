namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = textboxusername.Text;
            string pass = textboxmatkhau.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("dang nhap thanh cong");
            }
        }
    }
}