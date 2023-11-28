using ManageLibraryApplication.Forms;

namespace ManageLibraryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string User = txbUsername.Text;
            string Password = txbPassword.Text;
            if (User == "" && Password == "")
            {
                UserInformation.isLogin = true;
                UserInformation.UserName = User;
                UserInformation.Password = Password;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Enter the right information, please!","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if (result == DialogResult.Cancel) 
                { 
                    Application.Exit();
                }
            }
        }
    }
}