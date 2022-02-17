using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnMathWithMe
{
    public partial class Login : Form1  //Iherite form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {    
            GameSetting gameSetting = new GameSetting();
            gameSetting.validateUser(txtUser.Text, txtPassword.Text);
            txtUser.Clear();
            txtPassword.Clear();
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {        
            Register register = new Register();
            register.Show();
            this.Hide();
           
        }
    }
}
